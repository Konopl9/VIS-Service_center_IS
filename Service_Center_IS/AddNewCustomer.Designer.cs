namespace Service_Center_IS
{
    partial class AddNewCustomer
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
            this.NewCustomerBackButton = new System.Windows.Forms.Button();
            this.AddNewCustomerButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddNewCustomerPhoneValue = new System.Windows.Forms.TextBox();
            this.AddNewCustomerDateValue = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.AddNewCustomerSurnameValue = new System.Windows.Forms.TextBox();
            this.AddNewCustomerNameValue = new System.Windows.Forms.TextBox();
            this.AddNewCustomerEmailValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NewCustomerBackButton
            // 
            this.NewCustomerBackButton.Location = new System.Drawing.Point(208, 222);
            this.NewCustomerBackButton.Name = "NewCustomerBackButton";
            this.NewCustomerBackButton.Size = new System.Drawing.Size(75, 23);
            this.NewCustomerBackButton.TabIndex = 8;
            this.NewCustomerBackButton.Text = "Cancel";
            this.NewCustomerBackButton.UseVisualStyleBackColor = true;
            // 
            // AddNewCustomerButton
            // 
            this.AddNewCustomerButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddNewCustomerButton.Location = new System.Drawing.Point(11, 222);
            this.AddNewCustomerButton.Name = "AddNewCustomerButton";
            this.AddNewCustomerButton.Size = new System.Drawing.Size(191, 23);
            this.AddNewCustomerButton.TabIndex = 7;
            this.AddNewCustomerButton.Text = "Add new customer";
            this.AddNewCustomerButton.UseVisualStyleBackColor = true;
            this.AddNewCustomerButton.Click += new System.EventHandler(this.AddNewCustomerButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Date of birthday:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Customer";
            // 
            // AddNewCustomerPhoneValue
            // 
            this.AddNewCustomerPhoneValue.Location = new System.Drawing.Point(128, 168);
            this.AddNewCustomerPhoneValue.Name = "AddNewCustomerPhoneValue";
            this.AddNewCustomerPhoneValue.Size = new System.Drawing.Size(155, 20);
            this.AddNewCustomerPhoneValue.TabIndex = 4;
            // 
            // AddNewCustomerDateValue
            // 
            this.AddNewCustomerDateValue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AddNewCustomerDateValue.Location = new System.Drawing.Point(128, 132);
            this.AddNewCustomerDateValue.Name = "AddNewCustomerDateValue";
            this.AddNewCustomerDateValue.Size = new System.Drawing.Size(155, 20);
            this.AddNewCustomerDateValue.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "Email:";
            // 
            // AddNewCustomerSurnameValue
            // 
            this.AddNewCustomerSurnameValue.Location = new System.Drawing.Point(128, 100);
            this.AddNewCustomerSurnameValue.Name = "AddNewCustomerSurnameValue";
            this.AddNewCustomerSurnameValue.Size = new System.Drawing.Size(155, 20);
            this.AddNewCustomerSurnameValue.TabIndex = 2;
            // 
            // AddNewCustomerNameValue
            // 
            this.AddNewCustomerNameValue.Location = new System.Drawing.Point(128, 68);
            this.AddNewCustomerNameValue.Name = "AddNewCustomerNameValue";
            this.AddNewCustomerNameValue.Size = new System.Drawing.Size(155, 20);
            this.AddNewCustomerNameValue.TabIndex = 1;
            // 
            // AddNewCustomerEmailValue
            // 
            this.AddNewCustomerEmailValue.Location = new System.Drawing.Point(128, 196);
            this.AddNewCustomerEmailValue.Name = "AddNewCustomerEmailValue";
            this.AddNewCustomerEmailValue.Size = new System.Drawing.Size(155, 20);
            this.AddNewCustomerEmailValue.TabIndex = 5;
            // 
            // AddNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 265);
            this.Controls.Add(this.AddNewCustomerEmailValue);
            this.Controls.Add(this.AddNewCustomerNameValue);
            this.Controls.Add(this.AddNewCustomerSurnameValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddNewCustomerDateValue);
            this.Controls.Add(this.AddNewCustomerPhoneValue);
            this.Controls.Add(this.NewCustomerBackButton);
            this.Controls.Add(this.AddNewCustomerButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewCustomer";
            this.Text = "Add new customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewCustomerBackButton;
        private System.Windows.Forms.Button AddNewCustomerButton;
        private System.Windows.Forms.TextBox AddNewCustomerPhoneValue;
        private System.Windows.Forms.DateTimePicker AddNewCustomerDateValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AddNewCustomerSurnameValue;
        private System.Windows.Forms.TextBox AddNewCustomerNameValue;
        private System.Windows.Forms.TextBox AddNewCustomerEmailValue;
    }
}