namespace FishingShop.FormApp
{
    partial class ShopForm
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
            this.groupBoxCreateShop = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxRating = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.checkBoxDeleteShop = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.radioBtnEdit = new System.Windows.Forms.RadioButton();
            this.radioBtnAdd = new System.Windows.Forms.RadioButton();
            this.labelPages = new System.Windows.Forms.Label();
            this.comboBoxItemsPerPage = new System.Windows.Forms.ComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.listBoxShops = new System.Windows.Forms.ListBox();
            this.groupBoxCreateShop.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCreateShop
            // 
            this.groupBoxCreateShop.Controls.Add(this.dateTimePicker1);
            this.groupBoxCreateShop.Controls.Add(this.comboBoxRating);
            this.groupBoxCreateShop.Controls.Add(this.comboBoxType);
            this.groupBoxCreateShop.Controls.Add(this.comboBoxLocation);
            this.groupBoxCreateShop.Controls.Add(this.textBoxName);
            this.groupBoxCreateShop.Controls.Add(this.checkBoxDeleteShop);
            this.groupBoxCreateShop.Controls.Add(this.btnAdd);
            this.groupBoxCreateShop.Controls.Add(this.btnClear);
            this.groupBoxCreateShop.Controls.Add(this.label5);
            this.groupBoxCreateShop.Controls.Add(this.label4);
            this.groupBoxCreateShop.Controls.Add(this.label3);
            this.groupBoxCreateShop.Controls.Add(this.label2);
            this.groupBoxCreateShop.Controls.Add(this.label1);
            this.groupBoxCreateShop.Location = new System.Drawing.Point(49, 41);
            this.groupBoxCreateShop.Name = "groupBoxCreateShop";
            this.groupBoxCreateShop.Size = new System.Drawing.Size(384, 306);
            this.groupBoxCreateShop.TabIndex = 0;
            this.groupBoxCreateShop.TabStop = false;
            this.groupBoxCreateShop.Text = "Create";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 27);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // comboBoxRating
            // 
            this.comboBoxRating.FormattingEnabled = true;
            this.comboBoxRating.Location = new System.Drawing.Point(134, 149);
            this.comboBoxRating.Name = "comboBoxRating";
            this.comboBoxRating.Size = new System.Drawing.Size(131, 28);
            this.comboBoxRating.TabIndex = 11;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "sweetwater",
            "saltwater"});
            this.comboBoxType.Location = new System.Drawing.Point(134, 112);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(131, 28);
            this.comboBoxType.TabIndex = 10;
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Items.AddRange(new object[] {
            "Sofia",
            "Velingrad",
            "Plovdiv",
            "Blagoevgrad",
            "Varna",
            "Burgas",
            "Kiev",
            "Haskovo",
            "Talin",
            "Otawa",
            "Helsinki",
            "Boston",
            "Watertown",
            "Chicago"});
            this.comboBoxLocation.Location = new System.Drawing.Point(134, 77);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(131, 28);
            this.comboBoxLocation.TabIndex = 9;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(134, 33);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(131, 27);
            this.textBoxName.TabIndex = 8;
            // 
            // checkBoxDeleteShop
            // 
            this.checkBoxDeleteShop.AutoSize = true;
            this.checkBoxDeleteShop.Location = new System.Drawing.Point(27, 217);
            this.checkBoxDeleteShop.Name = "checkBoxDeleteShop";
            this.checkBoxDeleteShop.Size = new System.Drawing.Size(109, 24);
            this.checkBoxDeleteShop.TabIndex = 7;
            this.checkBoxDeleteShop.Text = "DeleteShop";
            this.checkBoxDeleteShop.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(59, 247);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 42);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(206, 247);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 42);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Established On";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.radioBtnEdit);
            this.groupBoxOptions.Controls.Add(this.radioBtnAdd);
            this.groupBoxOptions.Location = new System.Drawing.Point(99, 361);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(261, 65);
            this.groupBoxOptions.TabIndex = 1;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // radioBtnEdit
            // 
            this.radioBtnEdit.AutoSize = true;
            this.radioBtnEdit.Location = new System.Drawing.Point(157, 25);
            this.radioBtnEdit.Name = "radioBtnEdit";
            this.radioBtnEdit.Size = new System.Drawing.Size(56, 24);
            this.radioBtnEdit.TabIndex = 1;
            this.radioBtnEdit.TabStop = true;
            this.radioBtnEdit.Text = "Edit";
            this.radioBtnEdit.UseVisualStyleBackColor = true;
            // 
            // radioBtnAdd
            // 
            this.radioBtnAdd.AutoSize = true;
            this.radioBtnAdd.Location = new System.Drawing.Point(39, 25);
            this.radioBtnAdd.Name = "radioBtnAdd";
            this.radioBtnAdd.Size = new System.Drawing.Size(58, 24);
            this.radioBtnAdd.TabIndex = 0;
            this.radioBtnAdd.TabStop = true;
            this.radioBtnAdd.Text = "Add";
            this.radioBtnAdd.UseVisualStyleBackColor = true;
            this.radioBtnAdd.CheckedChanged += new System.EventHandler(this.radioBtnAdd_CheckedChanged);
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(583, 343);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(15, 20);
            this.labelPages.TabIndex = 2;
            this.labelPages.Text = "-";
            // 
            // comboBoxItemsPerPage
            // 
            this.comboBoxItemsPerPage.FormattingEnabled = true;
            this.comboBoxItemsPerPage.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.comboBoxItemsPerPage.Location = new System.Drawing.Point(743, 343);
            this.comboBoxItemsPerPage.Name = "comboBoxItemsPerPage";
            this.comboBoxItemsPerPage.Size = new System.Drawing.Size(107, 28);
            this.comboBoxItemsPerPage.TabIndex = 3;
            this.comboBoxItemsPerPage.SelectedIndexChanged += new System.EventHandler(this.comboBoxItemsPerPage_SelectedIndexChanged);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(641, 377);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 49);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(487, 377);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(94, 49);
            this.buttonPrevious.TabIndex = 5;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // listBoxShops
            // 
            this.listBoxShops.FormattingEnabled = true;
            this.listBoxShops.ItemHeight = 20;
            this.listBoxShops.Location = new System.Drawing.Point(473, 42);
            this.listBoxShops.Name = "listBoxShops";
            this.listBoxShops.Size = new System.Drawing.Size(377, 284);
            this.listBoxShops.TabIndex = 6;
            this.listBoxShops.DoubleClick += new System.EventHandler(this.listBoxShops_DoubleClick);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.listBoxShops);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.comboBoxItemsPerPage);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.groupBoxCreateShop);
            this.Name = "ShopForm";
            this.Text = "ShopForm";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.groupBoxCreateShop.ResumeLayout(false);
            this.groupBoxCreateShop.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCreateShop;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxRating;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxDeleteShop;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.RadioButton radioBtnEdit;
        private System.Windows.Forms.RadioButton radioBtnAdd;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.ComboBox comboBoxItemsPerPage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.ListBox listBoxShops;
    }
}