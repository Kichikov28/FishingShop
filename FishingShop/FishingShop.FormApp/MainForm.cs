using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FishingShop.FormApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            ShopForm shopForm= new ShopForm();
            shopForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm=new EmployeeForm();
            employeeForm.ShowDialog();
        }
    }
}
