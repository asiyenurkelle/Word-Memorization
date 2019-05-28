namespace kelimeezber
{
    partial class KullanıcıGirisiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıGirisiForm));
            this.KullanıcıAdıLbl = new System.Windows.Forms.Label();
            this.SifreLbl = new System.Windows.Forms.Label();
            this.KullanıcıAdıtTxtbx = new System.Windows.Forms.TextBox();
            this.SifreTxtbx = new System.Windows.Forms.TextBox();
            this.GirisYapBtn = new System.Windows.Forms.Button();
            this.GirisPictureBox = new System.Windows.Forms.PictureBox();
            this.BaslıkLbl = new System.Windows.Forms.Label();
            this.BaykuspictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GirisPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaykuspictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // KullanıcıAdıLbl
            // 
            this.KullanıcıAdıLbl.AutoSize = true;
            this.KullanıcıAdıLbl.BackColor = System.Drawing.SystemColors.Control;
            this.KullanıcıAdıLbl.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KullanıcıAdıLbl.ForeColor = System.Drawing.Color.Black;
            this.KullanıcıAdıLbl.Location = new System.Drawing.Point(295, 167);
            this.KullanıcıAdıLbl.Name = "KullanıcıAdıLbl";
            this.KullanıcıAdıLbl.Size = new System.Drawing.Size(147, 21);
            this.KullanıcıAdıLbl.TabIndex = 0;
            this.KullanıcıAdıLbl.Text = "Kullanıcı Adı:\r\n";
            // 
            // SifreLbl
            // 
            this.SifreLbl.AutoSize = true;
            this.SifreLbl.BackColor = System.Drawing.SystemColors.Control;
            this.SifreLbl.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SifreLbl.ForeColor = System.Drawing.Color.Black;
            this.SifreLbl.Location = new System.Drawing.Point(316, 226);
            this.SifreLbl.Name = "SifreLbl";
            this.SifreLbl.Size = new System.Drawing.Size(63, 21);
            this.SifreLbl.TabIndex = 1;
            this.SifreLbl.Text = "Sifre:";
            // 
            // KullanıcıAdıtTxtbx
            // 
            this.KullanıcıAdıtTxtbx.Location = new System.Drawing.Point(490, 168);
            this.KullanıcıAdıtTxtbx.MaxLength = 15;
            this.KullanıcıAdıtTxtbx.Name = "KullanıcıAdıtTxtbx";
            this.KullanıcıAdıtTxtbx.Size = new System.Drawing.Size(100, 20);
            this.KullanıcıAdıtTxtbx.TabIndex = 2;
            // 
            // SifreTxtbx
            // 
            this.SifreTxtbx.Location = new System.Drawing.Point(490, 229);
            this.SifreTxtbx.MaxLength = 15;
            this.SifreTxtbx.Name = "SifreTxtbx";
            this.SifreTxtbx.Size = new System.Drawing.Size(100, 20);
            this.SifreTxtbx.TabIndex = 3;
            this.SifreTxtbx.UseSystemPasswordChar = true;
            // 
            // GirisYapBtn
            // 
            this.GirisYapBtn.BackColor = System.Drawing.Color.White;
            this.GirisYapBtn.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GirisYapBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.GirisYapBtn.Location = new System.Drawing.Point(358, 281);
            this.GirisYapBtn.Name = "GirisYapBtn";
            this.GirisYapBtn.Size = new System.Drawing.Size(176, 94);
            this.GirisYapBtn.TabIndex = 4;
            this.GirisYapBtn.Text = "GIRIS YAP";
            this.GirisYapBtn.UseVisualStyleBackColor = false;
            this.GirisYapBtn.Click += new System.EventHandler(this.girisyapbtn_Click);
            // 
            // GirisPictureBox
            // 
            this.GirisPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("GirisPictureBox.Image")));
            this.GirisPictureBox.Location = new System.Drawing.Point(34, 126);
            this.GirisPictureBox.Name = "GirisPictureBox";
            this.GirisPictureBox.Size = new System.Drawing.Size(211, 201);
            this.GirisPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GirisPictureBox.TabIndex = 5;
            this.GirisPictureBox.TabStop = false;
            // 
            // BaslıkLbl
            // 
            this.BaslıkLbl.AutoSize = true;
            this.BaslıkLbl.BackColor = System.Drawing.Color.FloralWhite;
            this.BaslıkLbl.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaslıkLbl.Location = new System.Drawing.Point(282, 66);
            this.BaslıkLbl.Name = "BaslıkLbl";
            this.BaslıkLbl.Size = new System.Drawing.Size(345, 32);
            this.BaslıkLbl.TabIndex = 6;
            this.BaslıkLbl.Text = "SÖZLÜK ve KELİME EZBER";
            // 
            // BaykuspictureBox
            // 
            this.BaykuspictureBox.Image = ((System.Drawing.Image)(resources.GetObject("BaykuspictureBox.Image")));
            this.BaykuspictureBox.Location = new System.Drawing.Point(664, 126);
            this.BaykuspictureBox.Name = "BaykuspictureBox";
            this.BaykuspictureBox.Size = new System.Drawing.Size(243, 207);
            this.BaykuspictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BaykuspictureBox.TabIndex = 7;
            this.BaykuspictureBox.TabStop = false;
            // 
            // KullanıcıGirisiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.BaykuspictureBox);
            this.Controls.Add(this.BaslıkLbl);
            this.Controls.Add(this.GirisPictureBox);
            this.Controls.Add(this.GirisYapBtn);
            this.Controls.Add(this.SifreTxtbx);
            this.Controls.Add(this.KullanıcıAdıtTxtbx);
            this.Controls.Add(this.SifreLbl);
            this.Controls.Add(this.KullanıcıAdıLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullanıcıGirisiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcıgirisi";
            this.Load += new System.EventHandler(this.Kullanıcıgirisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GirisPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaykuspictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KullanıcıAdıLbl;
        private System.Windows.Forms.Label SifreLbl;
        private System.Windows.Forms.TextBox KullanıcıAdıtTxtbx;
        private System.Windows.Forms.TextBox SifreTxtbx;
        private System.Windows.Forms.Button GirisYapBtn;
        private System.Windows.Forms.PictureBox GirisPictureBox;
        private System.Windows.Forms.Label BaslıkLbl;
        private System.Windows.Forms.PictureBox BaykuspictureBox;
    }
}