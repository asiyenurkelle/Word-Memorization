namespace kelimeezber
{
    partial class IstatistiklerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IstatistiklerForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.IstatistiklerLbl = new System.Windows.Forms.Label();
            this.GeriPictureBox = new System.Windows.Forms.PictureBox();
            this.ExitPictureBox = new System.Windows.Forms.PictureBox();
            this.IstatistikPictureBox = new System.Windows.Forms.PictureBox();
            this.ResimPictureBox = new System.Windows.Forms.PictureBox();
            this.IstatistiklerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.GeriPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IstatistikPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResimPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IstatistiklerChart)).BeginInit();
            this.SuspendLayout();
            // 
            // IstatistiklerLbl
            // 
            this.IstatistiklerLbl.AutoSize = true;
            this.IstatistiklerLbl.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IstatistiklerLbl.Location = new System.Drawing.Point(321, 21);
            this.IstatistiklerLbl.Name = "IstatistiklerLbl";
            this.IstatistiklerLbl.Size = new System.Drawing.Size(281, 36);
            this.IstatistiklerLbl.TabIndex = 1;
            this.IstatistiklerLbl.Text = "ISTATISTIKLER";
            // 
            // GeriPictureBox
            // 
            this.GeriPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("GeriPictureBox.Image")));
            this.GeriPictureBox.Location = new System.Drawing.Point(12, 12);
            this.GeriPictureBox.Name = "GeriPictureBox";
            this.GeriPictureBox.Size = new System.Drawing.Size(66, 45);
            this.GeriPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GeriPictureBox.TabIndex = 7;
            this.GeriPictureBox.TabStop = false;
            this.GeriPictureBox.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ExitPictureBox
            // 
            this.ExitPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ExitPictureBox.Image")));
            this.ExitPictureBox.Location = new System.Drawing.Point(820, 400);
            this.ExitPictureBox.Name = "ExitPictureBox";
            this.ExitPictureBox.Size = new System.Drawing.Size(100, 50);
            this.ExitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitPictureBox.TabIndex = 8;
            this.ExitPictureBox.TabStop = false;
            this.ExitPictureBox.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // IstatistikPictureBox
            // 
            this.IstatistikPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("IstatistikPictureBox.Image")));
            this.IstatistikPictureBox.Location = new System.Drawing.Point(799, 12);
            this.IstatistikPictureBox.Name = "IstatistikPictureBox";
            this.IstatistikPictureBox.Size = new System.Drawing.Size(133, 120);
            this.IstatistikPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IstatistikPictureBox.TabIndex = 6;
            this.IstatistikPictureBox.TabStop = false;
            // 
            // ResimPictureBox
            // 
            this.ResimPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ResimPictureBox.Image")));
            this.ResimPictureBox.Location = new System.Drawing.Point(12, 117);
            this.ResimPictureBox.Name = "ResimPictureBox";
            this.ResimPictureBox.Size = new System.Drawing.Size(225, 250);
            this.ResimPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ResimPictureBox.TabIndex = 0;
            this.ResimPictureBox.TabStop = false;
            this.ResimPictureBox.Click += new System.EventHandler(this.ResimPictureBox_Click);
            // 
            // IstatistiklerChart
            // 
            chartArea1.Name = "ChartArea1";
            this.IstatistiklerChart.ChartAreas.Add(chartArea1);
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend2";
            this.IstatistiklerChart.Legends.Add(legend1);
            this.IstatistiklerChart.Location = new System.Drawing.Point(252, 80);
            this.IstatistiklerChart.Name = "IstatistiklerChart";
            this.IstatistiklerChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series1.Legend = "Legend2";
            series1.Name = "ezberlenen kelime sayilari";
            this.IstatistiklerChart.Series.Add(series1);
            this.IstatistiklerChart.Size = new System.Drawing.Size(524, 346);
            this.IstatistiklerChart.TabIndex = 14;
            this.IstatistiklerChart.Text = "chart1";
            // 
            // IstatistiklerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 473);
            this.Controls.Add(this.IstatistiklerChart);
            this.Controls.Add(this.ExitPictureBox);
            this.Controls.Add(this.GeriPictureBox);
            this.Controls.Add(this.IstatistikPictureBox);
            this.Controls.Add(this.IstatistiklerLbl);
            this.Controls.Add(this.ResimPictureBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "IstatistiklerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İstatistikler";
            this.Load += new System.EventHandler(this.İstatistikler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GeriPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IstatistikPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResimPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IstatistiklerChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label IstatistiklerLbl;
        private System.Windows.Forms.PictureBox GeriPictureBox;
        private System.Windows.Forms.PictureBox ExitPictureBox;
        private System.Windows.Forms.PictureBox IstatistikPictureBox;
        private System.Windows.Forms.PictureBox ResimPictureBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart IstatistiklerChart;
    }
}