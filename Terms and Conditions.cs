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
    public partial class Terms_and_Conditions : Form
    {
        public Terms_and_Conditions()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void agreebutton_Click(object sender, EventArgs e)
        {
            new Registration_Page().Show();
            this.Hide();
        }

        private void disagbutton_Click(object sender, EventArgs e)
        {
            new Registration_Page().Show();
            this.Hide();
        }
    }
}
