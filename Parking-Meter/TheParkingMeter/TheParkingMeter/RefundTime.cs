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
    public partial class RefundTime : Form
    {  
        TimeSpan timeLeft = new TimeSpan();
        TimeSpan defaultExpiry = new TimeSpan(0, 30, 0);
        DateTime expiry;

        public BuyOrRefund back;
  
        public RefundTime()
        {
            InitializeComponent();
        }

        private void BuyTime_Load(object sender, EventArgs e)
        {
            if (GlobalData.purchaseTime.GetHashCode() != 0) expiry = GlobalData.purchaseTime.Add(GlobalData.purchaseMinutes);
            else expiry = DateTime.Now.Add(defaultExpiry);

            CurrentDate.Text = DateTime.Now.ToString("MMM dd, yyyy");
            CurrentTime.Text = DateTime.Now.ToString("hh:mm tt");

            timeLeft = RoundUp(expiry, TimeSpan.FromMinutes(1)).Subtract(RoundUp(DateTime.Now, TimeSpan.FromMinutes(1)));

            if (timeLeft.Hours > 0) MinuteLabel.Text = timeLeft.Hours.ToString() + "hr" + timeLeft.Minutes.ToString() + "min";
            else MinuteLabel.Text = timeLeft.Minutes + "min";

            TicketExpireDate.Text = expiry.ToString("MMM dd, yyyy");
            TicketExpireTime.Text = expiry.ToString("hh:mm tt");

            return;
        }

        private void UpdateClock_Tick(object sender, EventArgs e)
        {
            CurrentDate.Text = DateTime.Now.ToString("MMM dd, yyyy");
            CurrentTime.Text = DateTime.Now.ToString("hh:mm tt");

            UpdateLabels();
            return;
        }


        private void UpdateLabels()
        {
            timeLeft = RoundUp(expiry, TimeSpan.FromMinutes(1)).Subtract(RoundUp(DateTime.Now, TimeSpan.FromMinutes(1)));

            if (timeLeft.Hours > 0) MinuteLabel.Text = timeLeft.Hours.ToString() + "hr" + timeLeft.Minutes + "min";
            else MinuteLabel.Text = timeLeft.Minutes +"min";

            return;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            GlobalData.minutesLeft = timeLeft.Minutes;
            GlobalData.refundTime = DateTime.Now;
            Refunding getRefund = new Refunding();
            getRefund.backRefund = this;
            getRefund.Show();
            this.Hide();

            return;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            CloseRefundTime();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            back.Show();
            this.Close();
        }

        private DateTime RoundUp(DateTime dt, TimeSpan d)
        {
            return new DateTime(((dt.Ticks + d.Ticks - 1) / d.Ticks) * d.Ticks);
        }

        public void CloseRefundTime()
        {
            back.Show();
            back.CloseChoice();
            this.Close();
        }
    }
}
