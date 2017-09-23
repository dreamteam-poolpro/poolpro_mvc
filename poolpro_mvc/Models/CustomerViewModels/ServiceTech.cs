using System.Collections.Generic;

namespace poolpro_mvc.Models.CustomerViewModels
{
    public class ServiceTech
    {
        //primary key
        public int ServiceTechID { get; set; }

        //data
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<WorkOrder> Workorders { get; set; }

    }
}