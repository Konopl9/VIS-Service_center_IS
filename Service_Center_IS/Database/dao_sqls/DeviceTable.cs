using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Center_IS.Database.dao_sqls
{
    class DeviceTable
    {
        private static string _sqlShow = "SELECT * FROM device";

        private static string _sqlShowWhereType = "SELECT * FROM device Where type = @type";

        private static string _sqlShowWhereModel = "SELECT * FROM device Where company = @company";
        public Collection<Device> Select()
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlShow);
            SqlDataReader reader = command.ExecuteReader();
            Collection<Device> devices = new Collection<Device>();
            while (reader.Read())
            {
                Device device = new Device();
                int Iid = Convert.ToInt32(reader["iid"]);
                string Type = Convert.ToString(reader["type"]);
                string Company = Convert.ToString(reader["company"]);
                string Model = Convert.ToString(reader["model"]);


                device.Iid = Iid;
                device.Type = Type;
                device.Company = Company;
                device.Model = Model;

                devices.Add(device);
            }

            return devices;
        }

        public Collection<Device> SelectWhereTypeIs(string type)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlShowWhereType);
            command.Parameters.AddWithValue("@type", type);
            SqlDataReader reader = command.ExecuteReader();
            Collection<Device> devices = new Collection<Device>();
            while (reader.Read())
            {
                Device device = new Device();
                int Iid = Convert.ToInt32(reader["iid"]);
                string Type = Convert.ToString(reader["type"]);
                string Company = Convert.ToString(reader["company"]);
                string Model = Convert.ToString(reader["model"]);


                device.Iid = Iid;
                device.Type = Type;
                device.Company = Company;
                device.Model = Model;

                devices.Add(device);
            }

            return devices;
        }

        public Collection<Device> SelectWhereModelIs(string company)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlShowWhereModel);
            command.Parameters.AddWithValue("@company", company);
            SqlDataReader reader = command.ExecuteReader();
            Collection<Device> devices = new Collection<Device>();
            while (reader.Read())
            {
                Device device = new Device();
                int Iid = Convert.ToInt32(reader["iid"]);
                string Type = Convert.ToString(reader["type"]);
                string Company = Convert.ToString(reader["company"]);
                string Model = Convert.ToString(reader["model"]);


                device.Iid = Iid;
                device.Type = Type;
                device.Company = Company;
                device.Model = Model;

                devices.Add(device);
            }

            return devices;
        }
    }
}
