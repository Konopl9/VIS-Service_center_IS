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
    class WorkerTable : IWorker
    {

        private static string Sql_show = "SELECT * FROM employee WHERE position = 'Worker'";
        private static string _sqlCreate = "Exec Create_employee @name, @surname, @position, @date_of_birthday, @qualification_level, @phone, @email, @gender, @salary, @points";

        private static string _sqlEdit =
            "Exec Edit_employee @eid, @name, @surname, @position, @date_of_birthday, @qualification_level, @phone, @email, @gender, @salary, @points";

        private static string _sqlSelectWorkerById =
            "Select eid, name, surname, position, date_of_birthday, phone, email, gender FROM employee WHERE eid = @eid";

        private static string _sqlDelete = "Exec Delete_employee @eid";

        private static string _sqlIncreaseQualification =
            "UPDATE employee SET qualification_level = @qualification_level WHERE eid = @eid";

        private static string _sqlGetEmployeeOfTheMonth = "Exec Show_best_month_employee";

        private static string _sqlIncreaseSalaryForEmployeeOfTheMonth = "Exec IncreaseSalaryForEmployeeOfTheMonth";

        private static string _SelectLastRow = "SELECT TOP 1 eid FROM employee ORDER BY eid DESC";

        private static string _sqlSelectWorkerByLogin =
            "SELECT name, surname, qualification_level, points, sallary FROM employee JOIN employee_account ea on employee.eid = ea.employee_eid WHERE login = @login";

        public Collection<Worker> Select()
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(Sql_show);
            SqlDataReader reader = command.ExecuteReader();
            Collection<Worker> workers = new Collection<Worker>();
            while (reader.Read())
            {
                Worker worker = new Worker();
                int Eid = Convert.ToInt32(reader["eid"]);
                string Name = Convert.ToString(reader["name"]);
                string Surname = Convert.ToString(reader["surname"]);
                string Position = Convert.ToString(reader["position"]);
                string DateOfBirthday = Convert.ToString(reader["date_of_birthday"]);
                int? QualificationLevel = reader["qualification_level"] == DBNull.Value
                    ? (int?) null
                    : Convert.ToInt32(reader["qualification_level"]);
                string Phone = Convert.ToString(reader["phone"]);
                string Email = Convert.ToString(reader["email"]);
                string Gender = Convert.ToString(reader["gender"]);
                int? Salary = reader["sallary"] == DBNull.Value
                    ? (int?)null
                    : Convert.ToInt32(reader["sallary"]);
                int? Points = reader["points"] == DBNull.Value
                    ? (int?)null
                    : Convert.ToInt32(reader["points"]);

                worker.Eid = Eid;
                worker.Name = Name;
                worker.Surname = Surname;
                worker.Position = Position;
                worker.DateOfBirthday = DateOfBirthday;
                worker.QualificationLevel = QualificationLevel;
                worker.Phone = Phone;
                worker.Email = Email;
                worker.Gender = Gender;
                worker.Salary = Salary;
                worker.Points = Points;

                workers.Add(worker);
            }
            return workers;
        }

        public Collection<Worker> SelectOrderById(int id)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlSelectWorkerById);
            command.Parameters.AddWithValue("@eid", id);
            SqlDataReader reader = command.ExecuteReader();
            Collection<Worker> workers = new Collection<Worker>();
            while (reader.Read())
            {
                Worker worker = new Worker();
                string Name = Convert.ToString(reader["name"]);
                string Surname = Convert.ToString(reader["surname"]);
                string Position = Convert.ToString(reader["position"]);
                string DateOfBirthdaty = Convert.ToString(reader["date_of_birthday"]);
                string Phone = Convert.ToString(reader["phone"]);
                string Email = Convert.ToString(reader["email"]);
                string Gender = Convert.ToString(reader["gender"]);

                worker.Name = Name;
                worker.Surname = Surname;
                worker.Position = Position;
                worker.DateOfBirthday = DateOfBirthdaty;
                worker.Phone = Phone;
                worker.Email = Email;
                worker.Gender = Gender;

                workers.Add(worker);
            }
            return workers;
        }

        public int Create(Worker worker)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlCreate);
            command.Parameters.AddWithValue("@name", worker.Name);
            command.Parameters.AddWithValue("@surname", worker.Surname);
            command.Parameters.AddWithValue("@position", worker.Position);
            command.Parameters.AddWithValue("@date_of_birthday", worker.DateOfBirthday);
            command.Parameters.AddWithValue("@qualification_level", worker.QualificationLevel ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@phone", worker.Phone);
            command.Parameters.AddWithValue("@email", worker.Email);
            command.Parameters.AddWithValue("@gender", worker.Gender);
            command.Parameters.AddWithValue("@salary", worker.Salary ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@points", worker.Points ?? (object)DBNull.Value);
            int rows = db.ExecuteNonQuery(command);
            return rows;
        }

        public int Edit(Worker worker)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlEdit);
            command.Parameters.AddWithValue("@eid", worker.Eid);
            command.Parameters.AddWithValue("@name", worker.Name);
            command.Parameters.AddWithValue("@surname", worker.Surname);
            command.Parameters.AddWithValue("@position", worker.Position);
            command.Parameters.AddWithValue("@date_of_birthday", worker.DateOfBirthday);
            command.Parameters.AddWithValue("@qualification_level", worker.QualificationLevel ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@phone", worker.Phone);
            command.Parameters.AddWithValue("@email", worker.Email);
            command.Parameters.AddWithValue("@gender", worker.Gender);
            command.Parameters.AddWithValue("@salary", worker.Salary ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@points", worker.Points ?? (object)DBNull.Value);
            int rows = db.ExecuteNonQuery(command);
            return rows;
        }

        public int IncreaseQualification(Worker worker)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlIncreaseQualification);
            command.Parameters.AddWithValue("@eid", worker.Eid);
            command.Parameters.AddWithValue("@qualification_level", worker.QualificationLevel ?? (object)DBNull.Value);
            int rows = db.ExecuteNonQuery(command);
            return rows;
        }

        public int Delete(int id)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlDelete);
            command.Parameters.AddWithValue("@eid", id);
            int rows = db.ExecuteNonQuery(command);
            return rows;
        }

        public Collection<Worker> GetWorkerOfTheMonth()
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlGetEmployeeOfTheMonth);
            SqlDataReader reader = command.ExecuteReader();
            Collection<Worker> workers = new Collection<Worker>();
            while (reader.Read())
            {
                Worker worker = new Worker();
                int Eid = Convert.ToInt32(reader["eid"]);
                string Name = Convert.ToString(reader["name"]);
                string Surname = Convert.ToString(reader["surname"]);
                int? Salary = reader["sallary"] == DBNull.Value
                    ? (int?)null
                    : Convert.ToInt32(reader["sallary"]);
                int? Points = reader["points"] == DBNull.Value
                    ? (int?)null
                    : Convert.ToInt32(reader["points"]);

                worker.Eid = Eid;
                worker.Name = Name;
                worker.Surname = Surname;

                worker.Salary = Salary;
                worker.Points = Points;

                workers.Add(worker);
            }
            return workers;
        }

        public Collection<Worker> SelectWorkerByLogin(string login)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlSelectWorkerByLogin);
            command.Parameters.AddWithValue("@login", login);
            SqlDataReader reader = command.ExecuteReader();
            Collection<Worker> workers = new Collection<Worker>();
            while (reader.Read())
            {
                Worker worker = new Worker();
                string Name = Convert.ToString(reader["name"]);
                string Surname = Convert.ToString(reader["surname"]);
                int QualificationLevel = Convert.ToInt32(reader["qualification_level"]);
                int Points = Convert.ToInt32(reader["points"]);
                int Salary = Convert.ToInt32(reader["sallary"]);

                worker.Name = Name;
                worker.Surname = Surname;
                worker.QualificationLevel = QualificationLevel;
                worker.Points = Points;
                worker.Salary = Salary;

                workers.Add(worker);
            }
            return workers;
        }

        public int IncreaseSalaryForEmployeeOfTheMonth()
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlIncreaseSalaryForEmployeeOfTheMonth);
            int rows = db.ExecuteNonQuery(command);
            return rows;
        }

        public int lastRowKey()
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_SelectLastRow);
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                Worker worker = new Worker();
                int Eid = Convert.ToInt32(reader["eid"]);
                worker.Eid = Eid;
                return Eid;
            }

            return 0;
        }

        public DataTable SelectForTable()
        {
            throw new NotImplementedException();
        }
    }
}
