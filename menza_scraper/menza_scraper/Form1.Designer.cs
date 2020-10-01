namespace menza_scraper
{
    partial class menza_scraper_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menza_scraper_login));
            this.login_button = new System.Windows.Forms.Button();
            this.login_password_label = new System.Windows.Forms.Label();
            this.login_password_textbox = new System.Windows.Forms.TextBox();
            this.login_username_label = new System.Windows.Forms.Label();
            this.login_username_textbox = new System.Windows.Forms.TextBox();
            this.login_header_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.login_button.Location = new System.Drawing.Point(16, 135);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(310, 45);
            this.login_button.TabIndex = 11;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // login_password_label
            // 
            this.login_password_label.AutoSize = true;
            this.login_password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.login_password_label.Location = new System.Drawing.Point(13, 81);
            this.login_password_label.Name = "login_password_label";
            this.login_password_label.Size = new System.Drawing.Size(79, 18);
            this.login_password_label.TabIndex = 10;
            this.login_password_label.Text = "Password:";
            // 
            // login_password_textbox
            // 
            this.login_password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.login_password_textbox.Location = new System.Drawing.Point(16, 101);
            this.login_password_textbox.Name = "login_password_textbox";
            this.login_password_textbox.PasswordChar = '*';
            this.login_password_textbox.Size = new System.Drawing.Size(310, 23);
            this.login_password_textbox.TabIndex = 9;
            // 
            // login_username_label
            // 
            this.login_username_label.AutoSize = true;
            this.login_username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.login_username_label.Location = new System.Drawing.Point(13, 38);
            this.login_username_label.Name = "login_username_label";
            this.login_username_label.Size = new System.Drawing.Size(81, 18);
            this.login_username_label.TabIndex = 8;
            this.login_username_label.Text = "Username:";
            // 
            // login_username_textbox
            // 
            this.login_username_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.login_username_textbox.Location = new System.Drawing.Point(16, 58);
            this.login_username_textbox.Name = "login_username_textbox";
            this.login_username_textbox.Size = new System.Drawing.Size(310, 23);
            this.login_username_textbox.TabIndex = 7;
            // 
            // login_header_label
            // 
            this.login_header_label.AutoSize = true;
            this.login_header_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.login_header_label.Location = new System.Drawing.Point(12, 9);
            this.login_header_label.Name = "login_header_label";
            this.login_header_label.Size = new System.Drawing.Size(310, 20);
            this.login_header_label.TabIndex = 6;
            this.login_header_label.Text = "Unesite svoje @alledu korisnicke podatke: ";
            // 
            // menza_scraper_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 192);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.login_password_label);
            this.Controls.Add(this.login_password_textbox);
            this.Controls.Add(this.login_username_label);
            this.Controls.Add(this.login_username_textbox);
            this.Controls.Add(this.login_header_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "menza_scraper_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menza Scraper - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label login_password_label;
        public System.Windows.Forms.TextBox login_password_textbox;
        private System.Windows.Forms.Label login_username_label;
        public System.Windows.Forms.TextBox login_username_textbox;
        private System.Windows.Forms.Label login_header_label;
    }
}

