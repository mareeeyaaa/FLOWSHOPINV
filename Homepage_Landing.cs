using System;
using System.Drawing;
using System.Windows.Forms;

namespace FLOWSHOPINV
{
    public partial class Homepage_Landing : Form
    {
        private readonly Landing_Page _LandingPage = new Landing_Page();
        private readonly AboutUs_Page _AboutUsPage = new AboutUs_Page();

        public Homepage_Landing()
        {
            InitializeComponent();

            // Make layout robust so MainPanel always fills the form beneath the menu
            lpmenupanel.Dock = DockStyle.Top;
            MainPanel.Dock = DockStyle.Fill;

            // Wire the About button and (optional) provide a quick debug confirmation
            abbtbtn.Click += (s, e) =>
            {
                // Temporary visual confirmation while debugging:
                // MessageBox.Show("About button clicked");
                ShowControluser(_AboutUsPage);
            };

            ordrbtn.Click += (s, e) =>
            {
                // Temporary visual confirmation while debugging:
                // MessageBox.Show("Order button clicked");
                ShowControluser(_LandingPage);
            };



            // show default
            ShowControluser(_LandingPage);
        }

        private void ShowControluser(UserControl uc)
        {
            if (uc == null) return;

            MainPanel.SuspendLayout();

            // remove previous child
            MainPanel.Controls.Clear();

            // Use Dock.Fill for a plain Panel host (simpler and reliable)
            uc.Margin = Padding.Empty;
            uc.Visible = true;
            uc.Dock = DockStyle.Fill;

            // Optional: give the control a temporary BackColor to confirm it was added
            // uc.BackColor = Color.LightBlue;

            MainPanel.Controls.Add(uc);
            uc.BringToFront();

            MainPanel.ResumeLayout();

            // Ensure the MainPanel is on top of other siblings (menu remains docked top)
            MainPanel.BringToFront();
        }

        private void admandstaffportalbtn_Click(object sender, EventArgs e)
        {
            Login_Panel login_Panel = new Login_Panel();
            login_Panel.Show();
            this.Hide();
        }
    }
}
