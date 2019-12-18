namespace Service_Center_IS
{
    partial class WorkerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.WorkerNameValue = new System.Windows.Forms.Label();
            this.WorkerSurnameValue = new System.Windows.Forms.Label();
            this.ShowWorkerOrdersButton = new System.Windows.Forms.Button();
            this.ShowFreeOrderButton = new System.Windows.Forms.Button();
            this.WorkerQualificationValue = new System.Windows.Forms.Label();
            this.WorkerPointsValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.ShowSallaryButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TakeOrderButton = new System.Windows.Forms.Button();
            this.FinishOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(274, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(663, 432);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hello, you logged as a worker. \r\nYour contact information is:\r\n";
            // 
            // WorkerNameValue
            // 
            this.WorkerNameValue.AutoSize = true;
            this.WorkerNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkerNameValue.Location = new System.Drawing.Point(13, 62);
            this.WorkerNameValue.Name = "WorkerNameValue";
            this.WorkerNameValue.Size = new System.Drawing.Size(45, 16);
            this.WorkerNameValue.TabIndex = 2;
            this.WorkerNameValue.Text = "label2";
            // 
            // WorkerSurnameValue
            // 
            this.WorkerSurnameValue.AutoSize = true;
            this.WorkerSurnameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkerSurnameValue.Location = new System.Drawing.Point(13, 91);
            this.WorkerSurnameValue.Name = "WorkerSurnameValue";
            this.WorkerSurnameValue.Size = new System.Drawing.Size(45, 16);
            this.WorkerSurnameValue.TabIndex = 3;
            this.WorkerSurnameValue.Text = "label3";
            // 
            // ShowWorkerOrdersButton
            // 
            this.ShowWorkerOrdersButton.Location = new System.Drawing.Point(12, 201);
            this.ShowWorkerOrdersButton.Name = "ShowWorkerOrdersButton";
            this.ShowWorkerOrdersButton.Size = new System.Drawing.Size(122, 36);
            this.ShowWorkerOrdersButton.TabIndex = 1;
            this.ShowWorkerOrdersButton.Text = "My orders";
            this.ShowWorkerOrdersButton.UseVisualStyleBackColor = true;
            this.ShowWorkerOrdersButton.Click += new System.EventHandler(this.ShowWorkerOrdersButton_Click);
            // 
            // ShowFreeOrderButton
            // 
            this.ShowFreeOrderButton.Location = new System.Drawing.Point(12, 272);
            this.ShowFreeOrderButton.Name = "ShowFreeOrderButton";
            this.ShowFreeOrderButton.Size = new System.Drawing.Size(122, 36);
            this.ShowFreeOrderButton.TabIndex = 3;
            this.ShowFreeOrderButton.Text = "Free orders";
            this.ShowFreeOrderButton.UseVisualStyleBackColor = true;
            this.ShowFreeOrderButton.Click += new System.EventHandler(this.ShowFreeOrderButton_Click);
            // 
            // WorkerQualificationValue
            // 
            this.WorkerQualificationValue.AutoSize = true;
            this.WorkerQualificationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkerQualificationValue.Location = new System.Drawing.Point(13, 120);
            this.WorkerQualificationValue.Name = "WorkerQualificationValue";
            this.WorkerQualificationValue.Size = new System.Drawing.Size(45, 16);
            this.WorkerQualificationValue.TabIndex = 7;
            this.WorkerQualificationValue.Text = "label4";
            // 
            // WorkerPointsValue
            // 
            this.WorkerPointsValue.AutoSize = true;
            this.WorkerPointsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkerPointsValue.Location = new System.Drawing.Point(13, 149);
            this.WorkerPointsValue.Name = "WorkerPointsValue";
            this.WorkerPointsValue.Size = new System.Drawing.Size(45, 16);
            this.WorkerPointsValue.TabIndex = 8;
            this.WorkerPointsValue.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Choose your orders option:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Profile option:";
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(12, 334);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(122, 36);
            this.ChangePasswordButton.TabIndex = 5;
            this.ChangePasswordButton.Text = "Change password";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // ShowSallaryButton
            // 
            this.ShowSallaryButton.Location = new System.Drawing.Point(140, 334);
            this.ShowSallaryButton.Name = "ShowSallaryButton";
            this.ShowSallaryButton.Size = new System.Drawing.Size(122, 36);
            this.ShowSallaryButton.TabIndex = 6;
            this.ShowSallaryButton.Text = "Show salary";
            this.ShowSallaryButton.UseVisualStyleBackColor = true;
            this.ShowSallaryButton.Click += new System.EventHandler(this.ShowSallaryButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Choose free orders option:";
            // 
            // TakeOrderButton
            // 
            this.TakeOrderButton.Location = new System.Drawing.Point(140, 272);
            this.TakeOrderButton.Name = "TakeOrderButton";
            this.TakeOrderButton.Size = new System.Drawing.Size(122, 36);
            this.TakeOrderButton.TabIndex = 4;
            this.TakeOrderButton.Text = "Take order";
            this.TakeOrderButton.UseVisualStyleBackColor = true;
            this.TakeOrderButton.Click += new System.EventHandler(this.TakeOrderButton_Click);
            // 
            // FinishOrderButton
            // 
            this.FinishOrderButton.Location = new System.Drawing.Point(140, 201);
            this.FinishOrderButton.Name = "FinishOrderButton";
            this.FinishOrderButton.Size = new System.Drawing.Size(122, 36);
            this.FinishOrderButton.TabIndex = 2;
            this.FinishOrderButton.Text = "Finish order";
            this.FinishOrderButton.UseVisualStyleBackColor = true;
            this.FinishOrderButton.Click += new System.EventHandler(this.FinishOrderButton_Click);
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 456);
            this.Controls.Add(this.FinishOrderButton);
            this.Controls.Add(this.TakeOrderButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ShowSallaryButton);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.WorkerPointsValue);
            this.Controls.Add(this.WorkerQualificationValue);
            this.Controls.Add(this.ShowFreeOrderButton);
            this.Controls.Add(this.ShowWorkerOrdersButton);
            this.Controls.Add(this.WorkerSurnameValue);
            this.Controls.Add(this.WorkerNameValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WorkerNameValue;
        private System.Windows.Forms.Label WorkerSurnameValue;
        private System.Windows.Forms.Button ShowWorkerOrdersButton;
        private System.Windows.Forms.Button ShowFreeOrderButton;
        private System.Windows.Forms.Label WorkerQualificationValue;
        private System.Windows.Forms.Label WorkerPointsValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Button ShowSallaryButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button TakeOrderButton;
        private System.Windows.Forms.Button FinishOrderButton;
    }
}