using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class EditCustomer : Form
    {
        private int id;
        public EditCustomer(int id)
        {
            this.id = id;
            InitializeComponent();
            FillCustomerData(id);
        }

        private void FillCustomerData(int id)
        {
            Collection<Customer> customers;
            customers = new CustomerTable().SelectOrderById(id);
            foreach (Customer customer in customers)
            {
                EditNewCustomerNameValue.Text = customer.Name;
                EditNewCustomerSurnameValue.Text = customer.Surname;
                if (customer.DateOfBirthday == "")
                {
                    EditNewCustomerDateValue.Format = DateTimePickerFormat.Custom;
                    EditNewCustomerDateValue.CustomFormat = " ";
                }
                else
                {
                    EditNewCustomerDateValue.Text = customer.DateOfBirthday;
                }
                EditNewCustomerPhoneValue.Text = customer.Phone;
                EditNewCustomerEmailValue.Text = customer.Email;
            }
        }

        private void AddNewCustomerButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer
            {
                Uid = id,
                Name = EditNewCustomerNameValue.Text,
                Surname = EditNewCustomerSurnameValue.Text,
                DateOfBirthday = EditNewCustomerDateValue.Value.ToString("yyyy-MM-dd"),
                Phone = EditNewCustomerPhoneValue.Text,
                Email = EditNewCustomerEmailValue.Text
            };
            int customerEditRow = new CustomerTable().Edit(customer);
            Close();
        }

        private void EditCustomerBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
