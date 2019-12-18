using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Center_IS.Database.dao_sqls
{
    public class CustomerAccountTable
    {
        private static string _sqlAddCustomerAccount = "Exec Create_customer_Account";
        
        private static string _sqlSignUp = "SELECT count(login) as count FROM customer_account WHERE login = @login AND password = @password";

        private static string _sqlCheckCurrentPassword = "SELECT password FROM customer_account WHERE login = @login";

        private string _sqlChangePassword = "UPDATE customer_account SET password = @password WHERE login = @login";

        public static int SignUp(CustomerAccount customerAccount)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlSignUp);
            command.Parameters.AddWithValue("@login", customerAccount.Login);
            command.Parameters.AddWithValue("@password", customerAccount.Password);
            SqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                i = Convert.ToInt32(reader["count"]);
            }
            db.Close();
            return i;
        }
        public static int AddCustomerAccount()
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlAddCustomerAccount);
            int rows = db.ExecuteNonQuery(command);
            return rows;
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
