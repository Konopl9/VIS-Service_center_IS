namespace Service_Center_IS
{
    partial class LoginForm
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
            this.LoginValue = new System.Windows.Forms.TextBox();
            this.PasswordValue = new System.Windows.Forms.TextBox();
            this.LoginTitleLabel = new System.Windows.Forms.Label();
            this.PasswordTitleLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.AppTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginValue
            // 
            this.LoginValue.Location = new System.Drawing.Point(79, 75);
            this.LoginValue.Name = "LoginValue";
            this.LoginValue.Size = new System.Drawing.Size(186, 20);
            this.LoginValue.TabIndex = 1;
            // 
            // PasswordValue
            // 
            this.PasswordValue.Location = new System.Drawing.Point(79, 132);
            this.PasswordValue.Name = "PasswordValue";
            this.PasswordValue.PasswordChar = '*';
            this.PasswordValue.Size = new System.Drawing.Size(186, 20);
            this.PasswordValue.TabIndex = 2;
            // 
            // LoginTitleLabel
            // 
            this.LoginTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LoginTitleLabel.Location = new System.Drawing.Point(79, 40);
            this.LoginTitleLabel.Name = "LoginTitleLabel";
            this.LoginTitleLabel.Size = new System.Drawing.Size(185, 32);
            this.LoginTitleLabel.TabIndex = 3;
            this.LoginTitleLabel.Text = "Login";
            this.LoginTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordTitleLabel
            // 
            this.PasswordTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PasswordTitleLabel.Location = new System.Drawing.Point(81, 97);
            this.PasswordTitleLabel.Name = "PasswordTitleLabel";
            this.PasswordTitleLabel.Size = new System.Drawing.Size(183, 32);
            this.PasswordTitleLabel.TabIndex = 4;
            this.PasswordTitleLabel.Text = "Password";
            this.PasswordTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(79, 171);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(184, 28);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Log in";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // AppTitleLabel
            // 
            this.AppTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppTitleLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.AppTitleLabel.Location = new System.Drawing.Point(81, 8);
            this.AppTitleLabel.Name = "AppTitleLabel";
            this.AppTitleLabel.Size = new System.Drawing.Size(183, 32);
            this.AppTitleLabel.TabIndex = 6;
            this.AppTitleLabel.Text = "Service center";
            this.AppTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 217);
            this.Controls.Add(this.AppTitleLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTitleLabel);
            this.Controls.Add(this.LoginTitleLabel);
            this.Controls.Add(this.PasswordValue);
            this.Controls.Add(this.LoginValue);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppTitleLabel;
        private System.Windows.Forms.TextBox PasswordValue;
        private System.Windows.Forms.TextBox LoginValue;
        private System.Windows.Forms.Label PasswordTitleLabel;
        private System.Windows.Forms.Label LoginTitleLabel;
        private System.Windows.Forms.Button LoginButton;
    }
}

