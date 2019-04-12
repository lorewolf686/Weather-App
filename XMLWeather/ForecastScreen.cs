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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            date1.Text = Form1.days[1].date;
            date2.Text = Form1.days[2].date;
            date3.Text = Form1.days[3].date;

            current1.Text = Convert.ToDouble(Form1.days[1].currentTemp).ToString("0.");
            current2.Text = Convert.ToDouble(Form1.days[2].currentTemp).ToString("0.");
            current3.Text = Convert.ToDouble(Form1.days[3].currentTemp).ToString("0.");

            max1.Text = Convert.ToDouble(Form1.days[1].tempLow).ToString("0.") + "°C/"
                + Convert.ToDouble(Form1.days[1].tempHigh).ToString("0.") + "°C";
            max2.Text = Convert.ToDouble(Form1.days[2].tempLow).ToString("0.") + "°C/"
                + Convert.ToDouble(Form1.days[2].tempHigh).ToString("0.") + "°C";
            max3.Text = Convert.ToDouble(Form1.days[3].tempLow).ToString("0.") + "°C/"
                + Convert.ToDouble(Form1.days[3].tempHigh).ToString("0.") + "°C";

            conditionPic(Form1.days[1], icon1);
            conditionPic(Form1.days[2], icon2);
            conditionPic(Form1.days[3], icon3);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void ForecastScreen_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void conditionPic(Day d, PictureBox p)
        {
            int c = Convert.ToInt32(d.condition);

            if (c >= 200 && c <= 232)
            {
                p.BackgroundImage = Properties.Resources.thunder;
            }
            else if (c >= 300 && c <= 531)
            {
                p.BackgroundImage = Properties.Resources.rain;
            }
            else if (c >= 600 && c <= 622)
            {
                p.BackgroundImage = Properties.Resources.snow; 
            }
            else if (c >= 701 && c <= 781)
            {
                p.BackgroundImage = Properties.Resources.wind;
            }
            else if (c >= 801 && c <= 802)
            {
                p.BackgroundImage = Properties.Resources.partCloud;
            }
            else if (c >= 803 && c <= 804)
            {
                p.BackgroundImage = Properties.Resources.clouds;
            }
            else if (c == 800)
            {
                p.BackgroundImage = Properties.Resources.sun;
            }
            
        }
    }
}
