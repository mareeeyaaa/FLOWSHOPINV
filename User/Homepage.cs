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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            openChildForm(new Home());
        }

        private void wbtlbl_Click(object sender, EventArgs e)
        {

        }

        private void featuredpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homePB_Click_1(object sender, EventArgs e) // PRODUCTS BUTTON
        {
            openChildForm(new Home());
        }

        private void prodPB_Click(object sender, EventArgs e) // PRODUCTS BUTTON
        {
            openChildForm(new Products());
        }

        private void atcPB_Click(object sender, EventArgs e) // CART BUTTON
        {
            openChildForm(new Cart());
        }

        private void profPB_Click(object sender, EventArgs e) // PROFILE BUTTON
        {
            openChildForm(new Profile());
        }

        // ========================================== FUNCTIONS ==========================================
        public void openChildForm(Form childForm) // For Opening a child form inside a panel (embedded)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form form = childForm as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None; // For removing the title bar and the border
            this.mainPanel.Controls.Add(form);
            this.mainPanel.Tag = form;
            form.Show();
        }

        // ===============================================================================================
    }
}
