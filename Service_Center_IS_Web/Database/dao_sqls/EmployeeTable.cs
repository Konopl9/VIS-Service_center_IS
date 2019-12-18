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
    
    class EmployeeTable : IEmployee<Employee>
    {
        private static string _sqlSelectToTable = "Select eid, name, surname, position, phone, email from employee";

        private static string _sqlSelectToTableSalary = "Select eid, name, surname, sallary, points, qualification_level from employee";

        public Collection<Employee> Select()
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

        public Collection<Employee> SelectOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public int Create(Employee user)
        {
            throw new NotImplementedException();
        }

        public int Edit(Employee user)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectForTableSalary()
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlSelectToTableSalary);
            SqlDataAdapter sqlDa = new SqlDataAdapter(command);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);

            return dtb1;
        }
    }
}
