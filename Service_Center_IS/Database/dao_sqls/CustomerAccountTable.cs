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
    }
}
