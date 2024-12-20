using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement
{
    public partial class dgv_product : Form
    {
        public dgv_product()
        {
            InitializeComponent();

          
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.StartPosition = FormStartPosition.CenterScreen;
            }

        public static string connectionString
       = "Server=MSI\\MISASME2023;Database=SALE_MANGEMENT_DB;Trusted_Connection=True;";
        private void LoadData()
        {
            // SQL query to fetch data
            string query = "SELECT * FROM Product";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the database connection
                    connection.Open();

                    // Use SqlDataAdapter within a using block to ensure proper disposal
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with query results
                        adapter.Fill(dataTable);

                        // Ensure DataGridView exists and bind the DataTable
                        if (dgv_product != null)
                        {
                            dgv_product.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("DataGridView is not initialized.");
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    // Handle database-specific errors
                    MessageBox.Show("Database error: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    // Handle other errors
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

       

