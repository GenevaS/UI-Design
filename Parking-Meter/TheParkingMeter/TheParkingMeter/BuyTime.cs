using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class BuyTime : Form
    {
        private static int minutes;
        public BuyOrRefund backChoice;
  
        TimeSpan ticketTime = new TimeSpan(0, 30, 0);
  
        public BuyTime()
        {
            InitializeComponent();
        }

        private void BuyTime_Load(object sender, EventArgs e)
        {
            minutes = 6;
            CurrentDate.Text = DateTime.Now.ToString("MMM dd, yyyy");
            CurrentTime.Text = DateTime.Now.ToString("hh:mm tt");

            MinuteLabel.Text = (5*minutes) + "min";

            TicketExpireDate.Text = DateTime.Now.Add(ticketTime).ToString("MMM dd, yyyy");
            TicketExpireTime.Text = DateTime.Now.Add(ticketTime).ToString("hh:mm tt");

            return;
        }

        private void UpdateClock_Tick(object sender, EventArgs e)
        {
            CurrentDate.Text = DateTime.Now.ToString("MMM dd, yyyy");
            CurrentTime.Text = DateTime.Now.ToString("hh:mm tt");

            UpdateExpiry();
            return;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            minutes = MinutesSlider.Value;
            UpdateLabels();

            UpdateExpiry();

            return;
        }

        private void LessButton_Click(object sender, EventArgs e)
        {
            if (minutes - 1 > 2)
            {
                minutes = minutes - 1;
                UpdateLabels();
                MinutesSlider.Value = minutes;
                UpdateExpiry();
            }

            return;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (minutes + 1 <= 36)
            {
                minutes = minutes + 1;
                UpdateLabels();
                MinutesSlider.Value = minutes;
                UpdateExpiry();
            }

            return;
        }

        private void UpdateLabels()
        {
            int hours;
            int tempMinutes;

            if ((minutes*5) > 59)
            {
                hours = (minutes*5) / 60;
                tempMinutes = (minutes*5) - (hours * 60);
                if (tempMinutes != 0) MinuteLabel.Text = hours + "hr " + tempMinutes + "min";
                else MinuteLabel.Text = hours + "hr";
            }
            else
            {
                MinuteLabel.Text = (minutes*5) + "min";
            }

            return;
        }

        private void UpdateExpiry()
        {
            int tempMin = 5 * minutes;
            TimeSpan update = new TimeSpan(0, tempMin, 0);
            ticketTime = update;

            TicketExpireDate.Text = DateTime.Now.Add(ticketTime).ToString("MMM dd, yyyy");
            TicketExpireTime.Text = DateTime.Now.Add(ticketTime).ToString("hh:mm tt");

            return;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentOptions proceed = new PaymentOptions();

            GlobalData.purchaseTime = DateTime.Now;
            GlobalData.purchaseMinutes = ticketTime;

            proceed.buyTime = this;
            proceed.Show();

            return;
        }

        public static int time
        {
            get
            {
                return (5*minutes);
            }
        }

        public void CloseBuy()
        {
            backChoice.Show();
            backChoice.CloseChoice();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            CloseBuy();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            backChoice.Show();
            this.Close();
        }
    }
}
