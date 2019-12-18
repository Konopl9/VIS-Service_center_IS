using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Center_IS.Database.dao_sqls
{
    class CustomerTable : ICustomer
    {

        private static string _sqlCreate = "EXEC Create_customer @name, @surname, @date_of_birthday, @phone, @email";

        private static string _sqlSelectToTable = "Select * from customer";

        private static string _sqlSelectOrderById = "Select uid, name, surname, date_of_birthday, phone, email FROM customer WHERE uid = @uid";

        private static string _sqlEdit =
            "EXEC Edit_customer @uid, @name, @surname, @date_of_birthday, @phone, @email";

        private static string _sqlDelete = "Exec Delete_customer @uid";

        private static string _SelectLastRow = "SELECT TOP 1 uid FROM customer ORDER BY uid DESC";
        public Collection<Customer> Select()
        {
            throw new NotImplementedException();
        }

        public DataTable SelectForTable()
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlSelectToTable);
            SqlDataAdapter sqlDa = new SqlDataAdapter(command);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);

            return dtb1;
        }

        public Collection<Customer> SelectOrderById(int id)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlSelectOrderById);
            command.Parameters.AddWithValue("@uid", id);
            SqlDataReader reader = command.ExecuteReader();
            Collection<Customer> customers = new Collection<Customer>();
            while (reader.Read())
            {
                Customer customer = new Customer();
                string Name = Convert.ToString(reader["name"]);
                string Surname = Convert.ToString(reader["surname"]);
                string DateOfBirthdaty = Convert.ToString(reader["date_of_birthday"]);
                string Phone = Convert.ToString(reader["phone"]);
                string Email = Convert.ToString(reader["email"]);

                customer.Name = Name;
                customer.Surname = Surname;
                customer.DateOfBirthday = DateOfBirthdaty;
                customer.Phone = Phone;
                customer.Email = Email;

                customers.Add(customer);
            }
            return customers;
        }

        internal int lastRowKey()
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_SelectLastRow);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Customer customer = new Customer();
                int uid = Convert.ToInt32(reader["uid"]);
                customer.Uid = uid;
                return uid;
            }

            return 0;
        }

        public int Create(Customer customer)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlCreate);
            command.Parameters.AddWithValue("@name", customer.Name);
            command.Parameters.AddWithValue("@surname", customer.Surname);
            command.Parameters.AddWithValue("@date_of_birthday", customer.DateOfBirthday);
            command.Parameters.AddWithValue("@phone", customer.Phone);
            command.Parameters.AddWithValue("@email", customer.Email);
            int rows = db.ExecuteNonQuery(command);
            return rows;
        }

        public int Edit(Customer customer)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlEdit);
            command.Parameters.AddWithValue("@uid", customer.Uid);
            command.Parameters.AddWithValue("@name", customer.Name);
            command.Parameters.AddWithValue("@surname", customer.Surname);
            command.Parameters.AddWithValue("@date_of_birthday", customer.DateOfBirthday);
            command.Parameters.AddWithValue("@phone", customer.Phone);
            command.Parameters.AddWithValue("@email", customer.Email ?? (object)DBNull.Value);
            int rows = db.ExecuteNonQuery(command);
            return rows;
        }

        public int Delete(int id)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlDelete);
            command.Parameters.AddWithValue("@uid", id);
            int rows = db.ExecuteNonQuery(command);
            return rows;
        }

        public int Delete()
        {
            throw new NotImplementedException();
        }


    }
}
