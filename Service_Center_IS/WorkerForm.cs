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
    public partial class WorkerForm : Form
    {
        private string login;
        private int id;
        public WorkerForm(string employeeLogin)
        {
            this.login = employeeLogin;
            InitializeComponent();
            FillWorkerData();
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

        void FillWorkerData()
        {
            Collection<Worker> workers;
            workers = new WorkerTable().SelectWorkerByLogin(login);
            foreach (Worker worker in workers)
            {
                WorkerNameValue.Text = @"Name: " + worker.Name;
                WorkerSurnameValue.Text = @"Surname: " + worker.Surname;
                WorkerQualificationValue.Text = @"Qualification level: " + worker.QualificationLevel;
                WorkerPointsValue.Text = @"Points: "  + worker.Points;
            }
        }

        private void ShowWorkerOrdersButton_Click(object sender, EventArgs e)
        {
            FillDataGridView(new OrderTable().SelectWorkerOrders(login));
        }

        private void ShowFreeOrderButton_Click(object sender, EventArgs e)
        {
            FillDataGridView(new OrderTable().SelectFreeOrders(login));
        }

        private void TakeOrderButton_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show(@"Please, choose some order.");
            }
            else
            {
                int i = new OrderTable().TakeOrder(login, id);
                FillDataGridView(new OrderTable().SelectWorkerOrders(login));
                if (i == 1)
                {
                    MessageBox.Show(@"Order was added to your work list");
                }
                else
                {
                    MessageBox.Show(@"Something went wrong");
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow dataGridView = dataGridView1.Rows[index];
            this.id = Int32.Parse(dataGridView.Cells[0].Value.ToString());
        }

        private void FinishOrderButton_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show(@"Please, choose some order.");
            }
            else
            {
                int i = new OrderTable().FinishOrder(login, id);
                FillDataGridView(new OrderTable().SelectWorkerOrders(login));
                FillWorkerData();
                if (i == 7)
                {
                    MessageBox.Show(@"Order was finished and points was added");
                }
            }

        }

        private void ShowSallaryButton_Click(object sender, EventArgs e)
        {
            Collection<Worker> workers = new WorkerTable().SelectWorkerByLogin(login);
            
            MessageBox.Show("Your month salary is: " + workers[0].Salary);
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(login)
            {
                Owner = this,
                FormBorderStyle = FormBorderStyle.FixedSingle,
                MaximizeBox = false
            };
            changePassword.ShowDialog();
        }
    }
}
