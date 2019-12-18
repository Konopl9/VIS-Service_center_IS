using System;

namespace Service_Center_IS.Database
{
    public class Order
    {
        public int Oid { get; set; }

        public string Status { get; set; }
        
        public string OrderDate { get; set; }
        
        public string ShippedDate { get; set; }
        
        public string FinishDate { get; set; }
        
        public int? Price { get; set; }
        
        public int? Complexity { get; set; }
        
        public string Defect { get; set; }
        
        public int? EmployeeEid { get; set; }
        
        public int CustomerUid { get; set; }
        
        public int DeviceIid { get; set; }
    }
}