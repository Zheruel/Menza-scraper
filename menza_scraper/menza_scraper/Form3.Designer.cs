namespace menza_scraper
{
    partial class menza_scraper_statistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menza_scraper_statistics));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.forward_button = new System.Windows.Forms.Button();
            this.backward_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1092, 430);
            this.dataGridView1.TabIndex = 0;
            // 
            // forward_button
            // 
            this.forward_button.Location = new System.Drawing.Point(898, 448);
            this.forward_button.Name = "forward_button";
            this.forward_button.Size = new System.Drawing.Size(206, 60);
            this.forward_button.TabIndex = 1;
            this.forward_button.Text = "Go Forwards";
            this.forward_button.UseVisualStyleBackColor = true;
            this.forward_button.Click += new System.EventHandler(this.Forward_button_Click);
            // 
            // backward_button
            // 
            this.backward_button.Location = new System.Drawing.Point(686, 448);
            this.backward_button.Name = "backward_button";
            this.backward_button.Size = new System.Drawing.Size(206, 60);
            this.backward_button.TabIndex = 2;
            this.backward_button.Text = "Go Backwards";
            this.backward_button.UseVisualStyleBackColor = true;
            this.backward_button.Click += new System.EventHandler(this.Backward_button_Click);
            // 
            // menza_scraper_statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 520);
            this.Controls.Add(this.backward_button);
            this.Controls.Add(this.forward_button);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "menza_scraper_statistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menza Scraper - Statistics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menza_scraper_statistics_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button forward_button;
        private System.Windows.Forms.Button backward_button;
    }
}