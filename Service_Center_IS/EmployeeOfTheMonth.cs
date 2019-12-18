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
    public partial class EmployeeOfTheMonth : Form
    {
        public EmployeeOfTheMonth()
        {
            InitializeComponent();
            FillEmployerOftheMonth();
        }

        void FillEmployerOftheMonth()
        {
            Collection<Worker> workers;
            workers = new WorkerTable().GetWorkerOfTheMonth();
            if (workers.Count == 1)
            {
                foreach (Worker worker in workers)
                {
                    NameValueLabel.Text = "Name: " + worker.Name;
                    SurnameValueLabel.Text = "Surname: " + worker.Surname;
                    PointsValueLabel.Text = "Points: " + worker.Points.ToString();
                    SalaryValueLabel.Text = "Salary: " + worker.Salary.ToString();
                }
            }
            else
            {
                string name = null, surname = null, points = null, salary = null;
                int i = 0;
                foreach (Worker worker in workers)
                {
                    i++;
                    if (i == workers.Count)
                    {
                        name += worker.Name;
                        surname += worker.Surname;
                        points += worker.Points.ToString();
                        salary += worker.Salary.ToString();
                    }
                    else
                    {
                        name += worker.Name + ", ";
                        surname += worker.Surname + ", ";
                        points += worker.Points + ", ";
                        salary += worker.Salary + ", ";
                    }
                }

                NameValueLabel.Text = "Name: " + name;
                SurnameValueLabel.Text = "Surname: " + surname;
                PointsValueLabel.Text = "Points: " + points;
                SalaryValueLabel.Text = "Salary: " + salary;
            }
        }

        private void ConfirmEmployeeOfTheMonth_Click(object sender, EventArgs e)
        {
            int row = new WorkerTable().IncreaseSalaryForEmployeeOfTheMonth();
            MessageBox.Show(@"Salary was increased for " + row + @" employees");
            Close();
        }
    }
}
