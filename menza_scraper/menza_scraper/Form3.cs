using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace menza_scraper
{
    public partial class menza_scraper_statistics : Form
    {
        int counter;
        int safety = 1;
        public menza_scraper_statistics()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (File.Exists("Statistike.xml"))
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml("Statistike.xml");
                counter = 0;
                safety = 0;
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            else
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Statistike ne postoje!");
            }
        }

        private void Backward_button_Click(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter--;
                DataSet dataSet = new DataSet();
                dataSet.ReadXml("Statistike.xml");
                dataGridView1.DataSource = dataSet.Tables[counter];
            }
            else
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Ne mogu ici dalje nazad");
            }
        }

        private void Forward_button_Click(object sender, EventArgs e)
        {
            if (counter <= 1 && safety != 1)
            {
                counter++;
                DataSet dataSet = new DataSet();
                dataSet.ReadXml("Statistike.xml");
                dataGridView1.DataSource = dataSet.Tables[counter];
            }
            else
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Ne mogu ici dalje naprijed");
            }
        }

        private void Menza_scraper_statistics_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
