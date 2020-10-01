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
using System.Media;

namespace menza_scraper
{
  
    public partial class menza_scraper_login : Form
    {

        public menza_scraper_login()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            login_check(login_username_textbox.Text, login_password_textbox.Text);
        }

        public async void login_check(string username, string password)
        {
            try
            {
                HttpClient client = new HttpClient();
                var htmlDoc = new HtmlAgilityPack.HtmlDocument();

                /* zastita 1 */
                var responseString = await client.GetStringAsync("https://issp.srce.hr/isspaaieduhr/login.ashx");
                htmlDoc.LoadHtml(responseString);
                var SAML_Request1 = htmlDoc.GetElementbyId("SAMLRequest").GetAttributeValue("value", "");
                var values = new Dictionary<string, string>
            {
               { "SAMLRequest", SAML_Request1}
            };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync("https://login.aaiedu.hr/ms/saml2/idp/SSOService.php", content);
                var responseString1 = await response.Content.ReadAsStringAsync();
                htmlDoc.LoadHtml(responseString1);
                var AuthState = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='" + "aai_login_form" + "']/form/input[@type='" + "hidden" + "']").Attributes["value"].Value;
                values = new Dictionary<string, string>
            {
               { "username", username},
               { "password", password},
               { "Submit", "Prijavi se"},
               { "AuthState", AuthState}
            };
                content = new FormUrlEncodedContent(values);
                response = await client.PostAsync("https://login.aaiedu.hr/sso/module.php/core/loginuserpass.php?", content);
                /* zastita 2 */
                var responseString2 = await response.Content.ReadAsStringAsync();
                htmlDoc.LoadHtml(responseString2);
                var SAML_Request2 = htmlDoc.DocumentNode.SelectSingleNode("//form/input[@type='" + "hidden" + "']").Attributes["value"].Value;
                values = new Dictionary<string, string>
            {
               { "SAMLResponse", SAML_Request2}
            };
                content = new FormUrlEncodedContent(values);
                response = await client.PostAsync("https://login.aaiedu.hr/ms/module.php/saml/sp/saml2-acs.php/default-sp", content);
                /* zastita 3 (ni sam neznam kako im se dalo) */
                var responseString3 = await response.Content.ReadAsStringAsync();
                htmlDoc.LoadHtml(responseString3);
                var SAML_Request3 = htmlDoc.DocumentNode.SelectSingleNode("//form/input[@type='" + "hidden" + "']").Attributes["value"].Value;
                values = new Dictionary<string, string>
            {
               { "SAMLResponse", SAML_Request3}
            };
                content = new FormUrlEncodedContent(values);
                response = await client.PostAsync("https://issp.srce.hr/ISSPAAIEduHr/login.ashx", content);
                /* napokon u stranici */
                var responseString4 = await response.Content.ReadAsStringAsync();
                menza_scraper_main menza_scraper_main_form = new menza_scraper_main(client, responseString4);
                menza_scraper_main_form.Show();
                this.Hide();
            }
            catch
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Login nije uspio, provjerite svoje podatke");
                login_username_textbox.Clear();
                login_password_textbox.Clear();
            }
        }
    }
}
