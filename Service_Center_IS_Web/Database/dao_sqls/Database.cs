using System;
using System.Data.SqlClient;

namespace Service_Center_IS.Database.dao_sqls
{
    public class Database
    {
        private SqlConnection Connection { get; set; }

        public Database()
        {
            Connection = new SqlConnection
            {
                ConnectionString =
                    "data source = (local);initial catalog = VIS; Integrated Security=True;"
            };
            Connection.Open();
        }

        public SqlCommand CreateCommand(string strCommand)
        {
            SqlCommand command = new SqlCommand(strCommand, Connection);
            return command;
        }

        public int ExecuteNonQuery(SqlCommand command)
        {
            int rowNumber;
            try
            {
                rowNumber = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }

            return rowNumber;
        }

        public void Close()
        {
            Connection.Close();
        }
    }
}