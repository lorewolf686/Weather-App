namespace XMLWeather
{
    partial class ForecastScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.icon2 = new System.Windows.Forms.PictureBox();
            this.icon1 = new System.Windows.Forms.PictureBox();
            this.icon3 = new System.Windows.Forms.PictureBox();
            this.current1 = new System.Windows.Forms.Label();
            this.current3 = new System.Windows.Forms.Label();
            this.current2 = new System.Windows.Forms.Label();
            this.max1 = new System.Windows.Forms.Label();
            this.max3 = new System.Windows.Forms.Label();
            this.max2 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.date3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon3)).BeginInit();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.Black;
            this.forecastLabel.Location = new System.Drawing.Point(244, 10);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "3 Day";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 61;
            this.label3.Text = "Today";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // icon2
            // 
            this.icon2.BackColor = System.Drawing.Color.Transparent;
            this.icon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon2.Location = new System.Drawing.Point(41, 265);
            this.icon2.Name = "icon2";
            this.icon2.Size = new System.Drawing.Size(100, 88);
            this.icon2.TabIndex = 64;
            this.icon2.TabStop = false;
            // 
            // icon1
            // 
            this.icon1.BackColor = System.Drawing.Color.Transparent;
            this.icon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon1.Location = new System.Drawing.Point(41, 79);
            this.icon1.Name = "icon1";
            this.icon1.Size = new System.Drawing.Size(100, 88);
            this.icon1.TabIndex = 65;
            this.icon1.TabStop = false;
            // 
            // icon3
            // 
            this.icon3.BackColor = System.Drawing.Color.Transparent;
            this.icon3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon3.Location = new System.Drawing.Point(41, 437);
            this.icon3.Name = "icon3";
            this.icon3.Size = new System.Drawing.Size(100, 88);
            this.icon3.TabIndex = 66;
            this.icon3.TabStop = false;
            // 
            // current1
            // 
            this.current1.AutoSize = true;
            this.current1.BackColor = System.Drawing.Color.Transparent;
            this.current1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current1.Location = new System.Drawing.Point(187, 79);
            this.current1.Name = "current1";
            this.current1.Size = new System.Drawing.Size(102, 80);
            this.current1.TabIndex = 67;
            this.current1.Text = "00";
            // 
            // current3
            // 
            this.current3.AutoSize = true;
            this.current3.BackColor = System.Drawing.Color.Transparent;
            this.current3.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current3.Location = new System.Drawing.Point(187, 437);
            this.current3.Name = "current3";
            this.current3.Size = new System.Drawing.Size(102, 80);
            this.current3.TabIndex = 68;
            this.current3.Text = "00";
            // 
            // current2
            // 
            this.current2.AutoSize = true;
            this.current2.BackColor = System.Drawing.Color.Transparent;
            this.current2.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current2.Location = new System.Drawing.Point(187, 265);
            this.current2.Name = "current2";
            this.current2.Size = new System.Drawing.Size(102, 80);
            this.current2.TabIndex = 69;
            this.current2.Text = "00";
            // 
            // max1
            // 
            this.max1.AutoSize = true;
            this.max1.BackColor = System.Drawing.Color.Transparent;
            this.max1.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max1.Location = new System.Drawing.Point(196, 149);
            this.max1.Name = "max1";
            this.max1.Size = new System.Drawing.Size(83, 30);
            this.max1.TabIndex = 70;
            this.max1.Text = "00/00";
            // 
            // max3
            // 
            this.max3.AutoSize = true;
            this.max3.BackColor = System.Drawing.Color.Transparent;
            this.max3.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max3.Location = new System.Drawing.Point(196, 510);
            this.max3.Name = "max3";
            this.max3.Size = new System.Drawing.Size(83, 30);
            this.max3.TabIndex = 71;
            this.max3.Text = "00/00";
            // 
            // max2
            // 
            this.max2.AutoSize = true;
            this.max2.BackColor = System.Drawing.Color.Transparent;
            this.max2.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max2.Location = new System.Drawing.Point(196, 335);
            this.max2.Name = "max2";
            this.max2.Size = new System.Drawing.Size(83, 30);
            this.max2.TabIndex = 72;
            this.max2.Text = "00/00";
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.BackColor = System.Drawing.Color.Transparent;
            this.date1.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Location = new System.Drawing.Point(29, 38);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(96, 23);
            this.date1.TabIndex = 73;
            this.date1.Text = "00/00/19";
            this.date1.Click += new System.EventHandler(this.label4_Click);
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.BackColor = System.Drawing.Color.Transparent;
            this.date2.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.Location = new System.Drawing.Point(29, 222);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(96, 23);
            this.date2.TabIndex = 74;
            this.date2.Text = "00/00/19";
            // 
            // date3
            // 
            this.date3.AutoSize = true;
            this.date3.BackColor = System.Drawing.Color.Transparent;
            this.date3.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date3.Location = new System.Drawing.Point(29, 396);
            this.date3.Name = "date3";
            this.date3.Size = new System.Drawing.Size(96, 23);
            this.date3.TabIndex = 75;
            this.date3.Text = "00/00/19";
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.Screenshot__13_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.date3);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.max2);
            this.Controls.Add(this.max3);
            this.Controls.Add(this.max1);
            this.Controls.Add(this.current2);
            this.Controls.Add(this.current3);
            this.Controls.Add(this.current1);
            this.Controls.Add(this.icon3);
            this.Controls.Add(this.icon1);
            this.Controls.Add(this.icon2);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(336, 578);
            this.Load += new System.EventHandler(this.ForecastScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox icon2;
        private System.Windows.Forms.PictureBox icon1;
        private System.Windows.Forms.PictureBox icon3;
        private System.Windows.Forms.Label current1;
        private System.Windows.Forms.Label current3;
        private System.Windows.Forms.Label current2;
        private System.Windows.Forms.Label max1;
        private System.Windows.Forms.Label max3;
        private System.Windows.Forms.Label max2;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label date3;
    }
}
