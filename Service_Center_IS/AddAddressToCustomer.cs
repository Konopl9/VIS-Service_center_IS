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
    public partial class AddAddressToCustomer : Form
    {
        private int id;
        public AddAddressToCustomer(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void AddNewAddressButton_Click(object sender, EventArgs e)
        {
            if (CheckIfFieldAreNotEmpty())
            {
                Address address = new Address
                {
                    City = AddNewAddressCityValue.Text,
                    Street = AddNewAddressStreetValue.Text,
                    Number = AddNewAddressNumberValue.Text,
                    Zip = Int32.Parse(AddNewAddressZipValue.Text),
                    CustomerUid = id
                };
                int customerRowAdded = new AddressTable().Create(address);
                if (customerRowAdded == 1)
                {
                    MessageBox.Show(@"Address was added");
                }
                else
                {
                    MessageBox.Show(@"Customer already have address");
                }
                Close();
            }
            else
            {
                MessageBox.Show("Please, fill all fields");
            }
            
        }

        private bool CheckIfFieldAreNotEmpty()
        {
            return AddNewAddressCityValue.Text.Length > 0 && AddNewAddressStreetValue.Text.Length > 0 &&
                   AddNewAddressNumberValue.Text.Length > 0 && AddNewAddressZipValue.Text.Length > 0;
        }

        private void AddAddressBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddNewAddressZipValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
