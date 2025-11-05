using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FLOWSHOPINV.Sales;
using FLOWSHOPINV.Admin;
using FLOWSHOPINV.Inventory;

namespace FLOWSHOPINV
{
    public partial class Login_Panel : Form
    {
        // Central connection string
        private readonly string connectionString = new System.Data.SqlClient.SqlConnectionStringBuilder
        {
            DataSource = @"desktop-9m4otec\ve_server",
            InitialCatalog = "BloomTrackDB",
            UserID = "BloomTrack",
            Password = "Admin123",
            Encrypt = false
        }.ConnectionString;
                
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


        private void remcb_CheckedChanged(object sender, EventArgs e)
        {
            // Do not forcibly re-check the checkbox here.
            // Implement remember-me logic elsewhere if needed.
        }

        private void loginsplt_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            // 1. Get text from your textboxes
            string email = emailTB.Text?.Trim();
            string password = passTB.Text ?? string.Empty;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            // 2. Create the connection and query
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open(); // Open the database connection

                    // SELECT only the columns we need improves performance and clarity
                    string query = "SELECT Role FROM Staff WHERE Email = @Email AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Explicit parameter types (avoid AddWithValue)
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 256).Value = email;
                        cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 256).Value = password;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // --- LOGIN SUCCESSFUL ---
                                object roleObj = reader["Role"];
                                string userRole = (roleObj == DBNull.Value || roleObj == null)
                                    ? string.Empty
                                    : roleObj.ToString().Trim();

                                // Hide the login form *before* showing the new one
                                this.Hide();

                                // Route to the appropriate form
                                switch (userRole)
                                {
                                    case "Admin":
                                        Admin_Panel adminForm = new Admin_Panel();
                                        adminForm.Show();
                                        break;

                                    case "Sales Staff":
                                        Sales_Panel salesForm = new Sales_Panel();
                                        salesForm.Show();
                                        break;

                                    case "Inventory Staff":
                                        Inventory_Panel inventoryForm = new Inventory_Panel();
                                        inventoryForm.Show();
                                        break;

                                    default:
                                        MessageBox.Show("Login successful, but your user role is not recognized.");
                                        this.Show(); // Re-show the login form
                                        break;
                                }
                            }
                            else
                            {
                                // --- LOGIN FAILED ---
                                MessageBox.Show("Invalid email or password.");
                            }
                        }
                    }
                } // connection disposed here
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}