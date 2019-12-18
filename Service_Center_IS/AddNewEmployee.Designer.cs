namespace Service_Center_IS
{
    partial class AddNewEmployee
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
            this.NewEmployeeBackButton = new System.Windows.Forms.Button();
            this.AddNewEmployeeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddNewEmployeeGenderValue = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AddNewEmployeePositionValue = new System.Windows.Forms.ComboBox();
            this.AddNewEmployeeNameValue = new System.Windows.Forms.TextBox();
            this.AddNewEmployeeSurnameValue = new System.Windows.Forms.TextBox();
            this.AddNewEmployeeDateValue = new System.Windows.Forms.DateTimePicker();
            this.AddNewEmployeePhoneValue = new System.Windows.Forms.TextBox();
            this.AddNewEmployeeEmailValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NewEmployeeBackButton
            // 
            this.NewEmployeeBackButton.Location = new System.Drawing.Point(208, 277);
            this.NewEmployeeBackButton.Name = "NewEmployeeBackButton";
            this.NewEmployeeBackButton.Size = new System.Drawing.Size(75, 23);
            this.NewEmployeeBackButton.TabIndex = 9;
            this.NewEmployeeBackButton.Text = "Cancel";
            this.NewEmployeeBackButton.UseVisualStyleBackColor = true;
            this.NewEmployeeBackButton.Click += new System.EventHandler(this.NewEmployeeBackButton_Click);
            // 
            // AddNewEmployeeButton
            // 
            this.AddNewEmployeeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddNewEmployeeButton.Location = new System.Drawing.Point(12, 277);
            this.AddNewEmployeeButton.Name = "AddNewEmployeeButton";
            this.AddNewEmployeeButton.Size = new System.Drawing.Size(191, 23);
            this.AddNewEmployeeButton.TabIndex = 8;
            this.AddNewEmployeeButton.Text = "Add new employee";
            this.AddNewEmployeeButton.UseVisualStyleBackColor = true;
            this.AddNewEmployeeButton.Click += new System.EventHandler(this.AddNewEmployeeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Date of birthday:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Position:";
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
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Employee";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "Phone:";
            // 
            // AddNewEmployeeGenderValue
            // 
            this.AddNewEmployeeGenderValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddNewEmployeeGenderValue.FormattingEnabled = true;
            this.AddNewEmployeeGenderValue.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.AddNewEmployeeGenderValue.Location = new System.Drawing.Point(128, 250);
            this.AddNewEmployeeGenderValue.Name = "AddNewEmployeeGenderValue";
            this.AddNewEmployeeGenderValue.Size = new System.Drawing.Size(155, 21);
            this.AddNewEmployeeGenderValue.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 48;
            this.label9.Text = "Gender:";
            // 
            // AddNewEmployeePositionValue
            // 
            this.AddNewEmployeePositionValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddNewEmployeePositionValue.FormattingEnabled = true;
            this.AddNewEmployeePositionValue.Items.AddRange(new object[] {
            "Administrator",
            "Worker"});
            this.AddNewEmployeePositionValue.Location = new System.Drawing.Point(128, 136);
            this.AddNewEmployeePositionValue.Name = "AddNewEmployeePositionValue";
            this.AddNewEmployeePositionValue.Size = new System.Drawing.Size(155, 21);
            this.AddNewEmployeePositionValue.TabIndex = 3;
            // 
            // AddNewEmployeeNameValue
            // 
            this.AddNewEmployeeNameValue.Location = new System.Drawing.Point(128, 72);
            this.AddNewEmployeeNameValue.Name = "AddNewEmployeeNameValue";
            this.AddNewEmployeeNameValue.Size = new System.Drawing.Size(155, 20);
            this.AddNewEmployeeNameValue.TabIndex = 1;
            // 
            // AddNewEmployeeSurnameValue
            // 
            this.AddNewEmployeeSurnameValue.Location = new System.Drawing.Point(128, 104);
            this.AddNewEmployeeSurnameValue.Name = "AddNewEmployeeSurnameValue";
            this.AddNewEmployeeSurnameValue.Size = new System.Drawing.Size(155, 20);
            this.AddNewEmployeeSurnameValue.TabIndex = 2;
            // 
            // AddNewEmployeeDateValue
            // 
            this.AddNewEmployeeDateValue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AddNewEmployeeDateValue.Location = new System.Drawing.Point(128, 168);
            this.AddNewEmployeeDateValue.Name = "AddNewEmployeeDateValue";
            this.AddNewEmployeeDateValue.Size = new System.Drawing.Size(155, 20);
            this.AddNewEmployeeDateValue.TabIndex = 4;
            // 
            // AddNewEmployeePhoneValue
            // 
            this.AddNewEmployeePhoneValue.Location = new System.Drawing.Point(128, 197);
            this.AddNewEmployeePhoneValue.Name = "AddNewEmployeePhoneValue";
            this.AddNewEmployeePhoneValue.Size = new System.Drawing.Size(155, 20);
            this.AddNewEmployeePhoneValue.TabIndex = 5;
            // 
            // AddNewEmployeeEmailValue
            // 
            this.AddNewEmployeeEmailValue.Location = new System.Drawing.Point(128, 224);
            this.AddNewEmployeeEmailValue.Name = "AddNewEmployeeEmailValue";
            this.AddNewEmployeeEmailValue.Size = new System.Drawing.Size(155, 20);
            this.AddNewEmployeeEmailValue.TabIndex = 6;
            // 
            // AddNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 317);
            this.Controls.Add(this.AddNewEmployeeEmailValue);
            this.Controls.Add(this.AddNewEmployeePhoneValue);
            this.Controls.Add(this.AddNewEmployeeDateValue);
            this.Controls.Add(this.AddNewEmployeeSurnameValue);
            this.Controls.Add(this.AddNewEmployeeNameValue);
            this.Controls.Add(this.AddNewEmployeePositionValue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddNewEmployeeGenderValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NewEmployeeBackButton);
            this.Controls.Add(this.AddNewEmployeeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewEmployee";
            this.Text = "Add new employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewEmployeeBackButton;
        private System.Windows.Forms.Button AddNewEmployeeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox AddNewEmployeeGenderValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox AddNewEmployeePositionValue;
        private System.Windows.Forms.TextBox AddNewEmployeeNameValue;
        private System.Windows.Forms.TextBox AddNewEmployeeSurnameValue;
        private System.Windows.Forms.DateTimePicker AddNewEmployeeDateValue;
        private System.Windows.Forms.TextBox AddNewEmployeePhoneValue;
        private System.Windows.Forms.TextBox AddNewEmployeeEmailValue;
    }
}