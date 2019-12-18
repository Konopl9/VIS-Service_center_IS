namespace Service_Center_IS
{
    partial class AdministrationForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.InvoceForChosenOrderButton = new System.Windows.Forms.Button();
            this.DeleteChosenOrderButton = new System.Windows.Forms.Button();
            this.EditChosenOrderButton = new System.Windows.Forms.Button();
            this.SearchOrderByWorkerButton = new System.Windows.Forms.Button();
            this.SearchOrderByWorkerValue = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchOrderByDateButton = new System.Windows.Forms.Button();
            this.SearchOrderByDateToValue = new System.Windows.Forms.DateTimePicker();
            this.SearchOrderByDataButton = new System.Windows.Forms.Button();
            this.SearchOrderByIdButton = new System.Windows.Forms.Button();
            this.SearchOrderByDateFromValue = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchOrderByIdValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchOrderBySurnameValue = new System.Windows.Forms.TextBox();
            this.SearchOrderByNameValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CreateNewOrderToChosenCustomerButton = new System.Windows.Forms.Button();
            this.AddAddressChosenCustomerButton = new System.Windows.Forms.Button();
            this.DeleteChosenCustomerButton = new System.Windows.Forms.Button();
            this.EditChosenCustomerButton = new System.Windows.Forms.Button();
            this.AddNewCustomerButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.UpEmployeeQualification = new System.Windows.Forms.Button();
            this.ShowEmployeeOfTheMonth = new System.Windows.Forms.Button();
            this.ShowSalaryButton = new System.Windows.Forms.Button();
            this.DeleteChosenEmployeeButton = new System.Windows.Forms.Button();
            this.EditChosenEmployeeButton = new System.Windows.Forms.Button();
            this.AddNewEmployeeButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(456, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(694, 474);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(16, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(432, 470);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.InvoceForChosenOrderButton);
            this.tabPage1.Controls.Add(this.DeleteChosenOrderButton);
            this.tabPage1.Controls.Add(this.EditChosenOrderButton);
            this.tabPage1.Controls.Add(this.SearchOrderByWorkerButton);
            this.tabPage1.Controls.Add(this.SearchOrderByWorkerValue);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.SearchOrderByDateButton);
            this.tabPage1.Controls.Add(this.SearchOrderByDateToValue);
            this.tabPage1.Controls.Add(this.SearchOrderByDataButton);
            this.tabPage1.Controls.Add(this.SearchOrderByIdButton);
            this.tabPage1.Controls.Add(this.SearchOrderByDateFromValue);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.SearchOrderByIdValue);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.SearchOrderBySurnameValue);
            this.tabPage1.Controls.Add(this.SearchOrderByNameValue);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(424, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Orders";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // InvoceForChosenOrderButton
            // 
            this.InvoceForChosenOrderButton.Location = new System.Drawing.Point(187, 364);
            this.InvoceForChosenOrderButton.Name = "InvoceForChosenOrderButton";
            this.InvoceForChosenOrderButton.Size = new System.Drawing.Size(183, 26);
            this.InvoceForChosenOrderButton.TabIndex = 13;
            this.InvoceForChosenOrderButton.Text = "Order invoice";
            this.InvoceForChosenOrderButton.UseVisualStyleBackColor = true;
            this.InvoceForChosenOrderButton.Click += new System.EventHandler(this.InvoceForChosenOrderButton_Click);
            // 
            // DeleteChosenOrderButton
            // 
            this.DeleteChosenOrderButton.Location = new System.Drawing.Point(186, 332);
            this.DeleteChosenOrderButton.Name = "DeleteChosenOrderButton";
            this.DeleteChosenOrderButton.Size = new System.Drawing.Size(184, 26);
            this.DeleteChosenOrderButton.TabIndex = 12;
            this.DeleteChosenOrderButton.Text = "Delete chosen order";
            this.DeleteChosenOrderButton.UseVisualStyleBackColor = true;
            this.DeleteChosenOrderButton.Click += new System.EventHandler(this.DeleteChosenOrderButton_Click);
            // 
            // EditChosenOrderButton
            // 
            this.EditChosenOrderButton.Location = new System.Drawing.Point(186, 300);
            this.EditChosenOrderButton.Name = "EditChosenOrderButton";
            this.EditChosenOrderButton.Size = new System.Drawing.Size(184, 26);
            this.EditChosenOrderButton.TabIndex = 11;
            this.EditChosenOrderButton.Text = "Edit chosen order";
            this.EditChosenOrderButton.UseVisualStyleBackColor = true;
            this.EditChosenOrderButton.Click += new System.EventHandler(this.EditChosenOrderButton_Click);
            // 
            // SearchOrderByWorkerButton
            // 
            this.SearchOrderByWorkerButton.Location = new System.Drawing.Point(186, 268);
            this.SearchOrderByWorkerButton.Name = "SearchOrderByWorkerButton";
            this.SearchOrderByWorkerButton.Size = new System.Drawing.Size(184, 26);
            this.SearchOrderByWorkerButton.TabIndex = 10;
            this.SearchOrderByWorkerButton.Text = "Search";
            this.SearchOrderByWorkerButton.UseVisualStyleBackColor = true;
            this.SearchOrderByWorkerButton.Click += new System.EventHandler(this.SearchOrderByWorkerButton_Click);
            // 
            // SearchOrderByWorkerValue
            // 
            this.SearchOrderByWorkerValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchOrderByWorkerValue.FormattingEnabled = true;
            this.SearchOrderByWorkerValue.Location = new System.Drawing.Point(187, 241);
            this.SearchOrderByWorkerValue.Name = "SearchOrderByWorkerValue";
            this.SearchOrderByWorkerValue.Size = new System.Drawing.Size(183, 21);
            this.SearchOrderByWorkerValue.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Search order by worker:\r\n";
            // 
            // SearchOrderByDateButton
            // 
            this.SearchOrderByDateButton.Location = new System.Drawing.Point(187, 209);
            this.SearchOrderByDateButton.Name = "SearchOrderByDateButton";
            this.SearchOrderByDateButton.Size = new System.Drawing.Size(184, 26);
            this.SearchOrderByDateButton.TabIndex = 8;
            this.SearchOrderByDateButton.Text = "Search";
            this.SearchOrderByDateButton.UseVisualStyleBackColor = true;
            this.SearchOrderByDateButton.Click += new System.EventHandler(this.SearchOrderByDateButton_Click);
            // 
            // SearchOrderByDateToValue
            // 
            this.SearchOrderByDateToValue.Location = new System.Drawing.Point(187, 183);
            this.SearchOrderByDateToValue.Name = "SearchOrderByDateToValue";
            this.SearchOrderByDateToValue.Size = new System.Drawing.Size(184, 20);
            this.SearchOrderByDateToValue.TabIndex = 7;
            // 
            // SearchOrderByDataButton
            // 
            this.SearchOrderByDataButton.Location = new System.Drawing.Point(187, 125);
            this.SearchOrderByDataButton.Name = "SearchOrderByDataButton";
            this.SearchOrderByDataButton.Size = new System.Drawing.Size(184, 26);
            this.SearchOrderByDataButton.TabIndex = 5;
            this.SearchOrderByDataButton.Text = "Search";
            this.SearchOrderByDataButton.UseVisualStyleBackColor = true;
            this.SearchOrderByDataButton.Click += new System.EventHandler(this.SearchOrderByDataButton_Click);
            // 
            // SearchOrderByIdButton
            // 
            this.SearchOrderByIdButton.Location = new System.Drawing.Point(186, 41);
            this.SearchOrderByIdButton.Name = "SearchOrderByIdButton";
            this.SearchOrderByIdButton.Size = new System.Drawing.Size(185, 26);
            this.SearchOrderByIdButton.TabIndex = 2;
            this.SearchOrderByIdButton.Text = "Search";
            this.SearchOrderByIdButton.UseVisualStyleBackColor = true;
            this.SearchOrderByIdButton.Click += new System.EventHandler(this.SearchOrderByIdButton_Click);
            // 
            // SearchOrderByDateFromValue
            // 
            this.SearchOrderByDateFromValue.Location = new System.Drawing.Point(187, 157);
            this.SearchOrderByDateFromValue.Name = "SearchOrderByDateFromValue";
            this.SearchOrderByDateFromValue.Size = new System.Drawing.Size(184, 20);
            this.SearchOrderByDateFromValue.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 34);
            this.label2.TabIndex = 22;
            this.label2.Text = "Search order by date:\r\n*From date and to date\r\n";
            // 
            // SearchOrderByIdValue
            // 
            this.SearchOrderByIdValue.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.SearchOrderByIdValue.Location = new System.Drawing.Point(187, 15);
            this.SearchOrderByIdValue.Name = "SearchOrderByIdValue";
            this.SearchOrderByIdValue.Size = new System.Drawing.Size(184, 20);
            this.SearchOrderByIdValue.TabIndex = 1;
            this.SearchOrderByIdValue.Text = "Order id";
            this.SearchOrderByIdValue.Enter += new System.EventHandler(this.SearchOrderByIdValue_Enter);
            this.SearchOrderByIdValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchOrderByIdValue_KeyPress);
            this.SearchOrderByIdValue.Leave += new System.EventHandler(this.SearchOrderByIdValue_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Other order option:";
            // 
            // SearchOrderBySurnameValue
            // 
            this.SearchOrderBySurnameValue.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.SearchOrderBySurnameValue.Location = new System.Drawing.Point(187, 99);
            this.SearchOrderBySurnameValue.Name = "SearchOrderBySurnameValue";
            this.SearchOrderBySurnameValue.Size = new System.Drawing.Size(184, 20);
            this.SearchOrderBySurnameValue.TabIndex = 4;
            this.SearchOrderBySurnameValue.Text = "Surname";
            this.SearchOrderBySurnameValue.Enter += new System.EventHandler(this.SearchOrderBySurnameValue_Enter);
            this.SearchOrderBySurnameValue.Leave += new System.EventHandler(this.SearchOrderBySurnameValue_Leave);
            // 
            // SearchOrderByNameValue
            // 
            this.SearchOrderByNameValue.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.SearchOrderByNameValue.Location = new System.Drawing.Point(187, 73);
            this.SearchOrderByNameValue.Name = "SearchOrderByNameValue";
            this.SearchOrderByNameValue.Size = new System.Drawing.Size(183, 20);
            this.SearchOrderByNameValue.TabIndex = 3;
            this.SearchOrderByNameValue.Text = "Name";
            this.SearchOrderByNameValue.Enter += new System.EventHandler(this.SearchOrderByNameValue_Enter);
            this.SearchOrderByNameValue.Leave += new System.EventHandler(this.SearchOrderByNameValue_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Search order by user data:\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Search order by id:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CreateNewOrderToChosenCustomerButton);
            this.tabPage2.Controls.Add(this.AddAddressChosenCustomerButton);
            this.tabPage2.Controls.Add(this.DeleteChosenCustomerButton);
            this.tabPage2.Controls.Add(this.EditChosenCustomerButton);
            this.tabPage2.Controls.Add(this.AddNewCustomerButton);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(424, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CreateNewOrderToChosenCustomerButton
            // 
            this.CreateNewOrderToChosenCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewOrderToChosenCustomerButton.Location = new System.Drawing.Point(188, 143);
            this.CreateNewOrderToChosenCustomerButton.Name = "CreateNewOrderToChosenCustomerButton";
            this.CreateNewOrderToChosenCustomerButton.Size = new System.Drawing.Size(184, 26);
            this.CreateNewOrderToChosenCustomerButton.TabIndex = 5;
            this.CreateNewOrderToChosenCustomerButton.Text = "Create new order";
            this.CreateNewOrderToChosenCustomerButton.UseVisualStyleBackColor = true;
            this.CreateNewOrderToChosenCustomerButton.Click += new System.EventHandler(this.CreateNewOrderToChosenCustomerButton_Click);
            // 
            // AddAddressChosenCustomerButton
            // 
            this.AddAddressChosenCustomerButton.Location = new System.Drawing.Point(187, 111);
            this.AddAddressChosenCustomerButton.Name = "AddAddressChosenCustomerButton";
            this.AddAddressChosenCustomerButton.Size = new System.Drawing.Size(184, 26);
            this.AddAddressChosenCustomerButton.TabIndex = 4;
            this.AddAddressChosenCustomerButton.Text = "Add address information";
            this.AddAddressChosenCustomerButton.UseVisualStyleBackColor = true;
            this.AddAddressChosenCustomerButton.Click += new System.EventHandler(this.AddAddressChosenCustomerButton_Click);
            // 
            // DeleteChosenCustomerButton
            // 
            this.DeleteChosenCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteChosenCustomerButton.Location = new System.Drawing.Point(188, 79);
            this.DeleteChosenCustomerButton.Name = "DeleteChosenCustomerButton";
            this.DeleteChosenCustomerButton.Size = new System.Drawing.Size(183, 26);
            this.DeleteChosenCustomerButton.TabIndex = 3;
            this.DeleteChosenCustomerButton.Text = "Delete chosen customer";
            this.DeleteChosenCustomerButton.UseVisualStyleBackColor = true;
            this.DeleteChosenCustomerButton.Click += new System.EventHandler(this.DeleteChosenCustomerButton_Click);
            // 
            // EditChosenCustomerButton
            // 
            this.EditChosenCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditChosenCustomerButton.Location = new System.Drawing.Point(187, 47);
            this.EditChosenCustomerButton.Name = "EditChosenCustomerButton";
            this.EditChosenCustomerButton.Size = new System.Drawing.Size(184, 26);
            this.EditChosenCustomerButton.TabIndex = 2;
            this.EditChosenCustomerButton.Text = "Edit chosen customer";
            this.EditChosenCustomerButton.UseVisualStyleBackColor = true;
            this.EditChosenCustomerButton.Click += new System.EventHandler(this.EditChosenCustomerButton_Click);
            // 
            // AddNewCustomerButton
            // 
            this.AddNewCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewCustomerButton.Location = new System.Drawing.Point(187, 15);
            this.AddNewCustomerButton.Name = "AddNewCustomerButton";
            this.AddNewCustomerButton.Size = new System.Drawing.Size(184, 26);
            this.AddNewCustomerButton.TabIndex = 1;
            this.AddNewCustomerButton.Text = "Add new customer";
            this.AddNewCustomerButton.UseVisualStyleBackColor = true;
            this.AddNewCustomerButton.Click += new System.EventHandler(this.AddNewCustomerButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Customer option:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.UpEmployeeQualification);
            this.tabPage3.Controls.Add(this.ShowEmployeeOfTheMonth);
            this.tabPage3.Controls.Add(this.ShowSalaryButton);
            this.tabPage3.Controls.Add(this.DeleteChosenEmployeeButton);
            this.tabPage3.Controls.Add(this.EditChosenEmployeeButton);
            this.tabPage3.Controls.Add(this.AddNewEmployeeButton);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(424, 444);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Employee";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // UpEmployeeQualification
            // 
            this.UpEmployeeQualification.Location = new System.Drawing.Point(202, 67);
            this.UpEmployeeQualification.Name = "UpEmployeeQualification";
            this.UpEmployeeQualification.Size = new System.Drawing.Size(184, 26);
            this.UpEmployeeQualification.TabIndex = 5;
            this.UpEmployeeQualification.Text = "Increase qualification";
            this.UpEmployeeQualification.UseVisualStyleBackColor = true;
            this.UpEmployeeQualification.Click += new System.EventHandler(this.UpEmployeeQualification_Click);
            // 
            // ShowEmployeeOfTheMonth
            // 
            this.ShowEmployeeOfTheMonth.Location = new System.Drawing.Point(202, 99);
            this.ShowEmployeeOfTheMonth.Name = "ShowEmployeeOfTheMonth";
            this.ShowEmployeeOfTheMonth.Size = new System.Drawing.Size(184, 26);
            this.ShowEmployeeOfTheMonth.TabIndex = 6;
            this.ShowEmployeeOfTheMonth.Text = "Show employee of the month";
            this.ShowEmployeeOfTheMonth.UseVisualStyleBackColor = true;
            this.ShowEmployeeOfTheMonth.Click += new System.EventHandler(this.ShowEmployeeOfTheMonth_Click);
            // 
            // ShowSalaryButton
            // 
            this.ShowSalaryButton.Location = new System.Drawing.Point(202, 35);
            this.ShowSalaryButton.Name = "ShowSalaryButton";
            this.ShowSalaryButton.Size = new System.Drawing.Size(184, 26);
            this.ShowSalaryButton.TabIndex = 4;
            this.ShowSalaryButton.Text = "Show employees salary";
            this.ShowSalaryButton.UseVisualStyleBackColor = true;
            this.ShowSalaryButton.Click += new System.EventHandler(this.ShowSalaryButton_Click);
            // 
            // DeleteChosenEmployeeButton
            // 
            this.DeleteChosenEmployeeButton.Location = new System.Drawing.Point(6, 99);
            this.DeleteChosenEmployeeButton.Name = "DeleteChosenEmployeeButton";
            this.DeleteChosenEmployeeButton.Size = new System.Drawing.Size(183, 26);
            this.DeleteChosenEmployeeButton.TabIndex = 3;
            this.DeleteChosenEmployeeButton.Text = "Delete chosen employee";
            this.DeleteChosenEmployeeButton.UseVisualStyleBackColor = true;
            this.DeleteChosenEmployeeButton.Click += new System.EventHandler(this.DeleteChosenEmployeeButton_Click);
            // 
            // EditChosenEmployeeButton
            // 
            this.EditChosenEmployeeButton.Location = new System.Drawing.Point(6, 67);
            this.EditChosenEmployeeButton.Name = "EditChosenEmployeeButton";
            this.EditChosenEmployeeButton.Size = new System.Drawing.Size(184, 26);
            this.EditChosenEmployeeButton.TabIndex = 2;
            this.EditChosenEmployeeButton.Text = "Edit chosen employee";
            this.EditChosenEmployeeButton.UseVisualStyleBackColor = true;
            this.EditChosenEmployeeButton.Click += new System.EventHandler(this.EditChosenEmployeeButton_Click);
            // 
            // AddNewEmployeeButton
            // 
            this.AddNewEmployeeButton.Location = new System.Drawing.Point(6, 35);
            this.AddNewEmployeeButton.Name = "AddNewEmployeeButton";
            this.AddNewEmployeeButton.Size = new System.Drawing.Size(184, 26);
            this.AddNewEmployeeButton.TabIndex = 1;
            this.AddNewEmployeeButton.Text = "Add new employee";
            this.AddNewEmployeeButton.UseVisualStyleBackColor = true;
            this.AddNewEmployeeButton.Click += new System.EventHandler(this.AddNewEmployeeButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Employee option:";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 496);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdministrationForm";
            this.Text = "Sevice(Administrator)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SearchOrderByNameValue;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SearchOrderBySurnameValue;
        private System.Windows.Forms.Button InvoceForChosenOrderButton;
        private System.Windows.Forms.Button DeleteChosenOrderButton;
        private System.Windows.Forms.Button EditChosenOrderButton;
        private System.Windows.Forms.Button SearchOrderByWorkerButton;
        private System.Windows.Forms.ComboBox SearchOrderByWorkerValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchOrderByDateButton;
        private System.Windows.Forms.DateTimePicker SearchOrderByDateToValue;
        private System.Windows.Forms.Button SearchOrderByDataButton;
        private System.Windows.Forms.Button SearchOrderByIdButton;
        private System.Windows.Forms.DateTimePicker SearchOrderByDateFromValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchOrderByIdValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateNewOrderToChosenCustomerButton;
        private System.Windows.Forms.Button AddAddressChosenCustomerButton;
        private System.Windows.Forms.Button DeleteChosenCustomerButton;
        private System.Windows.Forms.Button EditChosenCustomerButton;
        private System.Windows.Forms.Button AddNewCustomerButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ShowEmployeeOfTheMonth;
        private System.Windows.Forms.Button ShowSalaryButton;
        private System.Windows.Forms.Button DeleteChosenEmployeeButton;
        private System.Windows.Forms.Button EditChosenEmployeeButton;
        private System.Windows.Forms.Button AddNewEmployeeButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button UpEmployeeQualification;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}