using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
            icon.BackgroundImage = Properties.Resources.sun;

        }



        public void DisplayCurrent()
        {
            city.Text = Form1.days[0].location;
            city.Location = new Point((this.Width - city.Width) / 2, 104);

            temp.Text = Convert.ToDouble(Form1.days[0].currentTemp).ToString("0.") + "°C";
            temp.Location = new Point((this.Width - temp.Width) / 2, 264);

            highLow.Text = Convert.ToDouble(Form1.days[0].tempLow).ToString("0.") + "°C/"
                + Convert.ToDouble(Form1.days[0].tempHigh).ToString("0.") + "°C";            
            highLow.Location = new Point((this.Width - highLow.Width) / 2, 344);

            date.Text = Form1.days[0].date;
            date.Location = new Point((this.Width - date.Width) / 2, 468);

            int c = Convert.ToInt32(Form1.days[0].condition);           

            if (c >= 200 && c <= 232)
            {
                icon.BackgroundImage = Properties.Resources.thunder;
            }
            else if (c >= 300 && c <= 531)
            {
                icon.BackgroundImage = Properties.Resources.rain;
            }
            else if (c >= 600 && c <= 622)
            {
                icon.BackgroundImage = Properties.Resources.snow;
            }
            else if (c >= 701 && c <= 781)
            {
                icon.BackgroundImage = Properties.Resources.wind;
            }
            else if (c >= 801 && c <= 802)
            {
                icon.BackgroundImage = Properties.Resources.partCloud;
            }
            else if (c >= 803 && c <= 804)
            {
                icon.BackgroundImage = Properties.Resources.clouds;
            }
            else if (c == 800)
            {
                icon.BackgroundImage = Properties.Resources.sun;
            }                       
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void forcastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
