using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Service_Center_IS.Database;
using Service_Center_IS.Database.dao_sqls;

namespace Service_Center_IS
{
    public partial class AdministrationForm : Form
    {
        private int id;
        private InvoiceData invoiceData;

        public AdministrationForm()
        {
            InitializeComponent();
            FillCombo();
            FillDataGridView(OrderTable.SelectForOrderTable());
        }

        void FillDataGridView(DataTable data)
        {
            dataGridView1.DataSource = data;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show(@"No data in database for this parameters", @"Table",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FillCombo()
        {
            Collection<Worker> workers;
            workers = new WorkerTable().Select();
            foreach (Worker worker in workers)
            {
                SearchOrderByWorkerValue.Items.Add(worker.Surname);
            }
        }

        private void EditChosenOrderButton_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                EditOrder order = new EditOrder(id)
                {
                    Owner = this,
                    FormBorderStyle = FormBorderStyle.FixedSingle,
                    MaximizeBox = false
                };
                order.ShowDialog();
                if (order.DialogResult == DialogResult.OK)
                {
                    FillDataGridView(OrderTable.SelectForOrderTable());
                }
            }
            else
            {
                MessageBox.Show(@"Please, choose some order");
            }
        }

        private void AddNewCustomerButton_Click(object sender, EventArgs e)
        {
            AddNewCustomer customerForm = new AddNewCustomer
            {
                Owner = this, FormBorderStyle = FormBorderStyle.FixedSingle, MaximizeBox = false
            };
            customerForm.ShowDialog();
            if (customerForm.DialogResult == DialogResult.OK)
            {
                FillDataGridView(new CustomerTable().SelectForTable());
            }
        }

        private void EditChosenCustomerButton_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                EditCustomer editCustomerForm = new EditCustomer(id)
                {
                    Owner = this,
                    FormBorderStyle = FormBorderStyle.FixedSingle,
                    MaximizeBox = false
                };
                editCustomerForm.ShowDialog();
                if (editCustomerForm.DialogResult == DialogResult.OK)
                {
                    FillDataGridView(new CustomerTable().SelectForTable());
                }
            }
            else
            {
                MessageBox.Show(@"Please, select order!");
            }
        }

        private void AddAddressChosenCustomerButton_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                AddAddressToCustomer addressForm = new AddAddressToCustomer(id)
                {
                    Owner = this,
                    FormBorderStyle = FormBorderStyle.FixedSingle,
                    MaximizeBox = false
                };
                addressForm.ShowDialog();
            }
            else
            {
                MessageBox.Show(@"Please, select order!");
            }

        }

        private void CreateNewOrderToChosenCustomerButton_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                AddNewOrder orderForm = new AddNewOrder(id)
                {
                    Owner = this,
                    FormBorderStyle = FormBorderStyle.FixedSingle,
                    MaximizeBox = false
                };
                orderForm.ShowDialog();
            }
            else
            {
                MessageBox.Show(@"Please, select order!");
            }

        }

        private void AddNewEmployeeButton_Click(object sender, EventArgs e)
        {
            AddNewEmployee employeeForm = new AddNewEmployee
            {
                Owner = this,
                FormBorderStyle = FormBorderStyle.FixedSingle,
                MaximizeBox = false
            };
            employeeForm.ShowDialog();
            if (employeeForm.DialogResult == DialogResult.OK)
            {
                FillDataGridView(new EmployeeTable().SelectForTable());
            }
        }

        private void EditChosenEmployeeButton_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                EditEmployee editEmployeeForm = new EditEmployee(id)
                {
                    Owner = this,
                    FormBorderStyle = FormBorderStyle.FixedSingle,
                    MaximizeBox = false
                };
                editEmployeeForm.ShowDialog();
                if (editEmployeeForm.DialogResult == DialogResult.OK)
                {
                    FillDataGridView(new EmployeeTable().SelectForTable());
                }
            }
            else
            {
                MessageBox.Show(@"Please, select order!");
            }

        }

        private void SearchOrderByIdValue_Enter(object sender, EventArgs e)
        {
            if (SearchOrderByIdValue.Text == @"Order id")
            {
                SearchOrderByIdValue.Text = "";

                SearchOrderByIdValue.ForeColor = Color.Black;
            }
        }

        private void SearchOrderByIdValue_Leave(object sender, EventArgs e)
        {
            if (SearchOrderByIdValue.Text == "")
            {
                SearchOrderByIdValue.Text = @"Order id";

                SearchOrderByIdValue.ForeColor = Color.Silver;
            }
        }

        private void SearchOrderByNameValue_Enter(object sender, EventArgs e)
        {
            if (SearchOrderByNameValue.Text == @"Name")
            {
                SearchOrderByNameValue.Text = "";

                SearchOrderByNameValue.ForeColor = Color.Black;
            }
        }

        private void SearchOrderByNameValue_Leave(object sender, EventArgs e)
        {
            if (SearchOrderByNameValue.Text == "")
            {
                SearchOrderByNameValue.Text = @"Name";

                SearchOrderByNameValue.ForeColor = Color.Silver;
            }
        }

        private void SearchOrderBySurnameValue_Enter(object sender, EventArgs e)
        {
            if (SearchOrderBySurnameValue.Text == @"Surname")
            {
                SearchOrderBySurnameValue.Text = "";

                SearchOrderBySurnameValue.ForeColor = Color.Black;
            }
        }

        private void SearchOrderBySurnameValue_Leave(object sender, EventArgs e)
        {
            if (SearchOrderBySurnameValue.Text == "")
            {
                SearchOrderBySurnameValue.Text = @"Surname";

                SearchOrderBySurnameValue.ForeColor = Color.Silver;
            }
        }

        private void SearchOrderByIdButton_Click(object sender, EventArgs e)
        {
            if (SearchOrderByIdValue.Text == @"Order id") SearchOrderByIdValue.Clear();
            if (!string.IsNullOrWhiteSpace(SearchOrderByIdValue.Text))
            {
                Order order = new Order
                {
                    Oid = Int32.Parse(SearchOrderByIdValue.Text)
                };
                FillDataGridView(OrderTable.SelectForOrderTableById(order));
            }
        }

        //Block write number
        private void SearchOrderByIdValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void SearchOrderByDataButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                Name = SearchOrderByNameValue.Text,
                Surname = SearchOrderBySurnameValue.Text
            };
            FillDataGridView(OrderTable.SelectForOrderTableByNameAndSurname(customer));
        }


        private void SearchOrderByDateButton_Click(object sender, EventArgs e)
        {
            Order order = new Order()
            {
                OrderDate = SearchOrderByDateFromValue.Value.ToString()
            };
            Order order1 = new Order()
            {
                OrderDate = SearchOrderByDateToValue.Value.ToString()
            };
            FillDataGridView(OrderTable.SelectForOrderTableByDate(order, order1));
        }

        private void SearchOrderByWorkerButton_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker()
            {
                Surname = SearchOrderByWorkerValue.Text
            };
            FillDataGridView(OrderTable.SelectForOrderTableByWorker(worker));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow dataGridView = dataGridView1.Rows[index];
            this.id = Int32.Parse(dataGridView.Cells[0].Value.ToString());
        }

        private void DeleteChosenOrderButton_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                OrderTable.DeleteOrderById(id);
                FillDataGridView(OrderTable.SelectForOrderTable());
            }
            else
            {
                MessageBox.Show(@"Please, select order");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                {
                    FillDataGridView(OrderTable.SelectForOrderTable());

                }
                    break;
                case 1:
                {
                    FillDataGridView(new CustomerTable().SelectForTable()); 

                }
                    break;
                case 2:
                {
                    FillDataGridView(new EmployeeTable().SelectForTable());
                }
                    break;
            }
        }

        private void DeleteChosenCustomerButton_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                new CustomerTable().Delete(id);
                FillDataGridView(new CustomerTable().SelectForTable());
            }
            else
            {
                MessageBox.Show(@"Please, select order");
            }

        }

        private void DeleteChosenEmployeeButton_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                new WorkerTable().Delete(id);
                FillDataGridView(new EmployeeTable().SelectForTable());
            }
            else
            {
                MessageBox.Show(@"Please, select order");
            }

        }

        private void ShowSalaryButton_Click(object sender, EventArgs e)
        {
            FillDataGridView(new EmployeeTable().SelectForTableSalary());
        }

        private void UpEmployeeQualification_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                Collection<Worker> workers = new WorkerTable().Select();
                foreach (var worker in workers)
                {
                    if (worker.Eid == id)
                    {
                        if (worker.QualificationLevel == null)
                        {
                            Worker chosenworker = new Worker
                            {
                                Eid = id,
                                QualificationLevel = 1
                            };
                            new WorkerTable().IncreaseQualification(chosenworker);
                        }
                        else
                        {
                            Worker chosenworker = new Worker
                            {
                                Eid = id,
                                QualificationLevel = worker.QualificationLevel + 1
                            };
                            new WorkerTable().IncreaseQualification(chosenworker);
                        }

                        FillDataGridView(new EmployeeTable().SelectForTableSalary());
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Please, select order");
            }
            
        }

        private void ShowEmployeeOfTheMonth_Click(object sender, EventArgs e)
        {
            EmployeeOfTheMonth editEmployeeForm = new EmployeeOfTheMonth
            {
                Owner = this,
                FormBorderStyle = FormBorderStyle.FixedSingle,
                MaximizeBox = false
            };
            editEmployeeForm.ShowDialog();
            if (editEmployeeForm.DialogResult == DialogResult.OK)
            {
                FillDataGridView(new EmployeeTable().SelectForTable());
            }
        }

        private void InvoceForChosenOrderButton_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show(@"Please choose order:");
            }
            else
            {
                printDialog1.Document = printDocument1;
                DialogResult result = printDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //get data
            invoiceData = new OrderTable().GetDataForInvoice(id);
            //draw
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier new", 14);
            float FontHeight = font.GetHeight();
            int startx = 70;
            int starty = 40;
            int offset = 30;
            float leftmargin = e.MarginBounds.Left;
            float topmargin = e.MarginBounds.Top;
            graphics.DrawString("WELCOME TO VIS SERVICE CENTER", new Font("Courier new", 20), new SolidBrush(Color.Black), startx, starty );
            string top = "Date:" + DateTime.Now.ToString().PadRight(5);
            graphics.DrawString(top, font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + (int) FontHeight;
            graphics.DrawString("For customer:" + invoiceData.CustomerName + " " + invoiceData.CustomerSurname, font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + (int)FontHeight;
            graphics.DrawString("--------------------------------------------------------", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 30;
            graphics.DrawString("Order id\tOrder date\tShipped date\tFinish date\tPrice", font, new SolidBrush(Color.Black), startx, starty+offset );
            offset = offset + 30;
            graphics.DrawString(id + "\t\t   " + invoiceData.OrderOrderDate + "     " + invoiceData.OrderShippedDate + "\t " + invoiceData.OrderFinishedDate + "     " + invoiceData.OrderPrice, new Font("courier New", 12), new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + (int)FontHeight;
            graphics.DrawString("--------------------------------------------------------", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 30;
            graphics.DrawString("Type\tCompany\tModel\tDefect", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 30;
            graphics.DrawString(invoiceData.DeviceType + "\t " + invoiceData.DeviceCompany + "\t\t   " + invoiceData.DeviceModel + "\t     " + invoiceData.OrderDefect, new Font("courier New", 12), new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + (int) FontHeight;
            graphics.DrawString("--------------------------------------------------------", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 30;
            graphics.DrawString("Employee \tName\t    Surname\t     Qualification", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 30;
            graphics.DrawString("\t\t  " + invoiceData.EmployeeName + "\t " + invoiceData.EmployeeSurname + "\t\t" + invoiceData.EmployeeQualificationLevel, new Font("courier New", 12), new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + (int)FontHeight;
            graphics.DrawString("--------------------------------------------------------", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 30;
            graphics.DrawString("To pay:" + invoiceData.OrderPrice + "$", font, new SolidBrush(Color.Black), startx, starty + offset);
        }
    }
}