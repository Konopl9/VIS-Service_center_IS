using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service_Center_IS_Web;

namespace Service_Center_IS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //MongoCRUD db = new MongoCRUD("DeviceList");
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Apple", Model = "X", Defect = "Screen", Price = 50});
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Apple", Model = "X", Defect = "Button", Price = 20});
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Apple", Model = "X", Defect = "Camera", Price = 100});
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Apple", Model = "XS", Defect = "Screen", Price = 75 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Apple", Model = "XS", Defect = "Button", Price = 50 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Apple", Model = "XS", Defect = "Camera", Price = 120 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Apple", Model = "XR", Defect = "Screen", Price = 85 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Apple", Model = "XR", Defect = "Button", Price = 60 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Apple", Model = "XR", Defect = "Camera", Price = 160 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Apple", Model = "8", Defect = "Screen", Price = 100 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Apple", Model = "8", Defect = "Button", Price = 70 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Apple", Model = "8", Defect = "Camera", Price = 150 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Samsung", Model = "Galaxy 6", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Samsung", Model = "Galaxy 7", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Samsung", Model = "Galaxy 8", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Samsung", Model = "Galaxy 9", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Samsung", Model = "Galaxy 10", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Samsung", Model = "Galaxy 11", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Samsung", Model = "Galaxy 12", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Sony", Model = "XZ 1", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Sony", Model = "XZ 2", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Sony", Model = "Z 1", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Sony", Model = "Xperia 1", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Sony", Model = "XZ 3", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Google", Model = "PIXEL 1", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Google", Model = "PIXEL 2", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Google", Model = "PIXEL 3", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Phone", Company = "Google", Model = "PIXEL 4", Defect = "Screen", Price = 10 });

            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Mouse", Company = "Apple", Model = "Magic Mouse", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Mouse", Company = "Apple", Model = "Magic Mouse 1", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Mouse", Company = "Apple", Model = "Magic Mouse 2", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Mouse", Company = "Apple", Model = "Magic Mouse 3", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Mouse", Company = "Samsung", Model = "S Action", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Mouse", Company = "Samsung", Model = "SX Action", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Mouse", Company = "Samsung", Model = "SV Action", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Mouse", Company = "Sony", Model = "VAIO 1", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Mouse", Company = "Sony", Model = "VAIO 2", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Mouse", Company = "Sony", Model = "VAIO 3", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Mouse", Company = "HP", Model = "Slim Mouse", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Mouse", Company = "HP", Model = "Slim Mouse", Defect = "Screen", Price = 10 });

            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Laptop", Company = "Apple", Model = "Macbook Air 12", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Laptop", Company = "Apple", Model = "Macbook Air 15", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Laptop", Company = "Lenovo", Model = "ThinkPad X1", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Laptop", Company = "Lenovo", Model = "ThinkPad X2", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Laptop", Company = "Lenovo", Model = "ThinkPad X3", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Laptop", Company = "HP", Model = "HP 15-rb056nc", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Laptop", Company = "HP", Model = "HP 16-rb056nc", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Laptop", Company = "HP", Model = "HP 17-rb056nc", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Laptop", Company = "HP", Model = "HP 18-rb056nc", Defect = "Screen", Price = 10 });

            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Tablet", Company = "Apple", Model = "Ipad 4", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Tablet", Company = "Apple", Model = "Ipad 2019", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Tablet", Company = "Samsung", Model = "Galaxy Tab A", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Tablet", Company = "Samsung", Model = "Galaxy Tab B", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Tablet", Company = "Sony", Model = "Sony tablet", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Tablet", Company = "Sony", Model = "Sony tablet", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Tablet", Company = "Google", Model = "Pixel Slate 1", Defect = "Screen", Price = 10 });
            //db.InsertRecord("Devices", new MongoCRUD.MongoDevice { Type = "Tablet", Company = "Google", Model = "Pixel Slate 2", Defect = "Screen", Price = 10 });
            //var resc = db.LoadRecords<MongoCRUD.MongoDevice>("Devices");

            //foreach (var rec in resc)
            //{
            //    Console.WriteLine($"{rec.Id}: {rec.Company} {rec.Type} {rec.Model}");

            //}

        }
    }
}
