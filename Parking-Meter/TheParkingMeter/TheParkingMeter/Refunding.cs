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
    public partial class Refunding : Form
    {
        public ThankYou end = new ThankYou();
        public RefundTime backRefund;
        DateTime expiry;
        TimeSpan defaultExpiry = new TimeSpan(0, 30, 0);

        public Refunding()
        {
            InitializeComponent();
        }

        private void Refunding_Load(object sender, EventArgs e)
        {
            ChangeLabel.Text = "Refund Amount: $" + Convert.ToDecimal(string.Format("{0:0.00}", (GlobalData.minutesLeft * GlobalData.rate)));
            for (int i = 0; i < 100; i++) Progress.Value = i + 1;
        }

        public void CloseRefunding()
        {
            backRefund.Show();
            backRefund.CloseRefundTime();
            this.Close();
        }

        private void Refunding_Shown(object sender, EventArgs e)
        {
            if (GlobalData.purchaseTime.GetHashCode() != 0) expiry = GlobalData.purchaseTime.Add(GlobalData.purchaseMinutes);
            else expiry = DateTime.Now.Add(defaultExpiry);

            String purchaseDate = "Refund Date: " + GlobalData.refundTime.ToString("MMM dd, yyyy");
            String purchaseTime = "Refund Time: " + GlobalData.refundTime.ToString("hh:mm tt");
            String expireDate = "Expiry Date: " + expiry.ToString("MMM dd, yyyy");
            String expireTime = "Expiry Time: " + expiry.ToString("hh:mm tt");
            String changeDue = "Refund Amount: $" + Convert.ToDecimal(string.Format("{0:0.00}", (GlobalData.minutesLeft * GlobalData.rate)));
            String purchaseMethod = "Refund Method: Coins";

            String message = "This is a simulated ticket. This information is printed on the reverse of the ticket inserted into the machine.\n\n"
                + purchaseDate + "\n" + purchaseTime + "\n" + expireDate + "\n" + expireTime + "\n\n" + purchaseMethod + "\n" + changeDue;
            MessageBox.Show(message, "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            
            end.parentRefunding = this;
            end.Show();
        }
    }
}
