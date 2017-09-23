namespace poolpro_mvc.Models.CustomerViewModels
{
    public class Address
    {
        //primary key
        public int AddressID { get; set; }

        //foreign key
        public int CustomerID { get; set; }

        //data
        //includes street number, street and unit number
        //ie. 1234 Main Street Unit 2A
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

    }
}