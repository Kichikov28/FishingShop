namespace FishingShop.FormApp
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxShops = new System.Windows.Forms.ListBox();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.listBoxOrder = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.btnShowOrder = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxShops
            // 
            this.listBoxShops.FormattingEnabled = true;
            this.listBoxShops.ItemHeight = 20;
            this.listBoxShops.Location = new System.Drawing.Point(30, 79);
            this.listBoxShops.Name = "listBoxShops";
            this.listBoxShops.Size = new System.Drawing.Size(280, 344);
            this.listBoxShops.TabIndex = 0;
            this.listBoxShops.DoubleClick += new System.EventHandler(this.listBoxShops_DoubleClick);
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 20;
            this.listBoxProducts.Location = new System.Drawing.Point(341, 79);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(280, 344);
            this.listBoxProducts.TabIndex = 1;
            this.listBoxProducts.DoubleClick += new System.EventHandler(this.listBoxProducts_DoubleClick);
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.ItemHeight = 20;
            this.listBoxOrder.Location = new System.Drawing.Point(661, 79);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(280, 344);
            this.listBoxOrder.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(756, 434);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Product";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateOrder.Location = new System.Drawing.Point(30, 443);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(161, 48);
            this.btnCreateOrder.TabIndex = 4;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // btnShowOrder
            // 
            this.btnShowOrder.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowOrder.Location = new System.Drawing.Point(756, 480);
            this.btnShowOrder.Name = "btnShowOrder";
            this.btnShowOrder.Size = new System.Drawing.Size(161, 40);
            this.btnShowOrder.TabIndex = 5;
            this.btnShowOrder.Text = "Show Order";
            this.btnShowOrder.UseVisualStyleBackColor = true;
            this.btnShowOrder.Click += new System.EventHandler(this.btnShowOrder_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(661, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInfo.Location = new System.Drawing.Point(396, 25);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(179, 20);
            this.labelInfo.TabIndex = 7;
            this.labelInfo.Text = "Step 1- Choose Shop";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(968, 532);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnShowOrder);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listBoxOrder);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.listBoxShops);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxShops;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.ListBox listBoxOrder;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button btnShowOrder;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelInfo;
    }
}