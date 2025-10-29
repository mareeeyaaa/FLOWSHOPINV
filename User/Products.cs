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
                var Item = new Items();
                Item.Margin = new Padding(65); // Spacing between items
                ProdFLP.Controls.Add(Item);
            }
        }

        private void sitemsTB_TextChanged(object sender, EventArgs e)
        { 

        }
            private void sitemsTB_Load(object sender, EventArgs e)
        {
            sitemsTB.Text = "Search Items";
            sitemsTB.ForeColor = Color.Gray;

            // Assign the events
            sitemsTB.MouseEnter += sitemsTB_MouseEnter;
            sitemsTB.MouseLeave += sitemsTB_MouseLeave;
        }

        private void sitemsTB_MouseEnter(object sender, EventArgs e)
        {
            if (sitemsTB.Text == "Search Items")
            {
                sitemsTB.Text = "";
                sitemsTB.ForeColor = Color.Black;
            }
        }

        private void sitemsTB_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sitemsTB.Text))
            {
                sitemsTB.Text = "Search Items";
                sitemsTB.ForeColor = Color.Gray;
            }
        }

        private void filterCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filterTB_TextChanged(object sender, EventArgs e)
        {

        }
        private void filterTB_Load(object sender, EventArgs e)
        {
            sitemsTB.Text = "All Categories";
            sitemsTB.ForeColor = Color.Gray;

            // Assign the events
            sitemsTB.MouseEnter += filterTB_MouseEnter;
            sitemsTB.MouseLeave += filterTB_MouseLeave;
        }

        private void filterTB_MouseEnter(object sender, EventArgs e)
        {
            if (sitemsTB.Text == "All Categories")
            {
                sitemsTB.Text = "";
                sitemsTB.ForeColor = Color.Black;
            }
        }

        private void filterTB_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sitemsTB.Text))
            {
                sitemsTB.Text = "All Categories";
                sitemsTB.ForeColor = Color.Gray;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void itemsLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
