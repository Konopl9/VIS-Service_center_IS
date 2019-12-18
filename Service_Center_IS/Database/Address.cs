namespace Service_Center_IS.Database
{
    internal class Address
    {
        public int Aid { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string Number { get; set; }
        
        public int Zip { get; set; }

        public int CustomerUid { get; set; }
    }
}