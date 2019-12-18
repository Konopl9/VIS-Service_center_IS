namespace Service_Center_IS.Database
{
    public class Worker : Employee
    {
        public int? QualificationLevel { get; set; }

        public string Gender { get; set; }

        public int? Salary { get; set; }

        public int? Points { get; set; }
    }
}