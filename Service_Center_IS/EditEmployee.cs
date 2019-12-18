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
    public partial class EditEmployee : Form
    {
        private int id;
        public EditEmployee(int id)
        {
            this.id = id;
            InitializeComponent();
            FillEmployeeData(id);
        }
        private void FillEmployeeData(int id)
        {
            Collection<Worker> workers;
            workers = new WorkerTable().SelectOrderById(id);
            foreach (Worker customer in workers)
            {
                EditEmployeeNameValue.Text = customer.Name;
                EditEmployeeSurnameValue.Text = customer.Surname;
                EditEmployeePositionValue.SelectedIndex = DetectPositionState(customer.Position) - 1;
                if (customer.DateOfBirthday == "")
                {
                    EditEmployeeDateValue.Format = DateTimePickerFormat.Custom;
                    EditEmployeeDateValue.CustomFormat = " ";
                }
                else
                {
                    EditEmployeeDateValue.Text = customer.DateOfBirthday;
                }
                EditEmployeePhoneValue.Text = customer.Phone;
                EditEmployeeEmailValue.Text = customer.Email;
                EditEmployeeGenderValue.SelectedIndex = DetectGenderState(customer.Gender) - 1;
            }
        }

        private int DetectGenderState(string status)
        {
            switch (status)
            {
                case "Male":
                    return 1;
                case "Female":
                    return 2;
                default:
                    return 1;
            }

        }

        private int DetectPositionState(string status)
        {
            switch (status)
            {
                case "Administrator":
                    return 1;
                case "Worker":
                    return 2;
                default:
                    return 1;
            }

        }

        private void EditEmployeeButton_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker
            {
                Eid = id,
                Name = EditEmployeeNameValue.Text,
                Surname = EditEmployeeSurnameValue.Text,
                Position = EditEmployeePositionValue.Text,
                DateOfBirthday = EditEmployeeDateValue.Value.ToString("yyyy-MM-dd"),
                Phone = EditEmployeePhoneValue.Text,
                Email = EditEmployeeEmailValue.Text,
                Gender = EditEmployeeGenderValue.Text 
            };
            int customerEditRow = new WorkerTable().Edit(worker);
            Close();
        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {

        }

        private void EditEmployeeBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
