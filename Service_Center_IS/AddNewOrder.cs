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
    public partial class AddNewOrder : Form
    {
        private int id;
        public AddNewOrder(int id)
        {
            this.id = id;
            InitializeComponent();
            FillDeviceTypeCombo();
        }

        void FillDeviceTypeCombo()
        {
            Collection<Device> devices;
            devices = new DeviceTable().Select();
            foreach (Device device in devices)
            {
                if (!AddDeviceToOrderTypeValue.Items.Contains(device.Type))
                {
                    AddDeviceToOrderTypeValue.Items.Add(device.Type);
                }
                
            }

        }

        void FillDeviceCompanyCombo()
        {
            Collection<Device> devices;
            devices = new DeviceTable().SelectWhereTypeIs(AddDeviceToOrderTypeValue.Text);
            foreach (Device device in devices)
            {
                if (!AddDeviceToOrderCompanyValue.Items.Contains(device.Company))
                {
                    AddDeviceToOrderCompanyValue.Items.Add(device.Company);
                }

            }

        }

        void FillDeviceModelCombo()
        {
            Collection<Device> devices;
            devices = new DeviceTable().SelectWhereModelIs(AddDeviceToOrderCompanyValue.Text);
            foreach (Device device in devices)
            {
                if (!AddDeviceToOrderModelValue.Items.Contains(device.Model))
                {
                    AddDeviceToOrderModelValue.Items.Add(device.Model);
                }

            }

        }


        private void AddNewOrderButton_Click(object sender, EventArgs e)
        {
            if (ChekcIfFieldsAreNotEmpty())
            {
                Order order = new Order
                {
                    Status = AddOrderStatusValue.Text,
                    OrderDate = AddOrderDateValue.Text,
                    ShippedDate = null,
                    FinishDate = null,
                    Price = Int32.Parse(AddOrderPriceValue.Text),
                    Complexity = Int32.Parse(AddOrderComplexityValue.Text),
                    Defect = AddOrderDefectValue.Text,
                    EmployeeEid = null,
                    CustomerUid = id
                };
                Device device = new Device
                {
                    Type = AddDeviceToOrderTypeValue.Text,
                    Company = AddDeviceToOrderCompanyValue.Text,
                    Model = AddDeviceToOrderModelValue.Text
                };
                int customerRowAdded = new OrderTable().Create(order, device);
                if (customerRowAdded == 1)
                {
                    MessageBox.Show(@"Order was added");
                }
                Close();
            }
            else
            {
                MessageBox.Show(@"Please, fill all fields");

            }
            

        }

        private bool ChekcIfFieldsAreNotEmpty()
        {
            return AddOrderStatusValue.Text.Length > 0 &&
                   AddOrderDateValue.Text.Length > 0 &&
                   AddOrderPriceValue.Text.Length > 0 &&
                   AddOrderComplexityValue.Text.Length > 0 &&
                   AddOrderDefectValue.Text.Length > 0;

        }

        private void AddDeviceToOrderTypeValue_SelectedValueChanged(object sender, EventArgs e)
        {
            FillDeviceCompanyCombo();
        }

        private void AddDeviceToOrderCompanyValue_SelectedValueChanged(object sender, EventArgs e)
        {
            FillDeviceModelCombo();
        }

        private void AddOrderPriceValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void AddOrderComplexityValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
