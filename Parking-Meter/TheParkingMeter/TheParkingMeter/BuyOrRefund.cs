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
    public partial class BuyOrRefund : Form
    {
        public LanguageSelection langMenu;

        public BuyOrRefund()
        {
            InitializeComponent();
        }

        private void BuyOrRefund_Load(object sender, EventArgs e)
        {
            Visible = false;
        }



        private void buttonRefund_Click(object sender, EventArgs e)
        {
            InsertTicket InsertTicket = new InsertTicket();
            InsertTicket.choice = this;
            this.Hide();
            InsertTicket.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CloseChoice();
        }

        public void CloseChoice()
        {
            langMenu.Show();
            this.Close(); // close this form
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            BuyTime buyMinutes = new BuyTime();
            buyMinutes.backChoice = this;
            buyMinutes.Show();
            this.Hide();
        }
    }
}
