using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class PopupMessage : Form
    {
        public PopupMessage(string txtMessage)
        {
            InitializeComponent();
            displayMessage(txtMessage);
        }

        private void displayMessage(string txt)
        {
            lbl_popup.Text = txt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
