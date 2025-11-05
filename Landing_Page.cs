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
    public partial class Landing_Page : UserControl
    {
        public Landing_Page()
        {
            InitializeComponent();
        }

        private void expprodbtn_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
            
            var parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Hide();
            }


        }
    }
}
