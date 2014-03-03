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
    public partial class CreditDebit : Form
    {

        public string type;
        public PaymentOptions method { get; set; }

        public CreditDebit()
        {
            InitializeComponent();
        }

        private void CreditDebit_Load(object sender, EventArgs e)
        {
            if (type == "Debit") DebitPic.Visible = true;
            else CreditPic.Visible = true;
        }

        private void CreditDebit_Shown(object sender, EventArgs e)
        {
            String message = "A green light appears near the card reader. This screen will persist until the user completes their transaction. Clicking the OK button simulates this action. Clicking Cancel simulates the Cancel button on the card reader.";
            DialogResult result = MessageBox.Show(message, "Important", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                PrintTicket ticket = new PrintTicket();
                ticket.Show();
                ticket.cardmethod = this;
                this.Hide();
            }
            else
            {
                this.Close();
                this.method.Show();

                String act = "Keypad actions cancelled. The green light shuts off.";
                MessageBox.Show(act, "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        public void CloseCreditDebit()
        {
            this.method.Show();
            this.method.ClosePayment();
            this.Close();
        }


    }
}
