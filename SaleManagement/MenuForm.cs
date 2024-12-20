﻿using System;
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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();

            // Set the form to start in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;


            // Disable the maximize/restore button
            this.MaximizeBox = false;

            // Optional: Set a fixed border style to prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // MainForm main = new MainForm();
           // main.Show();
            this.Hide();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //PurchaseHistory purchaseHistory = new PurchaseHistory();
            //purchaseHistory.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show(); 
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
         //   AddEmployee  employeeForm = new EmployeeForm();
         //   employeeForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // SettingForm settingForm = new SettingForm();
            // settingForm.Show();

        }

    }

}