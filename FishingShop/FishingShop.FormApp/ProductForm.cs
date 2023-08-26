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
using System.Xml.Linq;

namespace FishingShop.FormApp
{
    public partial class ProductForm : Form
    {
        private ProductService service;
        private int currentPage = 1;
        private int productsPerPage = 10;
        private int totalPages = 0;
        private int currentProductId = 0;
        public ProductForm()
        {
            InitializeComponent();
            service= new ProductService();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            comboBoxProductsPerPage.SelectedIndex = 0;
            labelPages.Text = $"{currentPage} / {totalPages}";
        }
        private void ClearAddGroupBox()
        {
            textBoxName.Text = string.Empty;
            textBoxPrice.Text = string.Empty;
            textBoxDelete.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxDelete.Text);
            string result = service.DeleteProductById(id);
            MessageBox.Show(result);
            ClearAddGroupBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            decimal price = decimal.Parse(textBoxPrice.Text);
            var result = service.AddProduct(name, price);
            MessageBox.Show(result);
            ClearAddGroupBox();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAddGroupBox();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage >= totalPages) { return; }
            listBoxProducts.Items.Clear();
            List<string> list = service.GetProductsBasicInfo(++currentPage, productsPerPage);
            list.ForEach(p => listBoxProducts.Items.Add(p));
            labelPages.Text = $"{currentPage} / {totalPages}";
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage <= 1) { return; }
            listBoxProducts.Items.Clear();
            List<string> list = service.GetProductsBasicInfo(--currentPage, productsPerPage);
            list.ForEach(p => listBoxProducts.Items.Add(p));
            labelPages.Text = $"{currentPage} / {totalPages}";

        }

        private void comboBoxProductsPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            productsPerPage = int.Parse(comboBoxProductsPerPage.Text);
            totalPages = service.GetProductsPagesCount(productsPerPage);

            listBoxProducts.Items.Clear();
            List<string> list = service.GetProductsBasicInfo(1, productsPerPage);
            list.ForEach(i => listBoxProducts.Items.Add(i));
            labelPages.Text = $"{currentPage} / {totalPages}";
        }

        private void listBoxProducts_DoubleClick(object sender, EventArgs e)
        {
            string productsInfo = listBoxProducts.Text;
            currentProductId = int.Parse(productsInfo.Split(' ').First());
            Product product = service.GetProductById(currentProductId);
            if (product != null)
            {
                textBoxName.Text = product.Name;
                textBoxPrice.Text = product.Price.ToString();
            }
        }
    }
}
