namespace XMLWeather
{
    partial class CurrentScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.forcastLabel = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.temp = new System.Windows.Forms.Label();
            this.highLow = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Today";
            // 
            // forcastLabel
            // 
            this.forcastLabel.AutoSize = true;
            this.forcastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forcastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forcastLabel.Location = new System.Drawing.Point(266, 10);
            this.forcastLabel.Name = "forcastLabel";
            this.forcastLabel.Size = new System.Drawing.Size(57, 24);
            this.forcastLabel.TabIndex = 1;
            this.forcastLabel.Text = "3 Day";
            this.forcastLabel.Click += new System.EventHandler(this.forcastLabel_Click);
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.BackColor = System.Drawing.Color.Transparent;
            this.city.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(130, 104);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(64, 34);
            this.city.TabIndex = 2;
            this.city.Text = "CITY";
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.Transparent;
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon.Location = new System.Drawing.Point(103, 141);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(130, 120);
            this.icon.TabIndex = 3;
            this.icon.TabStop = false;
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.BackColor = System.Drawing.Color.Transparent;
            this.temp.Font = new System.Drawing.Font("Impact", 57.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp.Location = new System.Drawing.Point(111, 264);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(122, 93);
            this.temp.TabIndex = 4;
            this.temp.Text = "00";
            // 
            // highLow
            // 
            this.highLow.AutoSize = true;
            this.highLow.BackColor = System.Drawing.Color.Transparent;
            this.highLow.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highLow.Location = new System.Drawing.Point(121, 344);
            this.highLow.Name = "highLow";
            this.highLow.Size = new System.Drawing.Size(90, 34);
            this.highLow.TabIndex = 5;
            this.highLow.Text = "00/00";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(97, 468);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(133, 34);
            this.date.TabIndex = 10;
            this.date.Text = "00/00/00";
            // 
            // CurrentScreen
            // 
            this.BackgroundImage = global::XMLWeather.Properties.Resources.Screenshot__12_;
            this.Controls.Add(this.date);
            this.Controls.Add(this.highLow);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.city);
            this.Controls.Add(this.forcastLabel);
            this.Controls.Add(this.label1);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(336, 578);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label forcastLabel;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.Label highLow;
        private System.Windows.Forms.Label date;
    }
}
