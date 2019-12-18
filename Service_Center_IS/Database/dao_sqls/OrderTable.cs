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

        private string _sqlFreeOrders = "EXEC Get_Free_orders @login";

        private string _sqlTakeOrder = "EXEC Take_order @login, @oid";

        private string _sqlFinishOrder = "EXEC Finish_order @login, @oid";

        private string _sqlSelectDataForInvoice = "EXEC Get_invoice_data @oid";

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
                int EmployeeEid = Convert.ToInt32(reader["employee_eid"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["employee_eid"]));
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

        public DataTable SelectFreeOrders(string login)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlFreeOrders);
            command.Parameters.AddWithValue("@login", login);
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

        public InvoiceData GetDataForInvoice(int id)
        {
            Database db = new Database();
            SqlCommand command = db.CreateCommand(_sqlSelectDataForInvoice);
            command.Parameters.AddWithValue("@oid", id);
            SqlDataReader reader = command.ExecuteReader();
            InvoiceData invoiceData = new InvoiceData();
            while (reader.Read())
            {
                
                string CustomerName = Convert.ToString(reader["customer_name"]);
                string CustomerSurname = Convert.ToString(reader["customer_surname"]);
                string EmployeeName = Convert.ToString(reader["employee_name"]);
                string EmployeeSurname = Convert.ToString(reader["employee_surname"]);
                int EmployeeQualificationLevel = Convert.ToInt32(reader["qualification_level"]);
                string OrderOrderDate = Convert.ToString(reader["order_date"]); 
                string OrderShippedDate = Convert.ToString(reader["shipped_date"]); 
                string OrderFinishedDate = Convert.ToString(reader["finish_date"]); 
                string OrderDefect = Convert.ToString(reader["defect"]);
                int OrderPrice = Convert.ToInt32(reader["price"]);
                string DeviceType = Convert.ToString(reader["type"]);
                string DeviceCompany = Convert.ToString(reader["company"]);
                string DeviceModel = Convert.ToString(reader["model"]);

                invoiceData.CustomerName = CustomerName;
                invoiceData.CustomerSurname = CustomerSurname;
                invoiceData.EmployeeName = EmployeeName;
                invoiceData.EmployeeSurname = EmployeeSurname;
                invoiceData.EmployeeQualificationLevel = EmployeeQualificationLevel;
                invoiceData.OrderOrderDate = DateTime.Parse(OrderOrderDate).ToString("dd.MM.yyyy");
                invoiceData.OrderShippedDate = DateTime.Parse(OrderShippedDate).ToString("dd.MM.yyyy");
                invoiceData.OrderFinishedDate = DateTime.Parse(OrderFinishedDate).ToString("dd.MM.yyyy");
                invoiceData.OrderDefect = OrderDefect;
                invoiceData.OrderPrice = OrderPrice;
                invoiceData.DeviceType = DeviceType;
                invoiceData.DeviceCompany = DeviceCompany;
                invoiceData.DeviceModel = DeviceModel;
            }

            return invoiceData;
        }
    }
}
