using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service_Center_IS.Database;
using Service_Center_IS.Database.dao_sqls;

namespace Service_Center_IS
{
    public partial class AddNewCustomer : Form
    {
        public AddNewCustomer()
        {
            InitializeComponent();
        }

        private void AddNewCustomerButton_Click(object sender, EventArgs e)
        {
            if (CheckIfFieldAreNotEmpty())
            {
                Regex mRegxExpression;
                if (AddNewCustomerEmailValue.Text.Trim() != string.Empty)
                {
                    mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                    if (!mRegxExpression.IsMatch(AddNewCustomerEmailValue.Text.Trim()))
                    {
                        MessageBox.Show("E-mail address format is not correct.", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AddNewCustomerEmailValue.Focus();
                    }
                    else
                    {
                        Customer customer = new Customer
                        {
                            Name = AddNewCustomerNameValue.Text,
                            Surname = AddNewCustomerSurnameValue.Text,
                            DateOfBirthday = AddNewCustomerDateValue.Text,
                            Phone = AddNewCustomerPhoneValue.Text,
                            Email = AddNewCustomerEmailValue.Text
                        };
                        int customerRowAdded = new CustomerTable().Create(customer);
                        int accountRow = CustomerAccountTable.AddCustomerAccount();
                        if (accountRow == 1)
                        {

                            MessageBox.Show(@"Customer was added." + Environment.NewLine + @"Customer login is: "
                                            + AddNewCustomerSurnameValue.Text.Substring(0, 4)
                                            + AddNewCustomerNameValue.Text.Substring(0, 2)
                                            + Environment.NewLine + @"Password is: password."
                                            + Environment.NewLine + @"You can change password in your profile."
                            );
                            Close();
                        }
                        else
                        {
                            MessageBox.Show(@"Customer with this login already exist");
                        }
                        if (customerRowAdded == 1 && accountRow == -1)
                        {
                            new CustomerTable().Delete(new CustomerTable().lastRowKey());
                        }
                    }
                }
                


            }
            else
            {
                MessageBox.Show(@"Please, fill all fields");
            }
            
        }

        private bool CheckIfFieldAreNotEmpty()
        {
            return AddNewCustomerNameValue.Text.Length != 0
                   && AddNewCustomerSurnameValue.Text.Length != 0
                   && AddNewCustomerDateValue.Text.Length != 0
                   && AddNewCustomerPhoneValue.Text.Length != 0
                   && AddNewCustomerEmailValue.Text.Length != 0;
        }
    }
}
