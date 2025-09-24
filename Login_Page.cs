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
    public partial class Login_Panel : Form
    {
        public Login_Panel()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logpan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void passlbl_Click(object sender, EventArgs e)
        {

        }

        private void passTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Panel_Load(object sender, EventArgs e)
        {

        }

        private void regbutton_Click(object sender, EventArgs e)
        {
            Registration_Page rp = new Registration_Page();
            rp.Show();
            this.Hide();
        }

        private void remcb_CheckedChanged(object sender, EventArgs e)
        {
            remcb.Checked = true;
        }

        private void loginsplt_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

        }