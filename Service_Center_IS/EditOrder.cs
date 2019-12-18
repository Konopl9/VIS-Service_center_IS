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
    public partial class EditOrder : Form
    {
        private int id;
        private bool isFinishDateChanged = false;
        private bool isFinishHaveDate = false;
        private bool isShipedDateChanged = false;
        private bool isShipedHaveDate = false;
        public EditOrder(int id)
        {
            this.id = id;
            InitializeComponent();
            FillOrderData(id);
        }

        void FillOrderData(int id)
        {
            Collection<Order> orders;
            orders = new OrderTable().SelectOrderById(id);
            foreach (Order order in orders)
            {
                EditOrderStatusValue.SelectedIndex = DetectOrderState(order.Status) - 1;
                if (order.ShippedDate == "")
                {
                    EditShippedOrderDateValue.Format = DateTimePickerFormat.Custom;
                    EditShippedOrderDateValue.CustomFormat = " ";
                }
                else
                {
                    EditShippedOrderDateValue.Text = order.ShippedDate;
                    isShipedHaveDate = true;
                }
                if (order.FinishDate == "")
                {
                    EditFinishOrderDateValue.Format = DateTimePickerFormat.Custom;
                    EditFinishOrderDateValue.CustomFormat = " ";
                }
                else
                {
                    EditFinishOrderDateValue.Text = order.FinishDate;
                    isFinishHaveDate = true;
                }

                
                EditOrderPriceValue.Text = order.Price.ToString();
                EditOrderComplexityValue.Text = order.Complexity.ToString();
                EditOrderDefectValue.Text = order.Defect;
            }

        }

        private int DetectOrderState(string status)
        {
            switch (status)
            {
                case "Not payed":
                    return 1;
                case "Free":
                    return 2;
                case "In progress":
                    return 3;
                case "Finished":
                    return 4;
                default:
                    return 1;
            }

        }

        private void NewOrderBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditOrderButton_Click(object sender, EventArgs e)
        {
            if (!isFinishDateChanged && !isFinishHaveDate)
            {
                Order order = new Order
                {
                    Oid = id,
                    Status = EditOrderStatusValue.Text,
                    ShippedDate = EditShippedOrderDateValue.Value.ToString("yyyy-MM-dd"),
                    FinishDate = null,
                    Price = Int32.Parse(EditOrderPriceValue.Text),
                    Complexity = Int32.Parse(EditOrderComplexityValue.Text),
                    Defect = EditOrderDefectValue.Text
                };
                int orderEditrow = OrderTable.Edit(order);
            }
            else
                {
                    Order order = new Order
                    {
                        Oid = id,
                        Status = EditOrderStatusValue.Text,
                        ShippedDate = EditShippedOrderDateValue.Value.ToString("yyyy-MM-dd"),
                        FinishDate = EditFinishOrderDateValue.Value.ToString("yyyy-MM-dd"),
                        Price = Int32.Parse(EditOrderPriceValue.Text),
                        Complexity = Int32.Parse(EditOrderComplexityValue.Text),
                        Defect = EditOrderDefectValue.Text
                    };
                    int orderEditrow = OrderTable.Edit(order);
            }
            
            Close();
        }

        private void EditShippedOrderDateValue_ValueChanged(object sender, EventArgs e)
        {
            if (EditShippedOrderDateValue.Format == DateTimePickerFormat.Custom && EditShippedOrderDateValue.CustomFormat == " ")
                EditShippedOrderDateValue.Format = DateTimePickerFormat.Short;
            isShipedDateChanged = true;
        }

        private void EditFinishOrderDateValue_ValueChanged(object sender, EventArgs e)
        {
            if (EditFinishOrderDateValue.Format == DateTimePickerFormat.Custom && EditFinishOrderDateValue.CustomFormat == " ")
                EditFinishOrderDateValue.Format = DateTimePickerFormat.Short;
            isFinishDateChanged = true;

        }

        private void EditOrderPriceValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void EditOrderComplexityValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
