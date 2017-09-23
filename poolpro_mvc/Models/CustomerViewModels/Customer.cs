using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poolpro_mvc.Models.CustomerViewModels
{
    public class Customer
    {
        //primary key
        public int CustomerID { get; set; }

        //data
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public Address Address { get; set; }
        public List<WorkOrder> WorkOrders { get; set; }

    }
}
