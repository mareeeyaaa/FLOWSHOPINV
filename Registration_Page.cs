using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLOWSHOPINV
{
    public partial class Registration_Page : Form
    {
        public Registration_Page()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void taclnklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            taclnklbl.LinkVisited = true;
            Terms_and_Conditions tac = new Terms_and_Conditions();
            tac.Show();
            
        }

        private void signinlnklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signinlnklbl.LinkVisited = true;
            Login_Panel lp = new Login_Panel();
            lp.Show();
            this.Hide();
        }

        private void tacCB_CheckedChanged(object sender, EventArgs e)
        {
            tacCB.Checked = true;
        }

        private void fnameTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
