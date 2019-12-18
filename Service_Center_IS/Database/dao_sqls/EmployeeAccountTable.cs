using System;
using System.Data.SqlClient;

namespace Service_Center_IS.Database.dao_sqls
{
    public class EmployeeAccountTable
    {
        private static string _sqlAddEmployeeAccount = "Exec Create_employee_Account";

        private static string _sqlSignUp =
            "SELECT count(login) as count FROM employee_account WHERE login = @login AND password = @password";

        private static string _sqlGetPosition = "SELECT position FROM employee_account JOIN employee e on employee_account.employee_eid = e.eid WHERE login = @login";

        private static string _sqlCheckCurrentPassword = "SELECT password FROM employee_account WHERE login = @login";

        private string _sqlChangePassword = "UPDATE employee_account SET password = @password WHERE login = @login";

        public static int AddEmployerAccount()
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlAddEmployeeAccount);
            int rows = db.ExecuteNonQuery(command);
            return rows;
        }

        public static int SignUp(EmployeeAccount employee)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlSignUp);
            command.Parameters.AddWithValue("@login", employee.Login);
            command.Parameters.AddWithValue("@password", employee.Password);
            SqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                i = Convert.ToInt32(reader["count"]);
            }
            db.Close();
            return i;
        }

        public static string getPosition(EmployeeAccount employeeAccount)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlGetPosition);
            command.Parameters.AddWithValue("@login", employeeAccount.Login);
            SqlDataReader reader = command.ExecuteReader();
            string position = null;
            while (reader.Read())
            {
                position = Convert.ToString(reader["position"]);
            }
            db.Close();
            return position;
        }

        public string CheckCurrentPassword(string login)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlCheckCurrentPassword);
            command.Parameters.AddWithValue("@login", login);
            SqlDataReader reader = command.ExecuteReader();
            string password = null;
            while (reader.Read())
            {
                password = Convert.ToString(reader["password"]);
            }
            db.Close();
            return password;
        }

        public int ChangePassword(string login, string password)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlChangePassword);
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@password", password);
            int rows = db.ExecuteNonQuery(command);
            return rows;
        }
    }
}