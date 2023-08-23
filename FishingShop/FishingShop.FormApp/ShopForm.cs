namespace FishingShop.FormApp
{
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
    public partial class ShopForm : Form
    {
        private ShopService service;
        private int currentPage = 1;
        private int itemsPerPage = 10;
        private int totalPages = 0;
        private int currentShopId = 0;
        public ShopForm()
        {
            InitializeComponent();
            service=new ShopService();
        }
        private void ClearAddGroupBox()
        {
            textBoxName.Text = string.Empty;
            comboBoxRating.SelectedIndex = 0;
            comboBoxLocation.SelectedIndex = 0;
            comboBoxType.SelectedIndex = 0;
        }

        private void AddInputOnOff(bool isActive)
        {
            textBoxName.Enabled = isActive;
            comboBoxLocation.Enabled = isActive;
            comboBoxType.Enabled = isActive;
            dateTimePicker1.Enabled= isActive;  
        }
        private void ShopForm_Load(object sender, EventArgs e)
        {
            for (double i = 2.0; i < 10.0; i += 0.1)
            {
                comboBoxRating.Items.Add($"{i:f1}");
            }
            comboBoxRating.SelectedIndex = 0;
            comboBoxItemsPerPage.SelectedIndex = 0;
            labelPages.Text = $"{currentPage} / {totalPages}";
            radioBtnAdd.Checked = true;
            checkBoxDeleteShop.Visible = false;
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
                string location = comboBoxLocation.Text;
                double rating = double.Parse(comboBoxRating.SelectedItem.ToString());
                string type = comboBoxType.Text;

                string result = service.AddShop(name, location, type,rating);
                MessageBox.Show(result);
                ClearAddGroupBox();
            }
            else if (btnAdd.Text == "Update")
            {
                if (checkBoxDeleteShop.Checked)
                {
                    MessageBox.Show(service.DeleteShopById(currentShopId));
                }
                else
                {
                    double rating = double.Parse(comboBoxRating.Text);
                    MessageBox.Show(service.UpdateShopRating(currentShopId, rating));
                }
                ClearAddGroupBox();
            }
        }

        private void radioBtnAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnAdd.Checked)
            {
                btnAdd.Text = "Add";
                listBoxShops.Enabled = false;
                textBoxName.Enabled = !false;
                comboBoxLocation.Enabled = !false;
                comboBoxRating.Enabled = !false;
                checkBoxDeleteShop.Visible = false;
                ClearAddGroupBox();
                AddInputOnOff(true);
            }
            else
            {
                btnAdd.Text = "Update";
                checkBoxDeleteShop.Visible = true;
                listBoxShops.Enabled = true;
                AddInputOnOff(false);
            }
        }

        private void comboBoxItemsPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemsPerPage = int.Parse(comboBoxItemsPerPage.Text);
            totalPages = service.GetShopsPagesCount(itemsPerPage);

            listBoxShops.Items.Clear();
            List<string> list = service.GetShopsBasicInfo(1, itemsPerPage);
            list.ForEach(p => listBoxShops.Items.Add(p));
            labelPages.Text = $"{currentPage} / {totalPages}";
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage <= 1) { return; }
            listBoxShops.Items.Clear();
            List<string> list = service.GetShopsBasicInfo(--currentPage, itemsPerPage);
            list.ForEach(p => listBoxShops.Items.Add(p));
            labelPages.Text = $"{currentPage} / {totalPages}";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage >= totalPages) { return; }
            listBoxShops.Items.Clear();
            List<string> list = service.GetShopsBasicInfo(++currentPage, itemsPerPage);
            list.ForEach(p => listBoxShops.Items.Add(p));
            labelPages.Text = $"{currentPage} / {totalPages}";
        }

        private void listBoxShops_DoubleClick(object sender, EventArgs e)
        {
            string shopInfo = listBoxShops.Text;
            currentShopId = int.Parse(shopInfo.Split(' ').First());
            Shop shop = service.GetShopById(currentShopId);
            if (shop != null)
            {
                textBoxName.Text = shop.Name;
                comboBoxLocation.Text = shop.Location.ToString();
                comboBoxRating.Text = shop.Rating.ToString();
                comboBoxType.Text = shop.Type.ToString();
            }
        }
    }
}
