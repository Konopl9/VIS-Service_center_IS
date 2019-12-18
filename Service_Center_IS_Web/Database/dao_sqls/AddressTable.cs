using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Center_IS.Database.dao_sqls
{
    class AddressTable
    {
        private static string _sqlCreate = "EXEC Attach_address @uid, @city, @street, @number, @zip";

        public int Create(Address address)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlCreate);
            command.Parameters.AddWithValue("@uid", address.CustomerUid);
            command.Parameters.AddWithValue("@city", address.City);
            command.Parameters.AddWithValue("@street", address.Street);
            command.Parameters.AddWithValue("@number", address.Number);
            command.Parameters.AddWithValue("@zip", address.Zip);
            int rows = db.ExecuteNonQuery(command);
            return rows;
        }


    }
}
