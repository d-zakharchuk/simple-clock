using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clock
{
    public partial class Clock : Form
    {
        public Clock()
        {
            InitializeComponent();
        }

        private void TimerProgram()
        {
            DateTime time = DateTime.Now;
            LabelTime.Text = time.ToString("HH:mm:ss");
            LabelDate.Text = time.ToString("dd.MM.yyyy");
        }

        private void ClockLocation()
        {
            int FontSizeClock = Convert.ToInt16(this.Size.Width * 0.172);
            int FontSizeDate = Convert.ToInt16(this.Size.Width * 0.033);
            LabelTime.Font = new Font("Arial", FontSizeClock);
            LabelDate.Font = new Font("Arial", FontSizeDate);
            int XTime = (panel1.Size.Width - LabelTime.Width) / 2;
            int YTime = (panel1.Size.Height - LabelTime.Height) / 2;
            int XDate = (panel1.Size.Width - LabelDate.Width) / 2;
            int YDate = YTime + LabelTime.Height;
            LabelTime.Location = new Point(XTime, YTime);
            LabelDate.Location = new Point(XDate, YDate);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimerProgram();
        }

        private void Time_Resize(object sender, EventArgs e)
        {
            ClockLocation();
        }
    }
}
