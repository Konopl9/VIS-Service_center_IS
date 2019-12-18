using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service_Center_IS.Database.dao_sqls;

namespace Service_Center_IS
{
    public partial class ChangePassword : Form
    {
        private string login;
        public ChangePassword(string login)
        {
            this.login = login;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (new EmployeeAccountTable().CheckCurrentPassword(login) == currentPasswordValue.Text)
            {
                if (NewPasswordValue.Text == RepeatPasswordValue.Text)
                {
                    if (NewPasswordValue.Text.Length >= 8)
                    {
                        int i = new EmployeeAccountTable().ChangePassword(login, NewPasswordValue.Text);
                        if (i == 1)
                        {
                            MessageBox.Show(@"Password was changed!");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show(@"Something went wrong!");
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Password length must be longer than 8!");
                    }
                }
                else
                {
                    MessageBox.Show(@"Password don't match!");
                }
            }
            else
            {
                MessageBox.Show(@"Current password is wrong!");
            }
        }
    }
}
