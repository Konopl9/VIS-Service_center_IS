namespace Service_Center_IS
{
    partial class EditOrder
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
            this.NewOrderBackButton = new System.Windows.Forms.Button();
            this.EditOrderButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EditOrderPriceValue = new System.Windows.Forms.TextBox();
            this.EditOrderComplexityValue = new System.Windows.Forms.TextBox();
            this.EditOrderStatusValue = new System.Windows.Forms.ComboBox();
            this.EditOrderDefectValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EditShippedOrderDateValue = new System.Windows.Forms.DateTimePicker();
            this.EditFinishOrderDateValue = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewOrderBackButton
            // 
            this.NewOrderBackButton.Location = new System.Drawing.Point(212, 331);
            this.NewOrderBackButton.Name = "NewOrderBackButton";
            this.NewOrderBackButton.Size = new System.Drawing.Size(75, 23);
            this.NewOrderBackButton.TabIndex = 8;
            this.NewOrderBackButton.Text = "Cancel";
            this.NewOrderBackButton.UseVisualStyleBackColor = true;
            this.NewOrderBackButton.Click += new System.EventHandler(this.NewOrderBackButton_Click);
            // 
            // EditOrderButton
            // 
            this.EditOrderButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.EditOrderButton.Location = new System.Drawing.Point(15, 331);
            this.EditOrderButton.Name = "EditOrderButton";
            this.EditOrderButton.Size = new System.Drawing.Size(191, 23);
            this.EditOrderButton.TabIndex = 7;
            this.EditOrderButton.Text = "Edit Order";
            this.EditOrderButton.UseVisualStyleBackColor = true;
            this.EditOrderButton.Click += new System.EventHandler(this.EditOrderButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Complexity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
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
            // EditOrderPriceValue
            // 
            this.EditOrderPriceValue.Location = new System.Drawing.Point(127, 151);
            this.EditOrderPriceValue.Name = "EditOrderPriceValue";
            this.EditOrderPriceValue.Size = new System.Drawing.Size(155, 20);
            this.EditOrderPriceValue.TabIndex = 4;
            this.EditOrderPriceValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditOrderPriceValue_KeyPress);
            // 
            // EditOrderComplexityValue
            // 
            this.EditOrderComplexityValue.Location = new System.Drawing.Point(127, 177);
            this.EditOrderComplexityValue.Name = "EditOrderComplexityValue";
            this.EditOrderComplexityValue.Size = new System.Drawing.Size(156, 20);
            this.EditOrderComplexityValue.TabIndex = 5;
            this.EditOrderComplexityValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditOrderComplexityValue_KeyPress);
            // 
            // EditOrderStatusValue
            // 
            this.EditOrderStatusValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditOrderStatusValue.FormattingEnabled = true;
            this.EditOrderStatusValue.Items.AddRange(new object[] {
            "Not payed",
            "Free",
            "In progress",
            "Finished"});
            this.EditOrderStatusValue.Location = new System.Drawing.Point(127, 72);
            this.EditOrderStatusValue.Name = "EditOrderStatusValue";
            this.EditOrderStatusValue.Size = new System.Drawing.Size(155, 21);
            this.EditOrderStatusValue.TabIndex = 1;
            // 
            // EditOrderDefectValue
            // 
            this.EditOrderDefectValue.Location = new System.Drawing.Point(16, 222);
            this.EditOrderDefectValue.Multiline = true;
            this.EditOrderDefectValue.Name = "EditOrderDefectValue";
            this.EditOrderDefectValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EditOrderDefectValue.Size = new System.Drawing.Size(271, 103);
            this.EditOrderDefectValue.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "Shipped date:";
            // 
            // EditShippedOrderDateValue
            // 
            this.EditShippedOrderDateValue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EditShippedOrderDateValue.Location = new System.Drawing.Point(127, 99);
            this.EditShippedOrderDateValue.Name = "EditShippedOrderDateValue";
            this.EditShippedOrderDateValue.Size = new System.Drawing.Size(156, 20);
            this.EditShippedOrderDateValue.TabIndex = 2;
            this.EditShippedOrderDateValue.ValueChanged += new System.EventHandler(this.EditShippedOrderDateValue_ValueChanged);
            // 
            // EditFinishOrderDateValue
            // 
            this.EditFinishOrderDateValue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EditFinishOrderDateValue.Location = new System.Drawing.Point(127, 125);
            this.EditFinishOrderDateValue.Name = "EditFinishOrderDateValue";
            this.EditFinishOrderDateValue.Size = new System.Drawing.Size(156, 20);
            this.EditFinishOrderDateValue.TabIndex = 3;
            this.EditFinishOrderDateValue.ValueChanged += new System.EventHandler(this.EditFinishOrderDateValue_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 46;
            this.label8.Text = "Finish date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Defect:";
            // 
            // EditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 372);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EditFinishOrderDateValue);
            this.Controls.Add(this.EditShippedOrderDateValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EditOrderDefectValue);
            this.Controls.Add(this.EditOrderStatusValue);
            this.Controls.Add(this.EditOrderComplexityValue);
            this.Controls.Add(this.EditOrderPriceValue);
            this.Controls.Add(this.NewOrderBackButton);
            this.Controls.Add(this.EditOrderButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditOrder";
            this.Text = "Edit order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewOrderBackButton;
        private System.Windows.Forms.Button EditOrderButton;
        private System.Windows.Forms.TextBox EditOrderPriceValue;
        private System.Windows.Forms.TextBox EditOrderComplexityValue;
        private System.Windows.Forms.ComboBox EditOrderStatusValue;
        private System.Windows.Forms.TextBox EditOrderDefectValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker EditShippedOrderDateValue;
        private System.Windows.Forms.DateTimePicker EditFinishOrderDateValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}