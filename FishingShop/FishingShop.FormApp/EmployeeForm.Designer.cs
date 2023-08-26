namespace FishingShop.FormApp
{
    partial class EmployeeForm
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
            this.groupBoxHireEmployee = new System.Windows.Forms.GroupBox();
            this.checkBoxFire = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboBoxSalary = new System.Windows.Forms.ComboBox();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.comboBoxAge = new System.Windows.Forms.ComboBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.radioBtnEdit = new System.Windows.Forms.RadioButton();
            this.radioBtnAdd = new System.Windows.Forms.RadioButton();
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.labelPages = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.comboBoxEmployeesPerPage = new System.Windows.Forms.ComboBox();
            this.groupBoxHireEmployee.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxHireEmployee
            // 
            this.groupBoxHireEmployee.Controls.Add(this.checkBoxFire);
            this.groupBoxHireEmployee.Controls.Add(this.btnClear);
            this.groupBoxHireEmployee.Controls.Add(this.btnAdd);
            this.groupBoxHireEmployee.Controls.Add(this.comboBoxSalary);
            this.groupBoxHireEmployee.Controls.Add(this.comboBoxPosition);
            this.groupBoxHireEmployee.Controls.Add(this.comboBoxAge);
            this.groupBoxHireEmployee.Controls.Add(this.textBoxPhone);
            this.groupBoxHireEmployee.Controls.Add(this.textBoxLastName);
            this.groupBoxHireEmployee.Controls.Add(this.textBoxName);
            this.groupBoxHireEmployee.Controls.Add(this.label6);
            this.groupBoxHireEmployee.Controls.Add(this.label5);
            this.groupBoxHireEmployee.Controls.Add(this.label4);
            this.groupBoxHireEmployee.Controls.Add(this.label3);
            this.groupBoxHireEmployee.Controls.Add(this.label2);
            this.groupBoxHireEmployee.Controls.Add(this.label1);
            this.groupBoxHireEmployee.Location = new System.Drawing.Point(49, 32);
            this.groupBoxHireEmployee.Name = "groupBoxHireEmployee";
            this.groupBoxHireEmployee.Size = new System.Drawing.Size(373, 327);
            this.groupBoxHireEmployee.TabIndex = 0;
            this.groupBoxHireEmployee.TabStop = false;
            this.groupBoxHireEmployee.Text = "HireEmployee";
            // 
            // checkBoxFire
            // 
            this.checkBoxFire.AutoSize = true;
            this.checkBoxFire.Location = new System.Drawing.Point(21, 235);
            this.checkBoxFire.Name = "checkBoxFire";
            this.checkBoxFire.Size = new System.Drawing.Size(121, 24);
            this.checkBoxFire.TabIndex = 14;
            this.checkBoxFire.Text = "FireEmployee";
            this.checkBoxFire.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(196, 265);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 44);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(43, 265);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 44);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Hire";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboBoxSalary
            // 
            this.comboBoxSalary.FormattingEnabled = true;
            this.comboBoxSalary.Location = new System.Drawing.Point(165, 166);
            this.comboBoxSalary.Name = "comboBoxSalary";
            this.comboBoxSalary.Size = new System.Drawing.Size(125, 28);
            this.comboBoxSalary.TabIndex = 11;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Sales Associate",
            "Manager ",
            "Cashier",
            "Assistant Manager"});
            this.comboBoxPosition.Location = new System.Drawing.Point(164, 132);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(125, 28);
            this.comboBoxPosition.TabIndex = 10;
            // 
            // comboBoxAge
            // 
            this.comboBoxAge.FormattingEnabled = true;
            this.comboBoxAge.Location = new System.Drawing.Point(165, 98);
            this.comboBoxAge.Name = "comboBoxAge";
            this.comboBoxAge.Size = new System.Drawing.Size(125, 28);
            this.comboBoxAge.TabIndex = 9;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(165, 200);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(125, 27);
            this.textBoxPhone.TabIndex = 8;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(165, 65);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(125, 27);
            this.textBoxLastName.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(165, 35);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(125, 27);
            this.textBoxName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "ContactPhone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "LastName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName";
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.radioBtnEdit);
            this.groupBoxOptions.Controls.Add(this.radioBtnAdd);
            this.groupBoxOptions.Location = new System.Drawing.Point(92, 365);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(250, 61);
            this.groupBoxOptions.TabIndex = 1;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // radioBtnEdit
            // 
            this.radioBtnEdit.AutoSize = true;
            this.radioBtnEdit.Location = new System.Drawing.Point(140, 26);
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
            this.radioBtnAdd.Location = new System.Drawing.Point(33, 26);
            this.radioBtnAdd.Name = "radioBtnAdd";
            this.radioBtnAdd.Size = new System.Drawing.Size(58, 24);
            this.radioBtnAdd.TabIndex = 0;
            this.radioBtnAdd.TabStop = true;
            this.radioBtnAdd.Text = "Hire";
            this.radioBtnAdd.UseVisualStyleBackColor = true;
            this.radioBtnAdd.CheckedChanged += new System.EventHandler(this.radioBtnAdd_CheckedChanged);
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.ItemHeight = 20;
            this.listBoxEmployees.Location = new System.Drawing.Point(479, 37);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(367, 304);
            this.listBoxEmployees.TabIndex = 2;
            this.listBoxEmployees.DoubleClick += new System.EventHandler(this.listBoxEmployees_DoubleClick);
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(629, 356);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(15, 20);
            this.labelPages.TabIndex = 3;
            this.labelPages.Text = "-";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(521, 391);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(94, 48);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(653, 391);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 48);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // comboBoxEmployeesPerPage
            // 
            this.comboBoxEmployeesPerPage.FormattingEnabled = true;
            this.comboBoxEmployeesPerPage.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.comboBoxEmployeesPerPage.Location = new System.Drawing.Point(744, 348);
            this.comboBoxEmployeesPerPage.Name = "comboBoxEmployeesPerPage";
            this.comboBoxEmployeesPerPage.Size = new System.Drawing.Size(102, 28);
            this.comboBoxEmployeesPerPage.TabIndex = 6;
            this.comboBoxEmployeesPerPage.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployeesPerPage_SelectedIndexChanged);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 477);
            this.Controls.Add(this.comboBoxEmployeesPerPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.listBoxEmployees);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.groupBoxHireEmployee);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.groupBoxHireEmployee.ResumeLayout(false);
            this.groupBoxHireEmployee.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxHireEmployee;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboBoxSalary;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.ComboBox comboBoxAge;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.RadioButton radioBtnEdit;
        private System.Windows.Forms.RadioButton radioBtnAdd;
        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox comboBoxEmployeesPerPage;
        private System.Windows.Forms.CheckBox checkBoxFire;
    }
}