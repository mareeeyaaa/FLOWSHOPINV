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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++) // TO POPULATE THE FLOWLAYOUTPANEL WITH ITEMS (TEMPORARY)
            {
                var Item = new ItemUserControl();
                Item.Margin = new Padding(65); // Spacing between items
                flowLayoutPanel1.Controls.Add(Item);
            }
        }
    }
}
