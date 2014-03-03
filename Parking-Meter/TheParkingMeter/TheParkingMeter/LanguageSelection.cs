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
    public partial class LanguageSelection : Form
    {
        public LanguageSelection()
        {
            InitializeComponent();
        }

        private void buttonEnglish_Click(object sender, EventArgs e)
        {
            BuyOrRefund form2 = new BuyOrRefund();
            form2.langMenu = this;
            this.Hide();
            form2.Show();
        }

        private void buttonFrench_Click(object sender, EventArgs e)
        {
            String message = "This button converts all English text to French. This function has not been implemented, but would follow the same program flow and forms as English.";
            MessageBox.Show(message, "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }

    }
}
