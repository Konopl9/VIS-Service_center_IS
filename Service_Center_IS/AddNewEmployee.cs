using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service_Center_IS.Database;
using Service_Center_IS.Database.dao_sqls;
using EmployeeAccount = Service_Center_IS.Database.EmployeeAccount;

namespace Service_Center_IS
{
    public partial class AddNewEmployee : Form
    {
        public AddNewEmployee()
        {
            InitializeComponent();
        }

        private void AddNewEmployeeButton_Click(object sender, EventArgs e)
        {
            if (CheckFormFill())
            {
                Worker worker = new Worker
                {
                    Name = AddNewEmployeeNameValue.Text,
                    Surname = AddNewEmployeeSurnameValue.Text,
                    Position = AddNewEmployeePositionValue.Text,
                    DateOfBirthday = AddNewEmployeeDateValue.Text,
                    Phone = AddNewEmployeePhoneValue.Text,
                    Email = AddNewEmployeeEmailValue.Text,
                    Gender = AddNewEmployeeGenderValue.Text,
                    Salary = 5000,
                    Points = 0,
                    QualificationLevel = 1

                };
                int employeeRowAdded = new WorkerTable().Create(worker);
                int accountRow = EmployeeAccountTable.AddEmployerAccount();
                if (accountRow == 1)
                {

                    MessageBox.Show(@"Employee was added." + Environment.NewLine + @"Employee login is: "
                                    + AddNewEmployeeSurnameValue.Text.Substring(0, 4)
                                    + AddNewEmployeeNameValue.Text.Substring(0, 2)
                                    + Environment.NewLine + @"Password is: password."
                                    + Environment.NewLine + @"You can change password in your profile."
                    );
                }
                else
                {
                    MessageBox.Show(@"Employee with this login already exist");
                }
                if (employeeRowAdded == 1 && accountRow == -1)
                {
                    new WorkerTable().Delete(new WorkerTable().lastRowKey());
                }
                Close();
            }
            else
            {
                MessageBox.Show(@"Please, fill all fields");
            }
            
        }

        private bool CheckFormFill()
        {
            return AddNewEmployeeNameValue.Text.Length > 0 &&
                   AddNewEmployeeSurnameValue.Text.Length > 0 &&
                   AddNewEmployeePositionValue.Text.Length > 0 &&
                   AddNewEmployeeDateValue.Text.Length > 0 &&
                   AddNewEmployeePhoneValue.Text.Length > 0 &&
                   AddNewEmployeeEmailValue.Text.Length > 0 &&
                   AddNewEmployeeGenderValue.Text.Length > 0;
        }

        private void NewEmployeeBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
