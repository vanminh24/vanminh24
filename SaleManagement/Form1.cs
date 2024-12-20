using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Set the form to start in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;


            // Disable the maximize/restore button
            this.MaximizeBox = false;


            // Optional: Set a fixed border style to prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm mainForm = new MenuForm();
            mainForm.Show();


            // Ẩn Form đăng nhập hiện tại (Form) 
            this.Hide();

        }

        // public mainForm()
        
            // InitializeComponent();
            // Maximize the form and keep it above the Taskbar
            // this.WindowState = FormWindowState.Maximized;
            // this.FormBorderStyle = FormBorderStyle.Sizable;
            // this.StartPosition = FormStartPosition.CenterScreen;
        }
    }

