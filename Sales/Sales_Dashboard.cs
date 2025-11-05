using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace FLOWSHOPINV.Sales
{
    public partial class Sales_Dashboard : UserControl
    {
        public Sales_Dashboard()
        {
            InitializeComponent();

            // Update count when the control loads
            this.Load += Sales_Dashboard_Load;
        }

        private void Sales_Dashboard_Load(object sender, EventArgs e)
        {
            UpdateAvailableProductCount();
        }

        /// <summary>
        /// Queries the DB for products with Status = "Available" and sets the sstotprodnumlbl text.
        /// </summary>
        public void UpdateAvailableProductCount()
        {
            string connStr = ConfigurationManager.ConnectionStrings["BloomTrackDB"]?.ConnectionString;
            if (string.IsNullOrEmpty(connStr))
            {
                SetProductCountLabel("N/A");
                return;
            }

            try
            {
                using (var conn = new SqlConnection(connStr))
                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Inventory WHERE Status = @status", conn))
                {
                    cmd.Parameters.Add("@status", SqlDbType.NVarChar, 50).Value = "Available";
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    int count = (result == null || result == DBNull.Value) ? 0 : Convert.ToInt32(result);
                    SetProductCountLabel(count.ToString());
                }
            }
            catch (Exception ex)
            {
                // Minimal feedback; you can log the exception elsewhere
                SetProductCountLabel("Err");
                MessageBox.Show("Could not load product count: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetProductCountLabel(string text)
        {
            // Prefer direct field if designer exposes it
            try
            {
                var field = this.GetType().GetField("sstotprodnumlbl", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public);
                if (field != null)
                {
                    var lbl = field.GetValue(this) as Label;
                    if (lbl != null)
                    {
                        lbl.Text = text;
                        return;
                    }
                }
            }
            catch
            {
                // ignore and fallback to control lookup
            }

            // Fallback: search controls by name
            var found = this.Controls.Find("sstotprodnumlbl", true).FirstOrDefault() as Label;
            if (found != null)
            {
                found.Text = text;
            }
            else
            {
                // If label is not found, you can optionally create it or log the issue.
            }
        }

        private void totalproductslbl_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void sspendingorderTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sales_Dashboard_Load_1(object sender, EventArgs e)
        {

        }
    }
}
