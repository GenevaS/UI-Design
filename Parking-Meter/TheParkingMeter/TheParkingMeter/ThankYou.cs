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
    public partial class ThankYou : Form
    {
        public PrintTicket parentPrint;
        public Refunding parentRefunding;

        public ThankYou()
        {
            InitializeComponent();
        }

        private void ThankYou_Load(object sender, EventArgs e)
        {
            if (parentPrint != null) TypeLabel.Text = "Enjoy Your Visit";
            else TypeLabel.Text = "Please Come Again";
        }

        private void ThankYou_Shown(object sender, EventArgs e)
        {
            String message = "This screen will persist for 15 seconds. Clicking the OK button simulates this action.";
            MessageBox.Show(message, "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (parentPrint != null) parentPrint.ClosePrint();
            else parentRefunding.CloseRefunding();
            this.Close();
        }
    }
}
