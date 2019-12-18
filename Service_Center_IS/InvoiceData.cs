using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Center_IS
{
    class InvoiceData
    {
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public int EmployeeQualificationLevel { get; set; }
        public string OrderOrderDate { get; set; }
        public string OrderShippedDate { get; set; }
        public string OrderFinishedDate { get; set; }
        public string OrderDefect { get; set; }
        public int OrderPrice { get; set; }
        public string DeviceType { get; set; }
        public string DeviceCompany { get; set; }
        public string DeviceModel { get; set; }
        
    }
}
