namespace FishingShop.FormApp
{
    using FishingShop.Services;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    public partial class Order : Form
    {
        private OrderService orderService;
        private ClientService clientService;
        public Order()
        {
            InitializeComponent();
            orderService=new OrderService();
            clientService=new ClientService();  
        }

        private void Order_Load(object sender, EventArgs e)
        {
            labelInfo.Text = "Step 1 - Choose shop";
            List<string> shops = orderService.GetFromShop();
            shops.ForEach(x => listBoxShops.Items.Add(x));

            List<string> clients = clientService.GetClients();
            clients.ForEach(x => comboBox1.Items.Add(x));
            comboBox1.SelectedIndex = 0;
            listBoxProducts.Enabled = false;
        }

        private void listBoxShops_DoubleClick(object sender, EventArgs e)
        {
            labelInfo.Text = "Step 2 - Choose client ->";
            List<string> products = orderService.GetProducts();
            products.ForEach(x => listBoxProducts.Items.Add(x));
            listBoxShops.Enabled = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelInfo.Text = "Step 3 - Select Products";
            listBoxProducts.Enabled = true;
        }
        private void listBoxProducts_DoubleClick(object sender, EventArgs e)
        {
            labelInfo.Text = "Step 4 - Create order";
            listBoxOrder.Items.Add(listBoxProducts.SelectedItem);
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            int shoptId = int.Parse(listBoxShops.Text.Split(" - ").FirstOrDefault());
            int clientId = int.Parse(comboBox1.Text.Split(" - ").FirstOrDefault());
            decimal totalProductsPrice = 0;
            List<int> products = new List<int>();
            foreach (var item in listBoxOrder.Items)
            {
                int productId = int.Parse(item.ToString().Split(" - ").FirstOrDefault());
                decimal productPrice = decimal.Parse(item.ToString().Split(" - ").LastOrDefault().Replace("Leva", ""));
                products.Add(productId);
                totalProductsPrice += productPrice;
            }

            string result = orderService.CreateOrder(shoptId, clientId, products);
            MessageBox.Show(result + $"\nTotal products price: {totalProductsPrice:f2}");
          
            //this.Order_Load(sender, e);
            listBoxOrder.Items.Clear();
            listBoxProducts.Items.Clear();
            listBoxShops.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxOrder.SelectedIndex > -1)
            {
                listBoxOrder.Items.RemoveAt(listBoxOrder.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Select a product in the listbox!");
            }
        }
        private void btnShowOrder_Click(object sender, EventArgs e)
        {
            List<string> selectedProducts = new List<string>();
            foreach (var product in listBoxOrder.Items)
            {
                selectedProducts.Add(product.ToString());
            }
            List<string> products = new List<string>(selectedProducts);
            MessageBox.Show(string.Join(", ", products));
        }
        

    }
}
