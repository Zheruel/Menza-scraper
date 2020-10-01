namespace menza_scraper
{
    partial class menza_scraper_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menza_scraper_main));
            this.banner = new System.Windows.Forms.PictureBox();
            this.JMBAG_richtextbox = new System.Windows.Forms.RichTextBox();
            this.scrape_button = new System.Windows.Forms.Button();
            this.JMBAG_label = new System.Windows.Forms.Label();
            this.options_groupbox = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progress_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            this.options_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // banner
            // 
            this.banner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("banner.BackgroundImage")));
            this.banner.Location = new System.Drawing.Point(12, 12);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(380, 169);
            this.banner.TabIndex = 3;
            this.banner.TabStop = false;
            // 
            // JMBAG_richtextbox
            // 
            this.JMBAG_richtextbox.Location = new System.Drawing.Point(12, 220);
            this.JMBAG_richtextbox.Name = "JMBAG_richtextbox";
            this.JMBAG_richtextbox.Size = new System.Drawing.Size(223, 312);
            this.JMBAG_richtextbox.TabIndex = 4;
            this.JMBAG_richtextbox.Text = "";
            // 
            // scrape_button
            // 
            this.scrape_button.Location = new System.Drawing.Point(241, 480);
            this.scrape_button.Name = "scrape_button";
            this.scrape_button.Size = new System.Drawing.Size(151, 52);
            this.scrape_button.TabIndex = 5;
            this.scrape_button.Text = "Start Scraping";
            this.scrape_button.UseVisualStyleBackColor = true;
            this.scrape_button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // JMBAG_label
            // 
            this.JMBAG_label.AutoSize = true;
            this.JMBAG_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.JMBAG_label.Location = new System.Drawing.Point(39, 197);
            this.JMBAG_label.Name = "JMBAG_label";
            this.JMBAG_label.Size = new System.Drawing.Size(130, 20);
            this.JMBAG_label.TabIndex = 7;
            this.JMBAG_label.Text = "Enter JMBAG(s):";
            // 
            // options_groupbox
            // 
            this.options_groupbox.Controls.Add(this.label6);
            this.options_groupbox.Controls.Add(this.label7);
            this.options_groupbox.Controls.Add(this.label4);
            this.options_groupbox.Controls.Add(this.label5);
            this.options_groupbox.Controls.Add(this.label3);
            this.options_groupbox.Controls.Add(this.label2);
            this.options_groupbox.Controls.Add(this.label1);
            this.options_groupbox.Controls.Add(this.progress_label);
            this.options_groupbox.Controls.Add(this.progressBar1);
            this.options_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.options_groupbox.Location = new System.Drawing.Point(241, 214);
            this.options_groupbox.Name = "options_groupbox";
            this.options_groupbox.Size = new System.Drawing.Size(151, 260);
            this.options_groupbox.TabIndex = 8;
            this.options_groupbox.TabStop = false;
            this.options_groupbox.Text = "Progress: ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 61);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(139, 25);
            this.progressBar1.TabIndex = 0;
            // 
            // progress_label
            // 
            this.progress_label.AutoSize = true;
            this.progress_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.progress_label.Location = new System.Drawing.Point(51, 41);
            this.progress_label.Name = "progress_label";
            this.progress_label.Size = new System.Drawing.Size(36, 17);
            this.progress_label.TabIndex = 1;
            this.progress_label.Text = "0 / 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Students Scraped";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Receipts Scraped";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(54, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(54, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "0 kn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(6, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Money Spent: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(54, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "0 kn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(6, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Of That Subsided: ";
            // 
            // menza_scraper_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 544);
            this.Controls.Add(this.options_groupbox);
            this.Controls.Add(this.JMBAG_label);
            this.Controls.Add(this.scrape_button);
            this.Controls.Add(this.JMBAG_richtextbox);
            this.Controls.Add(this.banner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "menza_scraper_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menza Scraper - Scraping Hub";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menza_scraper_main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.banner)).EndInit();
            this.options_groupbox.ResumeLayout(false);
            this.options_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox banner;
        private System.Windows.Forms.RichTextBox JMBAG_richtextbox;
        private System.Windows.Forms.Button scrape_button;
        private System.Windows.Forms.Label JMBAG_label;
        private System.Windows.Forms.GroupBox options_groupbox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label progress_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}