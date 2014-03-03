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
    public partial class Coins : Form
    {
        public PaymentOptions payment { get; set; }
        private double amountDue = PaymentOptions.amtDue;

        public Coins()
        {
            InitializeComponent();
        }

        private void Coins_Load(object sender, EventArgs e)
        {
            PayLabel.Text = "$" + Convert.ToDecimal(string.Format("{0:0.00}", amountDue));
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.payment.Show();

            String message = "Your change is returned to you. The green light shuts off.";
            MessageBox.Show(message, "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            return;
        }

        private void NickelButton_Click(object sender, EventArgs e)
        {
            amountDue = amountDue - 0.05;
            PayLabel.Text = "$" + Convert.ToDecimal(string.Format("{0:0.00}", amountDue));
            CheckPayment();

            return;
        }

        private void CheckPayment()
        {
            if (amountDue <= 0)
            {
                GlobalData.change = -1 * amountDue;
                PrintTicket ticket = new PrintTicket();
                ticket.coinmethod = this;
                ticket.Show();
                this.Hide();

                return;
            }
        }

        private void DimeButton_Click(object sender, EventArgs e)
        {
            amountDue = amountDue - 0.10;
            PayLabel.Text = "$" + Convert.ToDecimal(string.Format("{0:0.00}", amountDue));
            CheckPayment();

            return;
        }

        private void QuarterButton_Click(object sender, EventArgs e)
        {
            amountDue = amountDue - 0.25;
            PayLabel.Text = "$" + Convert.ToDecimal(string.Format("{0:0.00}", amountDue));
            CheckPayment();

            return;
        }

        private void DollarButton_Click(object sender, EventArgs e)
        {
            amountDue = amountDue - 1.00;
            PayLabel.Text = "$" + Convert.ToDecimal(string.Format("{0:0.00}", amountDue));
            CheckPayment();

            return;
        }

        private void ToonieButton_Click(object sender, EventArgs e)
        {
            amountDue = amountDue - 2.00;
            PayLabel.Text = "$" + Convert.ToDecimal(string.Format("{0:0.00}", amountDue));
            CheckPayment();

            return;
        }

        private void Coins_Shown(object sender, EventArgs e)
        {
            String message = "A green light appears near the coin slot. Coin buttons would be labels in a parking meter - buttons are for the purpose of testing program only.";
            MessageBox.Show(message, "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }

        public void CloseCoins()
        {
            this.payment.Show();
            this.payment.ClosePayment();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            String message = "Your change is returned to you. The green light shuts off.";
            MessageBox.Show(message, "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            CloseCoins();
        }
    }
}
