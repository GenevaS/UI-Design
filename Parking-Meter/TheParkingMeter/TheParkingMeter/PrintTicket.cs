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
    public partial class PrintTicket : Form
    {

        public ThankYou end = new ThankYou();
        public Coins coinmethod { get; set; }
        public CreditDebit cardmethod { get; set; }
        public DateTime purchaseTime;
        public DateTime purchaseDate;
        public DateTime expireTime;
        public DateTime expireDate;

        public PrintTicket()
        {
            InitializeComponent();
        }

        private void PrintTicket_Load(object sender, EventArgs e)
        {
            ChangeLabel.Text = "Change Due: $" + Convert.ToDecimal(string.Format("{0:0.00}", GlobalData.change));
           
            for (int i = 0; i < 100; i++) Progress.Value = i + 1;
        }

        private void PrintTicket_Shown(object sender, EventArgs e)
        {
            String purchaseDate = "Purchase Date: " + GlobalData.purchaseTime.ToString("MMM dd, yyyy");
            String purchaseTime = "Purchase Time: " + GlobalData.purchaseTime.ToString("hh:mm tt");
            String expireDate = "Expiry Date: " + GlobalData.purchaseTime.Add(GlobalData.purchaseMinutes).ToString("MMM dd, yyyy");
            String expireTime = "Expiry Time: " + GlobalData.purchaseTime.Add(GlobalData.purchaseMinutes).ToString("hh:mm tt");
            String changeDue = "Change Due: $" + Convert.ToDecimal(string.Format("{0:0.00}", GlobalData.change));
            String purchaseMethod = "Payment Method: " + GlobalData.paymentMethod;

            String message = "This is a simulated ticket. Ticket information has been recorded and will automatically be used with the Refund Ticket option. \n\n"
                + purchaseDate + "\n" + purchaseTime + "\n" + expireDate + "\n" + expireTime + "\n\n" + purchaseMethod + "\n" + changeDue;
            MessageBox.Show(message, "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            end.parentPrint = this;
            end.Show();
        }

        public void ClosePrint()
        {
            if (coinmethod != null)
            {
                coinmethod.Show(); // Show parent
                coinmethod.CloseCoins();
            }
            else
            {
                cardmethod.Show();
                cardmethod.CloseCreditDebit();
            }

            this.Close();
        }
    }
}
