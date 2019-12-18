namespace Service_Center_IS
{
    partial class EmployeeOfTheMonth
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
            this.NameValueLabel = new System.Windows.Forms.Label();
            this.SurnameValueLabel = new System.Windows.Forms.Label();
            this.PointsValueLabel = new System.Windows.Forms.Label();
            this.ConfirmEmployeeOfTheMonth = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SalaryValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameValueLabel
            // 
            this.NameValueLabel.AutoSize = true;
            this.NameValueLabel.Location = new System.Drawing.Point(12, 9);
            this.NameValueLabel.Name = "NameValueLabel";
            this.NameValueLabel.Size = new System.Drawing.Size(38, 13);
            this.NameValueLabel.TabIndex = 0;
            this.NameValueLabel.Text = "Name:";
            // 
            // SurnameValueLabel
            // 
            this.SurnameValueLabel.AutoSize = true;
            this.SurnameValueLabel.Location = new System.Drawing.Point(12, 31);
            this.SurnameValueLabel.Name = "SurnameValueLabel";
            this.SurnameValueLabel.Size = new System.Drawing.Size(52, 13);
            this.SurnameValueLabel.TabIndex = 1;
            this.SurnameValueLabel.Text = "Surname:";
            // 
            // PointsValueLabel
            // 
            this.PointsValueLabel.AutoSize = true;
            this.PointsValueLabel.Location = new System.Drawing.Point(12, 53);
            this.PointsValueLabel.Name = "PointsValueLabel";
            this.PointsValueLabel.Size = new System.Drawing.Size(39, 13);
            this.PointsValueLabel.TabIndex = 2;
            this.PointsValueLabel.Text = "Points:";
            // 
            // ConfirmEmployeeOfTheMonth
            // 
            this.ConfirmEmployeeOfTheMonth.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ConfirmEmployeeOfTheMonth.Location = new System.Drawing.Point(12, 102);
            this.ConfirmEmployeeOfTheMonth.Name = "ConfirmEmployeeOfTheMonth";
            this.ConfirmEmployeeOfTheMonth.Size = new System.Drawing.Size(75, 23);
            this.ConfirmEmployeeOfTheMonth.TabIndex = 1;
            this.ConfirmEmployeeOfTheMonth.Text = "Confirm";
            this.ConfirmEmployeeOfTheMonth.UseVisualStyleBackColor = true;
            this.ConfirmEmployeeOfTheMonth.Click += new System.EventHandler(this.ConfirmEmployeeOfTheMonth_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(93, 102);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // SalaryValueLabel
            // 
            this.SalaryValueLabel.AutoSize = true;
            this.SalaryValueLabel.Location = new System.Drawing.Point(12, 75);
            this.SalaryValueLabel.Name = "SalaryValueLabel";
            this.SalaryValueLabel.Size = new System.Drawing.Size(74, 13);
            this.SalaryValueLabel.TabIndex = 5;
            this.SalaryValueLabel.Text = "Current salary:";
            // 
            // EmployeeOfTheMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 133);
            this.Controls.Add(this.SalaryValueLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.ConfirmEmployeeOfTheMonth);
            this.Controls.Add(this.PointsValueLabel);
            this.Controls.Add(this.SurnameValueLabel);
            this.Controls.Add(this.NameValueLabel);
            this.Name = "EmployeeOfTheMonth";
            this.Text = "EmployeeOfTheMonth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameValueLabel;
        private System.Windows.Forms.Label SurnameValueLabel;
        private System.Windows.Forms.Label PointsValueLabel;
        private System.Windows.Forms.Button ConfirmEmployeeOfTheMonth;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label SalaryValueLabel;
    }
}