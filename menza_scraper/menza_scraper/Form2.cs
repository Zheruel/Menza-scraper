using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using HtmlAgilityPack;
using System.Xml.Linq;
using System.Media;

namespace menza_scraper
{
    public partial class menza_scraper_main : Form
    {
        HttpClient http_client;
        string response_string;
        int counter;
        int broj_racuna;
        double spent;
        double subsided;

        public async void scrape(HttpClient client, string[] JMBAGS)
        {
            var htmlDoc = new HtmlAgilityPack.HtmlDocument();
            /* kreiranje xmla */
            XDocument doc = new XDocument(
            new XDeclaration("1.0", "UTF-8", "yes"),
            new XComment("XML dokument koji prati podatke"),
            new XElement("Studenti"));
            doc.Save("Statistike.xml");

            foreach (var JMBAG in JMBAGS)
            {
                counter++;
                try
                {
                    var racuni1 = await client.GetStringAsync("https://issp.srce.hr/StudentRacun?" + "oib=" + "999999" + "&jmbag=" + JMBAG);
                    htmlDoc.LoadHtml(racuni1);

                    var safety = 1;
                    var safety1 = 1;
                    var htmlDoc2 = new HtmlAgilityPack.HtmlDocument();
                    var racun_id = 0;


                    foreach (HtmlNode table in htmlDoc.DocumentNode.SelectNodes("//table"))
                    {
                        var infozaracun = table.SelectNodes("//td/a[@class='" + "cap-get-detalji-racuna" + "']");
                        List<string> detaljni_info = new List<string>();
                        foreach (var racun in infozaracun)
                        {
                            detaljni_info.Add(racun.Attributes["data-racunid"].Value);
                        }
                        var tracker = 0;
                        Console.WriteLine("Found: " + table.Id);
                        doc.Element("Studenti").Add(new XElement("Student", new XAttribute("JMBAG", JMBAG)));
                        doc.Save("Statistike.xml");
                        foreach (HtmlNode row in table.SelectNodes("tr"))
                        {
                            if (safety != 1)
                            {
                                broj_racuna++;
                                racun_id++;
                                Console.WriteLine("row");
                                List<string> cells = new List<string>();
                                foreach (HtmlNode cell in row.SelectNodes("th|td"))
                                {
                                    cells.Add(cell.InnerText.Trim());
                                }
                                doc.Element("Studenti").Elements("Student").Where(x => x.Attribute("JMBAG").Value == JMBAG).FirstOrDefault().Add(
                                new XElement("Racun", new XAttribute("ID", racun_id),
                                new XElement("Ime", cells[0].Replace("&quot;", "")),
                                new XElement("Vrijeme", cells[1]),
                                new XElement("Cijena", cells[2].Replace(",", ".")),
                                new XElement("Subvencija", cells[3].Replace(",", "."))
                                ));
                                doc.Save("Statistike.xml");
                            }
                            else
                            {
                                safety = 0;
                            }
                            if (safety1 != 1)
                            {
                                string[] words = detaljni_info[tracker].Split(';');
                                Dictionary<string, string> values = new Dictionary<string, string>
                        {
                           { "BrDnevnika", words[2]},
                           { "BrRacunala", words[1]},
                           { "DatumDnevnika", words[3]},
                           { "MatBrUstanove", words[0]}
                        };
                                var content = new FormUrlEncodedContent(values);
                                var response = await client.PostAsync("https://issp.srce.hr/StudentRacun/RacunDetalji", content);
                                var responseString5 = await response.Content.ReadAsStringAsync();
                                htmlDoc2.LoadHtml(responseString5);
                                /* detalji racuna */
                                foreach (HtmlNode table1 in htmlDoc2.DocumentNode.SelectNodes("//table"))
                                {
                                    var safetybar = 1;
                                    Console.WriteLine("Found: " + table1.Id);
                                    foreach (HtmlNode row1 in table1.SelectNodes("tr"))
                                    {
                                        if (safetybar != 1)
                                        {
                                            List<string> cells1 = new List<string>();
                                            Console.WriteLine("row");
                                            foreach (HtmlNode cell1 in row1.SelectNodes("th|td"))
                                            {
                                                cells1.Add(cell1.InnerText.Trim());
                                            }
                                            Console.WriteLine(cells1[0]);
                                            Console.WriteLine(cells1[1]);
                                            Console.WriteLine(cells1[2]);
                                            Console.WriteLine(cells1[3]);
                                            Console.WriteLine(cells1[4]);
                                            Console.WriteLine(cells1[5]);
                                            spent = spent + Convert.ToDouble(cells1[4].Replace(",", "."));
                                            label4.Text = Math.Round(spent) + " kn";
                                            subsided = subsided + Convert.ToDouble(cells1[5].Replace(",", "."));
                                            label6.Text = Math.Round(subsided) + " kn";
                                            doc.Element("Studenti").Elements("Student").Where(x => x.Attribute("JMBAG").Value == JMBAG).FirstOrDefault().Elements("Racun").Where(y => y.Attribute("ID").Value == racun_id.ToString()).FirstOrDefault().Add(
                                            new XElement("Artikl",
                                            new XElement("Naziv_Artikla", cells1[1]),
                                            new XElement("Cijena_Artikla", cells1[2].Replace(",", ".")),
                                            new XElement("Kol.", cells1[3]),
                                            new XElement("Ukupna_Cijena", cells1[4].Replace(",", ".")),
                                            new XElement("Iznos_Subvencije", cells1[5].Replace(",", "."))
                                            ));
                                        }
                                        else
                                        {
                                            safetybar = 0;
                                        }
                                    }
                                }
                                tracker++;
                            }
                            else
                            {
                                safety1 = 0;
                            }
                            label3.Text = broj_racuna.ToString();
                            doc.Save("Statistike.xml");
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Error");
                }
                progressBar1.Value = counter;
                progress_label.Text = counter + " / " + JMBAGS.Length;
            }
            SystemSounds.Hand.Play();
            MessageBox.Show("Done scraping");
            menza_scraper_statistics menza_scraper_statistics_form = new menza_scraper_statistics();
            menza_scraper_statistics_form.Show();
            this.Hide();
        }

        public menza_scraper_main(HttpClient client, string response)
        {
            http_client = client;
            response_string = response;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void Menza_scraper_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string [] JMBAGS = JMBAG_richtextbox.Text.Split('\n');
            progressBar1.Maximum = JMBAGS.Length;
            progress_label.Text = "0 / " + JMBAGS.Length;
            scrape(http_client, JMBAGS);
        }

    }
}
