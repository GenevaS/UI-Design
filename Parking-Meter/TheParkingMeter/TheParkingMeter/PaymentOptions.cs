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
    public partial class PaymentOptions : Form
    {
        public int time = BuyTime.time;
        public static double amtDue = 0;
        public static DateTime current;
        public static TimeSpan ticketTime;

        public BuyTime buyTime { get; set; }

        public PaymentOptions()
        {
            InitializeComponent();
        }

        private void PaymentOptions_Load(object sender, EventArgs e)
        {
            double amountDue = GlobalData.rate * time;
            amtDue = amountDue;
            PayLabel.Text = "$" + Convert.ToDecimal(string.Format("{0:0.00}", amountDue));
        }

        private void CoinButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Coins payCoins = new Coins();

            payCoins.payment = this;
            GlobalData.paymentMethod = "Cash";

            payCoins.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.buyTime.Show();

            return;
        }

        private void DebitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreditDebit next = new CreditDebit();
            next.method = this;

            next.type = "Debit";
            GlobalData.paymentMethod = "Debit";
            next.Show();
        }

        private void CreditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreditDebit next = new CreditDebit();
            next.method = this;

            next.type = "Credit";
            GlobalData.paymentMethod = "Credit";
            next.Show();
        }

        private void PaymentOptions_Shown(object sender, EventArgs e)
        {
            double amountDue = GlobalData.rate * time;
            amtDue = amountDue;
        }

        public void ClosePayment()
        {
            buyTime.Show();
            buyTime.CloseBuy();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClosePayment();
        }
    }
}
