using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service_Center_IS.Database;
using Service_Center_IS.Database.dao_sqls;

namespace Service_Center_IS
{
    public partial class LoginForm : Form
    {
        private string login;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Login
            EmployeeAccount employee = new EmployeeAccount
            {
                Login = LoginValue.Text,
                Password = PasswordValue.Text
            };
            int signUpRows = EmployeeAccountTable.SignUp(employee);
            if (signUpRows == 1)
            {
                if (EmployeeAccountTable.getPosition(employee) == "Administrator")
                {
                    AdministrationForm administration = new AdministrationForm();
                    this.Hide();
                    administration.ShowDialog();
                    Close();
                }
                else if (EmployeeAccountTable.getPosition(employee) == "Worker")
                {
                    WorkerForm workerForm = new WorkerForm(employee.Login);
                    this.Hide();
                    workerForm.ShowDialog();
                    Close();
                }
            }
            else
            {
                MessageBox.Show(@"Wrong login or password");
            }

        }
    }
}
