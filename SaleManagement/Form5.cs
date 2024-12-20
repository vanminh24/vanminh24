using System;
using System.Collections;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // Đặt màu nền cho form
            this.BackColor = System.Drawing.Color.LightPink;

            // Đặt form ra giữa màn hình khi khởi chạy
            this.StartPosition = FormStartPosition.CenterScreen;

            SaleManagement.dgv_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;​

        }
        public static string connectionString
       = "Server=DESKTOP-KCCPQC1\\MISASME2023;Database=SALE_MANGEMENT_DB;Trusted_Connection=True;";

        private void dgv_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Open the database connection
                connection.Open();

                // Create a SqlDataAdapter to execute the query and fill the DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                // Fill the DataTable with query results
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                dgv_product.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Handle any errors that may occur
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

        
