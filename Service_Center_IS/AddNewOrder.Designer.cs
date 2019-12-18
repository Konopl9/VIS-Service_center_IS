namespace Service_Center_IS
{
    partial class AddNewOrder
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
        /// 
        private void InitializeComponent()
        {
            this.NewOrderBackButton = new System.Windows.Forms.Button();
            this.AddNewOrderButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddOrderPriceValue = new System.Windows.Forms.TextBox();
            this.AddOrderComplexityValue = new System.Windows.Forms.TextBox();
            this.AddOrderStatusValue = new System.Windows.Forms.ComboBox();
            this.AddOrderDateValue = new System.Windows.Forms.DateTimePicker();
            this.AddOrderDefectValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddDeviceToOrderTypeValue = new System.Windows.Forms.ComboBox();
            this.AddDeviceToOrderCompanyValue = new System.Windows.Forms.ComboBox();
            this.AddDeviceToOrderModelValue = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewOrderBackButton
            // 
            this.NewOrderBackButton.Location = new System.Drawing.Point(208, 408);
            this.NewOrderBackButton.Name = "NewOrderBackButton";
            this.NewOrderBackButton.Size = new System.Drawing.Size(75, 23);
            this.NewOrderBackButton.TabIndex = 10;
            this.NewOrderBackButton.Text = "Cancel";
            this.NewOrderBackButton.UseVisualStyleBackColor = true;
            // 
            // AddNewOrderButton
            // 
            this.AddNewOrderButton.Location = new System.Drawing.Point(11, 408);
            this.AddNewOrderButton.Name = "AddNewOrderButton";
            this.AddNewOrderButton.Size = new System.Drawing.Size(191, 23);
            this.AddNewOrderButton.TabIndex = 9;
            this.AddNewOrderButton.Text = "Create new order";
            this.AddNewOrderButton.UseVisualStyleBackColor = true;
            this.AddNewOrderButton.Click += new System.EventHandler(this.AddNewOrderButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Defect:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Complexity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Order date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Order status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Order";
            // 
            // AddOrderPriceValue
            // 
            this.AddOrderPriceValue.Location = new System.Drawing.Point(128, 136);
            this.AddOrderPriceValue.Name = "AddOrderPriceValue";
            this.AddOrderPriceValue.Size = new System.Drawing.Size(155, 20);
            this.AddOrderPriceValue.TabIndex = 3;
            this.AddOrderPriceValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddOrderPriceValue_KeyPress);
            // 
            // AddOrderComplexityValue
            // 
            this.AddOrderComplexityValue.Location = new System.Drawing.Point(128, 168);
            this.AddOrderComplexityValue.Name = "AddOrderComplexityValue";
            this.AddOrderComplexityValue.Size = new System.Drawing.Size(155, 20);
            this.AddOrderComplexityValue.TabIndex = 4;
            this.AddOrderComplexityValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddOrderComplexityValue_KeyPress);
            // 
            // AddOrderStatusValue
            // 
            this.AddOrderStatusValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddOrderStatusValue.FormattingEnabled = true;
            this.AddOrderStatusValue.Items.AddRange(new object[] {
            "Not payed",
            "Free",
            "In progress",
            "Finished"});
            this.AddOrderStatusValue.Location = new System.Drawing.Point(128, 72);
            this.AddOrderStatusValue.Name = "AddOrderStatusValue";
            this.AddOrderStatusValue.Size = new System.Drawing.Size(155, 21);
            this.AddOrderStatusValue.TabIndex = 1;
            // 
            // AddOrderDateValue
            // 
            this.AddOrderDateValue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AddOrderDateValue.Location = new System.Drawing.Point(128, 104);
            this.AddOrderDateValue.Name = "AddOrderDateValue";
            this.AddOrderDateValue.Size = new System.Drawing.Size(155, 20);
            this.AddOrderDateValue.TabIndex = 2;
            // 
            // AddOrderDefectValue
            // 
            this.AddOrderDefectValue.Location = new System.Drawing.Point(11, 299);
            this.AddOrderDefectValue.Multiline = true;
            this.AddOrderDefectValue.Name = "AddOrderDefectValue";
            this.AddOrderDefectValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AddOrderDefectValue.Size = new System.Drawing.Size(271, 103);
            this.AddOrderDefectValue.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "Device type:";
            // 
            // AddDeviceToOrderTypeValue
            // 
            this.AddDeviceToOrderTypeValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddDeviceToOrderTypeValue.FormattingEnabled = true;
            this.AddDeviceToOrderTypeValue.Location = new System.Drawing.Point(128, 196);
            this.AddDeviceToOrderTypeValue.Name = "AddDeviceToOrderTypeValue";
            this.AddDeviceToOrderTypeValue.Size = new System.Drawing.Size(155, 21);
            this.AddDeviceToOrderTypeValue.TabIndex = 5;
            this.AddDeviceToOrderTypeValue.SelectedValueChanged += new System.EventHandler(this.AddDeviceToOrderTypeValue_SelectedValueChanged);
            // 
            // AddDeviceToOrderCompanyValue
            // 
            this.AddDeviceToOrderCompanyValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddDeviceToOrderCompanyValue.FormattingEnabled = true;
            this.AddDeviceToOrderCompanyValue.Location = new System.Drawing.Point(128, 223);
            this.AddDeviceToOrderCompanyValue.Name = "AddDeviceToOrderCompanyValue";
            this.AddDeviceToOrderCompanyValue.Size = new System.Drawing.Size(155, 21);
            this.AddDeviceToOrderCompanyValue.TabIndex = 6;
            this.AddDeviceToOrderCompanyValue.SelectedValueChanged += new System.EventHandler(this.AddDeviceToOrderCompanyValue_SelectedValueChanged);
            // 
            // AddDeviceToOrderModelValue
            // 
            this.AddDeviceToOrderModelValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddDeviceToOrderModelValue.FormattingEnabled = true;
            this.AddDeviceToOrderModelValue.Location = new System.Drawing.Point(128, 250);
            this.AddDeviceToOrderModelValue.Name = "AddDeviceToOrderModelValue";
            this.AddDeviceToOrderModelValue.Size = new System.Drawing.Size(155, 21);
            this.AddDeviceToOrderModelValue.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "Device company:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 16);
            this.label9.TabIndex = 48;
            this.label9.Text = "Device model:";
            // 
            // AddNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 463);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddDeviceToOrderModelValue);
            this.Controls.Add(this.AddDeviceToOrderCompanyValue);
            this.Controls.Add(this.AddDeviceToOrderTypeValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddOrderDefectValue);
            this.Controls.Add(this.AddOrderDateValue);
            this.Controls.Add(this.AddOrderStatusValue);
            this.Controls.Add(this.AddOrderComplexityValue);
            this.Controls.Add(this.AddOrderPriceValue);
            this.Controls.Add(this.NewOrderBackButton);
            this.Controls.Add(this.AddNewOrderButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewOrder";
            this.Text = "Add new order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewOrderBackButton;
        private System.Windows.Forms.Button AddNewOrderButton;
        private System.Windows.Forms.TextBox AddOrderPriceValue;
        private System.Windows.Forms.TextBox AddOrderComplexityValue;
        private System.Windows.Forms.ComboBox AddOrderStatusValue;
        private System.Windows.Forms.DateTimePicker AddOrderDateValue;
        private System.Windows.Forms.TextBox AddOrderDefectValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox AddDeviceToOrderTypeValue;
        private System.Windows.Forms.ComboBox AddDeviceToOrderCompanyValue;
        private System.Windows.Forms.ComboBox AddDeviceToOrderModelValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}