using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class InsertTicket : Form
    {
        public BuyOrRefund choice;
        public InsertTicket()
        {
            InitializeComponent();
        }

        private void InsertTicket_Shown(object sender, EventArgs e)
        {
            RefundTime RefundTime = new RefundTime();
            DialogResult result1 = MessageBox.Show("A green light turns on near the ticket slot. This message signifies the stage where a user is inserting their ticket into the machine. OK simulates having inserted the card. Cancel simulates having taken no action.",
                "Simulation Message",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result1 == DialogResult.OK)
            {
                RefundTime.back = choice;
                this.Close();
                RefundTime.Show();
            }
                

        }

        public void CancelButton_Click(object sender, EventArgs e)
        {
            choice.Show();
            choice.CloseChoice();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            choice.Show();
            this.Close();
        }

    }
}
