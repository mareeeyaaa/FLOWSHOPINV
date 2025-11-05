using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FLOWSHOPINV.Inventory
{
    public partial class Inventory_Dashboard : UserControl
    {
        public Inventory_Dashboard()
        {
            InitializeComponent();
            this.Load += Inventory_Dashboard_Load;
        }

        private void Inventory_Dashboard_Load(object sender, EventArgs e)
        {
            UpdateLowStockCount();
        }

        /// <summary>
        /// Counts inventory items with Quantity &lt;= threshold (5) and updates the label.
        /// </summary>
        public void UpdateLowStockCount(int threshold = 5)
        {
            string connStr = ConfigurationManager.ConnectionStrings["BloomTrackDB"]?.ConnectionString;
            if (string.IsNullOrEmpty(connStr))
            {
                SetLowStockCnt("N/A");
                return;
            }

            try
            {
                using (var conn = new SqlConnection(connStr))
                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Inventory WHERE Quantity <= @Threshold", conn))
                {
                    cmd.Parameters.Add("@Threshold", SqlDbType.Int).Value = threshold;
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    int count = (result == null || result == DBNull.Value) ? 0 : Convert.ToInt32(result);
                    SetLowStockCnt(count.ToString());
                }
            }
            catch (Exception ex)
            {
                SetLowStockCnt("Err");
                MessageBox.Show("Could not load low-stock count: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetLowStockCnt(string text)
        {
            // Try direct field first (designer-generated field), then fallback to control search.
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
                // ignore and fallback
            }

            var found = this.Controls.Find("sstotprodnumlbl", true).FirstOrDefault() as Label;
            if (found != null)
            {
                found.Text = text;
            }
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void isovchart_Click(object sender, EventArgs e)
        {
        }
    }
}
