using FishingShop.Models;
using FishingShop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FishingShop.FormApp
{
    public partial class EmployeeForm : Form
    {
        private EmployeeService service;
        private int currentPage = 1;
        private int employeesPerPage = 10;
        private int totalPages = 0;
        private int currentEmployeeId = 0;
        public EmployeeForm()
        {
            InitializeComponent();
            service = new EmployeeService();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            for (decimal i = 1000; i < 10000; i += 100)
            {
                comboBoxSalary.Items.Add($"{i:f2}");
            }
            for (int i = 18; i < 60; i += 1)
            {
                comboBoxAge.Items.Add($"{i:f0}");
            }
            comboBoxAge.SelectedIndex = 0;
            comboBoxSalary.SelectedIndex = 0;
            comboBoxEmployeesPerPage.SelectedIndex = 0;
            labelPages.Text = $"{currentPage} / {totalPages}";
            radioBtnAdd.Checked = true;
            checkBoxFire.Visible = false;
        }
        private void ClearAddGroupBox()
        {
            textBoxName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            comboBoxAge.SelectedIndex = 0;
            comboBoxSalary.SelectedIndex = 0;
            comboBoxPosition.SelectedIndex = 0;
            textBoxPhone.Text = string.Empty;
        }

        private void AddInputOnOff(bool isActive)
        {
            textBoxName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            comboBoxAge.SelectedIndex = 0;
            comboBoxPosition.SelectedIndex = 0;
            textBoxPhone.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAddGroupBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (btnAdd.Text == "Add")
            {
                string name = textBoxName.Text;
                string lastName = textBoxLastName.Text;
                int age = int.Parse(comboBoxAge.SelectedItem.ToString());
                decimal salary = decimal.Parse(comboBoxSalary.SelectedItem.ToString());
                string position = comboBoxPosition.Text;
                string phone = textBoxPhone.Text;
                string result = service.HireEmployee(name, lastName, age, position, salary, phone);
                MessageBox.Show(result);
                ClearAddGroupBox();
            }
            else if (btnAdd.Text == "Update")
            {
                if (checkBoxFire.Checked)
                {
                    MessageBox.Show(service.DeleteEmployeeById(currentEmployeeId));
                }
                else
                {
                    decimal salary = decimal.Parse(comboBoxSalary.Text);
                    MessageBox.Show(service.UpdateEmployeeSalary(currentEmployeeId, salary));
                }
                ClearAddGroupBox();
            }
        }

        private void radioBtnAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnAdd.Checked)
            {
                btnAdd.Text = "Add";
                listBoxEmployees.Enabled = false;
                textBoxName.Enabled = !false;
                textBoxLastName.Enabled = !false;
                comboBoxAge.Enabled = !false;
                comboBoxPosition.Enabled = !false;
                comboBoxSalary.Enabled = !false;
                textBoxPhone.Enabled = !false;
                checkBoxFire.Visible = false;
                ClearAddGroupBox();
                AddInputOnOff(true);
            }
            else
            {
                btnAdd.Text = "Update";
                checkBoxFire.Visible = true;
                listBoxEmployees.Enabled = true;
                AddInputOnOff(false);
            }
        }

        private void comboBoxEmployeesPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            employeesPerPage = int.Parse(comboBoxEmployeesPerPage.Text);
            totalPages = service.GetEmployeePagesCount(employeesPerPage);

            listBoxEmployees.Items.Clear();
            List<string> list = service.GetEmployeesBasicInfo(1, employeesPerPage);
            list.ForEach(p => listBoxEmployees.Items.Add(p));
            labelPages.Text = $"{currentPage} / {totalPages}";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage >= totalPages) { return; }
            listBoxEmployees.Items.Clear();
            List<string> list = service.GetEmployeesBasicInfo(++currentPage, employeesPerPage);
            list.ForEach(p => listBoxEmployees.Items.Add(p));
            labelPages.Text = $"{currentPage} / {totalPages}";
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage <= 1) { return; }
            listBoxEmployees.Items.Clear();
            List<string> list = service.GetEmployeesBasicInfo(--currentPage, employeesPerPage);
            list.ForEach(p => listBoxEmployees.Items.Add(p));
            labelPages.Text = $"{currentPage} / {totalPages}";
        }

        private void listBoxEmployees_DoubleClick(object sender, EventArgs e)
        {
            string employeeInfo = listBoxEmployees.Text;
            currentEmployeeId = int.Parse(employeeInfo.Split(' ').First());
            Employee employee = service.GetEmployeeById(currentEmployeeId);
            if (employee != null)
            {
                textBoxName.Text = employee.FirstName;
                textBoxLastName.Text = employee.LastName;
                comboBoxAge.Text = employee.Age.ToString();
                comboBoxPosition.Text= employee.Position.ToString();
                comboBoxSalary.Text = employee.Salary.ToString();
                textBoxPhone.Text = employee.ContactPhone;
            }
        }
    }
}
