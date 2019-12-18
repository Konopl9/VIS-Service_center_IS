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
    class OrderTable
    {
        private static string Sql_show = "Exec Show_all_orders";

        private static string _sqlForOrderTable = "Select oid, status, order_date, shipped_date, finish_date, price FROM Orders";

        private static string _sqlSelectOrderById = "Select oid, status, order_date, shipped_date, finish_date, price FROM Orders WHERE oid = @oId";

        private static string _sqlSelectOrderByNameAndSurname =
            "exec Select_orders_by_name_and_surname @name, @surname";

        private static string _sqlSelectOrderByDate =
            "exec Select_orders_by_date @from, @to";

        private static string _sqlSelectOrderByWorkerSurname = "exec Select_orders_by_worker_surname @surname";

        private static string _sqlEdit =
            "EXEC Edit_order @oid, @status, @shipped_date, @finish_date, @price, @complexity, @defect";
        
        private static string _sqlSelectOrderByID =
            "Select status, order_date, shipped_date, finish_date, price, complexity, defect, employee_eid, customer_uid, device_iid FROM orders WHERE oid = @oid";

        private static string _sqlDeleteOrderByID = "DELETE FROM orders WHERE oid = @oid";

        private static string _sqlCreate = "Exec Create_order @status, @order_date, @shipped_date, @finish_date, @price, @complexity, @defect, @employee_eid, @customer_uid, @type, @company, @model";

        private string _sqlOrdersForWorker = "EXEC Get_employee_orders @login";
        
        private string _sqlFreeOrders = "EXEC Get_Free_orders";

        private string _sqlTakeOrder = "EXEC Take_order @login, @oid";

        private string _sqlFinishOrder = "EXEC Finish_order @login, @oid";

        private string _sqlSelectDataForInvoice = "EXEC Get_invoice_data @oid";

        private static string _selectCustomerOrdersByLogin = "EXEC Select_orders_by_login @login";

        private static string _sqlPayOrder = "IF (SELECT status FROM orders WHERE oid = @oid) = 'Not payed' BEGIN UPDATE orders SET status = 'Free', shipped_date = GETDATE() WHERE oid = @oid END";
        
        private static string _sqlOrderFromWeb = "EXEC Create_order_from_web @login, @type, @company, @model, @defect, @price";

        public Collection<Order> Select()
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(Sql_show);
            SqlDataReader reader = command.ExecuteReader();
            Collection<Order> orders = new Collection<Order>();
            while (reader.Read())
            {
                Order order = new Order();
                int OId = Convert.ToInt32(reader["oid"]);
                string Status = Convert.ToString(reader["status"]);
                string OrderDate = Convert.ToString(reader["order_date"]);
                string ShippedDate = Convert.ToString(reader["shipped_date"]);
                string FinishDate = Convert.ToString(reader["finish_date"]);
                int Price = Convert.ToInt32(reader["price"]);
                int Complexity = Convert.ToInt32(reader["complexity"]);
                string Defect = Convert.ToString(reader["defect"]);
                int EmployeeEid = Convert.ToInt32(reader["employee_eid"]);
                int CustomerUid = Convert.ToInt32(reader["customer_uid"]);
                int DeviceIid = Convert.ToInt32(reader["device_iid"]);

                order.Oid = OId;
                order.Status = Status;
                order.OrderDate = OrderDate;
                order.ShippedDate = ShippedDate;
                order.FinishDate = FinishDate;
                order.Price = Price;
                order.Complexity = Complexity;
                order.Defect = Defect;
                order.EmployeeEid = EmployeeEid;
                order.CustomerUid = CustomerUid;
                order.DeviceIid = DeviceIid;

                orders.Add(order);
            }
            return orders;
        }

        public static int PayOrder(int oid)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlPayOrder);
            command.Parameters.AddWithValue("@oid", oid);
            int rows = db.ExecuteNonQuery(command);
            return rows;
        }

        public static Collection<Order> SelectOrderByLogin(string login)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_selectCustomerOrdersByLogin);
            command.Parameters.AddWithValue("@login", login);
            SqlDataReader reader = command.ExecuteReader();
            Collection<Order> orders = new Collection<Order>();
            while (reader.Read()) 
            {
                Order order = new Order();
                order.Oid = Convert.ToInt32(reader["oid"]);
                order.Status = Convert.ToString(reader["status"]);
                order.OrderDate = DateTime.Parse(Convert.ToString(reader["order_date"])).ToString("dd.MM.yyyy");
                order.ShippedDate = Convert.ToString(Convert.ToString(reader["shipped_date"] == DBNull.Value ? "Not shipped" : DateTime.Parse(Convert.ToString(reader["shipped_date"])).ToString("dd.MM.yyyy")));
                order.Price = Convert.ToInt32(reader["price"]);
                order.Defect = Convert.ToString(reader["defect"]);

                orders.Add(order);
            }
            return orders;
        }
        public static DataTable SelectForOrderTable()
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlForOrderTable);
            SqlDataAdapter sqlDa = new SqlDataAdapter(command);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);

            return dtb1;

        }

        public static DataTable SelectForOrderTableById(Order order)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlSelectOrderById);
            command.Parameters.AddWithValue("@oId", order.Oid);
            SqlDataAdapter sqlDa = new SqlDataAdapter(command);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);

            return dtb1;

        }

        public static DataTable SelectForOrderTableByNameAndSurname(Customer customer)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlSelectOrderByNameAndSurname);
            command.Parameters.AddWithValue("@name", customer.Name);
            command.Parameters.AddWithValue("@surname", customer.Surname);
            SqlDataAdapter sqlDa = new SqlDataAdapter(command);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);

            return dtb1;

        }

        public static DataTable SelectForOrderTableByDate(Order order, Order order1)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlSelectOrderByDate);
            command.Parameters.AddWithValue("@from", order.OrderDate);
            command.Parameters.AddWithValue("@to", order1.OrderDate);
            SqlDataAdapter sqlDa = new SqlDataAdapter(command);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);

            return dtb1;

        }

        public static DataTable SelectForOrderTableByWorker(Worker worker)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlSelectOrderByWorkerSurname);
            command.Parameters.AddWithValue("@surname", worker.Surname);
            SqlDataAdapter sqlDa = new SqlDataAdapter(command);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);

            return dtb1;
        }

        public static int Edit(Order order)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlEdit);
            command.Parameters.AddWithValue("@oid", order.Oid);
            command.Parameters.AddWithValue("@status", order.Status);
            command.Parameters.AddWithValue("@shipped_date", order.ShippedDate ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@finish_date", order.FinishDate ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@price", order.Price ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@complexity", order.Complexity ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@defect", order.Defect ?? (object)DBNull.Value);
            int rows = db.ExecuteNonQuery(command);
            return rows;
        }

        public Collection<Order> SelectOrderById(int id)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlSelectOrderByID);
            command.Parameters.AddWithValue("@oid", id);
            SqlDataReader reader = command.ExecuteReader();
            Collection<Order> orders = new Collection<Order>();
            while (reader.Read())
            {
                Order order = new Order();
                string Status = Convert.ToString(reader["status"]);
                string OrderDate = Convert.ToString(reader["order_date"]);
                string ShippedDate = Convert.ToString(reader["shipped_date"]);
                string FinishDate = Convert.ToString(reader["finish_date"]);
                int? Price = Convert.ToInt32(reader["price"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["price"]));
                int? Complexity = Convert.ToInt32(reader["complexity"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["complexity"]));
                string Defect = Convert.ToString(reader["defect"]);
                int EmployeeEid = Convert.ToInt32(reader["employee_eid"]);
                int CustomerUid = Convert.ToInt32(reader["customer_uid"]);
                int DeviceIid = Convert.ToInt32(reader["device_iid"]);

                order.Status = Status;
                order.OrderDate = OrderDate;
                order.ShippedDate = ShippedDate;
                order.FinishDate = FinishDate;
                order.Price = Price;
                order.Complexity = Complexity;
                order.Defect = Defect;
                order.EmployeeEid = EmployeeEid;
                order.CustomerUid = CustomerUid;
                order.DeviceIid = DeviceIid;

                orders.Add(order);
            }
            return orders;
        }

        public static int DeleteOrderById(int id)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlDeleteOrderByID);
            command.Parameters.AddWithValue("@oid", id);
            int rows = db.ExecuteNonQuery(command);
            return rows;
        }

        public int Create(Order order, Device device)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlCreate);
            command.Parameters.AddWithValue("@status", order.Status);
            command.Parameters.AddWithValue("@order_date", order.OrderDate);
            command.Parameters.AddWithValue("@shipped_date", order.ShippedDate ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@finish_date", order.FinishDate ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@price", order.Price);
            command.Parameters.AddWithValue("@complexity", order.Complexity);
            command.Parameters.AddWithValue("@defect", order.Defect);
            command.Parameters.AddWithValue("@employee_eid", order.EmployeeEid ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@customer_uid", order.CustomerUid);
            command.Parameters.AddWithValue("@type", device.Type);
            command.Parameters.AddWithValue("@company", device.Company);
            command.Parameters.AddWithValue("@model", device.Model);
            int rows = db.ExecuteNonQuery(command);
            return rows;
        }

        public DataTable SelectWorkerOrders(string login)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlOrdersForWorker);
            command.Parameters.AddWithValue("@login", login);
            SqlDataAdapter sqlDa = new SqlDataAdapter(command);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);

            return dtb1;
        }

        public DataTable SelectFreeOrders()
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlFreeOrders);
            SqlDataAdapter sqlDa = new SqlDataAdapter(command);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);

            return dtb1;
        }

        public int TakeOrder(string login, int oid)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlTakeOrder);
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@oid", oid);
            int rows = db.ExecuteNonQuery(command);
            return rows;

        }

        public int FinishOrder(string login, int id)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlFinishOrder);
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@oid", id);
            int rows = db.ExecuteNonQuery(command);
            return rows;
        }

        internal static int CreateNewOrderFromWeb(string type, string company, string model, string defect, int price, string login)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlOrderFromWeb);
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.AddWithValue("@company", company);
            command.Parameters.AddWithValue("@model", model);
            command.Parameters.AddWithValue("@defect", defect);
            command.Parameters.AddWithValue("@price", price);
            int rows = db.ExecuteNonQuery(command);
            return rows;
        }
    }
}
