namespace kelimeezber
{
    partial class KelimeEzberleForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelimeEzberleForm));
            this.TurkcesiPictureBox = new System.Windows.Forms.PictureBox();
            this.IngilizcesiPictureBox = new System.Windows.Forms.PictureBox();
            this.KelimeEzberlemeLbl = new System.Windows.Forms.Label();
            this.HazneyeEkleBtn = new System.Windows.Forms.Button();
            this.SonrakiKelimeBtn = new System.Windows.Forms.Button();
            this.GeriTusuBtn = new System.Windows.Forms.Button();
            this.EzbereBaslaBtn = new System.Windows.Forms.Button();
            this.turkcekelimezberlelbl = new System.Windows.Forms.Label();
            this.ingilizcekelimezberlelbl = new System.Windows.Forms.Label();
            this.TurkceEzberleLbl = new System.Windows.Forms.Label();
            this.IngilizceEzberleLbl = new System.Windows.Forms.Label();
            this.sozlukDataSet = new kelimeezber.sozlukDataSet();
            this.sozluktbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sozluktbTableAdapter = new kelimeezber.sozlukDataSetTableAdapters.sozluktbTableAdapter();
            this.OgrenileceklerListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExitpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TurkcesiPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IngilizcesiPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sozlukDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sozluktbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TurkcesiPictureBox
            // 
            this.TurkcesiPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TurkcesiPictureBox.Image")));
            this.TurkcesiPictureBox.Location = new System.Drawing.Point(149, 107);
            this.TurkcesiPictureBox.Name = "TurkcesiPictureBox";
            this.TurkcesiPictureBox.Size = new System.Drawing.Size(69, 62);
            this.TurkcesiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TurkcesiPictureBox.TabIndex = 2;
            this.TurkcesiPictureBox.TabStop = false;
            this.TurkcesiPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // IngilizcesiPictureBox
            // 
            this.IngilizcesiPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("IngilizcesiPictureBox.Image")));
            this.IngilizcesiPictureBox.Location = new System.Drawing.Point(650, 107);
            this.IngilizcesiPictureBox.Name = "IngilizcesiPictureBox";
            this.IngilizcesiPictureBox.Size = new System.Drawing.Size(73, 62);
            this.IngilizcesiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IngilizcesiPictureBox.TabIndex = 3;
            this.IngilizcesiPictureBox.TabStop = false;
            // 
            // KelimeEzberlemeLbl
            // 
            this.KelimeEzberlemeLbl.AutoSize = true;
            this.KelimeEzberlemeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KelimeEzberlemeLbl.Location = new System.Drawing.Point(275, 54);
            this.KelimeEzberlemeLbl.Name = "KelimeEzberlemeLbl";
            this.KelimeEzberlemeLbl.Size = new System.Drawing.Size(284, 31);
            this.KelimeEzberlemeLbl.TabIndex = 4;
            this.KelimeEzberlemeLbl.Text = "KELIME EZBERLEME";
            this.KelimeEzberlemeLbl.Click += new System.EventHandler(this.kelimeezberlemelbl_Click);
            // 
            // HazneyeEkleBtn
            // 
            this.HazneyeEkleBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HazneyeEkleBtn.Location = new System.Drawing.Point(238, 254);
            this.HazneyeEkleBtn.Name = "HazneyeEkleBtn";
            this.HazneyeEkleBtn.Size = new System.Drawing.Size(135, 94);
            this.HazneyeEkleBtn.TabIndex = 5;
            this.HazneyeEkleBtn.Text = "Hazneye Ekle";
            this.HazneyeEkleBtn.UseVisualStyleBackColor = true;
            this.HazneyeEkleBtn.Click += new System.EventHandler(this.Hazneyeeklebtn_Click);
            // 
            // SonrakiKelimeBtn
            // 
            this.SonrakiKelimeBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SonrakiKelimeBtn.Location = new System.Drawing.Point(415, 254);
            this.SonrakiKelimeBtn.Name = "SonrakiKelimeBtn";
            this.SonrakiKelimeBtn.Size = new System.Drawing.Size(126, 94);
            this.SonrakiKelimeBtn.TabIndex = 6;
            this.SonrakiKelimeBtn.Text = "Başka Kelimeye Geç";
            this.SonrakiKelimeBtn.UseVisualStyleBackColor = true;
            this.SonrakiKelimeBtn.Click += new System.EventHandler(this.sonrakikelimebtn_Click);
            // 
            // GeriTusuBtn
            // 
            this.GeriTusuBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GeriTusuBtn.BackgroundImage")));
            this.GeriTusuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GeriTusuBtn.Location = new System.Drawing.Point(12, 12);
            this.GeriTusuBtn.Name = "GeriTusuBtn";
            this.GeriTusuBtn.Size = new System.Drawing.Size(75, 53);
            this.GeriTusuBtn.TabIndex = 7;
            this.GeriTusuBtn.UseVisualStyleBackColor = true;
            this.GeriTusuBtn.Click += new System.EventHandler(this.geritusubtn_Click);
            // 
            // EzbereBaslaBtn
            // 
            this.EzbereBaslaBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EzbereBaslaBtn.Location = new System.Drawing.Point(69, 254);
            this.EzbereBaslaBtn.Name = "EzbereBaslaBtn";
            this.EzbereBaslaBtn.Size = new System.Drawing.Size(133, 94);
            this.EzbereBaslaBtn.TabIndex = 9;
            this.EzbereBaslaBtn.Text = "Ezberlemeye Başla";
            this.EzbereBaslaBtn.UseVisualStyleBackColor = true;
            this.EzbereBaslaBtn.Click += new System.EventHandler(this.ezberebaslabtn_Click);
            // 
            // turkcekelimezberlelbl
            // 
            this.turkcekelimezberlelbl.AutoSize = true;
            this.turkcekelimezberlelbl.Location = new System.Drawing.Point(250, 207);
            this.turkcekelimezberlelbl.Name = "turkcekelimezberlelbl";
            this.turkcekelimezberlelbl.Size = new System.Drawing.Size(0, 13);
            this.turkcekelimezberlelbl.TabIndex = 10;
            this.turkcekelimezberlelbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // ingilizcekelimezberlelbl
            // 
            this.ingilizcekelimezberlelbl.AutoSize = true;
            this.ingilizcekelimezberlelbl.Location = new System.Drawing.Point(493, 228);
            this.ingilizcekelimezberlelbl.Name = "ingilizcekelimezberlelbl";
            this.ingilizcekelimezberlelbl.Size = new System.Drawing.Size(0, 13);
            this.ingilizcekelimezberlelbl.TabIndex = 11;
            // 
            // TurkceEzberleLbl
            // 
            this.TurkceEzberleLbl.AutoSize = true;
            this.TurkceEzberleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TurkceEzberleLbl.Location = new System.Drawing.Point(268, 145);
            this.TurkceEzberleLbl.Name = "TurkceEzberleLbl";
            this.TurkceEzberleLbl.Size = new System.Drawing.Size(66, 24);
            this.TurkceEzberleLbl.TabIndex = 12;
            this.TurkceEzberleLbl.Text = "label1";
            this.TurkceEzberleLbl.Click += new System.EventHandler(this.turkceezberlelbl_Click);
            // 
            // IngilizceEzberleLbl
            // 
            this.IngilizceEzberleLbl.AutoSize = true;
            this.IngilizceEzberleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IngilizceEzberleLbl.Location = new System.Drawing.Point(493, 145);
            this.IngilizceEzberleLbl.Name = "IngilizceEzberleLbl";
            this.IngilizceEzberleLbl.Size = new System.Drawing.Size(66, 24);
            this.IngilizceEzberleLbl.TabIndex = 13;
            this.IngilizceEzberleLbl.Text = "label1";
            this.IngilizceEzberleLbl.Click += new System.EventHandler(this.ingilizcezberlelbl_Click);
            // 
            // sozlukDataSet
            // 
            this.sozlukDataSet.DataSetName = "sozlukDataSet";
            this.sozlukDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sozluktbBindingSource
            // 
            this.sozluktbBindingSource.DataMember = "sozluktb";
            this.sozluktbBindingSource.DataSource = this.sozlukDataSet;
            // 
            // sozluktbTableAdapter
            // 
            this.sozluktbTableAdapter.ClearBeforeFill = true;
            // 
            // OgrenileceklerListView
            // 
            this.OgrenileceklerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.OgrenileceklerListView.Location = new System.Drawing.Point(617, 203);
            this.OgrenileceklerListView.Name = "OgrenileceklerListView";
            this.OgrenileceklerListView.Size = new System.Drawing.Size(289, 190);
            this.OgrenileceklerListView.TabIndex = 14;
            this.OgrenileceklerListView.UseCompatibleStateImageBehavior = false;
            this.OgrenileceklerListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            this.columnHeader1.Width = 81;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "turkce";
            this.columnHeader2.Width = 67;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ingilizce";
            this.columnHeader3.Width = 78;
            // 
            // ExitpictureBox
            // 
            this.ExitpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ExitpictureBox.Image")));
            this.ExitpictureBox.Location = new System.Drawing.Point(806, 399);
            this.ExitpictureBox.Name = "ExitpictureBox";
            this.ExitpictureBox.Size = new System.Drawing.Size(100, 50);
            this.ExitpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitpictureBox.TabIndex = 15;
            this.ExitpictureBox.TabStop = false;
            this.ExitpictureBox.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // KelimeEzberleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(918, 451);
            this.Controls.Add(this.ExitpictureBox);
            this.Controls.Add(this.OgrenileceklerListView);
            this.Controls.Add(this.IngilizceEzberleLbl);
            this.Controls.Add(this.TurkceEzberleLbl);
            this.Controls.Add(this.ingilizcekelimezberlelbl);
            this.Controls.Add(this.turkcekelimezberlelbl);
            this.Controls.Add(this.EzbereBaslaBtn);
            this.Controls.Add(this.GeriTusuBtn);
            this.Controls.Add(this.SonrakiKelimeBtn);
            this.Controls.Add(this.HazneyeEkleBtn);
            this.Controls.Add(this.KelimeEzberlemeLbl);
            this.Controls.Add(this.IngilizcesiPictureBox);
            this.Controls.Add(this.TurkcesiPictureBox);
            this.Name = "KelimeEzberleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kelimeezberle";
            this.Load += new System.EventHandler(this.kelimeezberle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TurkcesiPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IngilizcesiPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sozlukDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sozluktbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox TurkcesiPictureBox;
        private System.Windows.Forms.PictureBox IngilizcesiPictureBox;
        private System.Windows.Forms.Label KelimeEzberlemeLbl;
        private System.Windows.Forms.Button HazneyeEkleBtn;
        private System.Windows.Forms.Button SonrakiKelimeBtn;
        private System.Windows.Forms.Button GeriTusuBtn;
        private System.Windows.Forms.Button EzbereBaslaBtn;
        private System.Windows.Forms.Label turkcekelimezberlelbl;
        private System.Windows.Forms.Label ingilizcekelimezberlelbl;
        private System.Windows.Forms.Label TurkceEzberleLbl;
        private System.Windows.Forms.Label IngilizceEzberleLbl;
        private sozlukDataSet sozlukDataSet;
        private System.Windows.Forms.BindingSource sozluktbBindingSource;
        private sozlukDataSetTableAdapters.sozluktbTableAdapter sozluktbTableAdapter;
        private System.Windows.Forms.ListView OgrenileceklerListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox ExitpictureBox;
    }
}