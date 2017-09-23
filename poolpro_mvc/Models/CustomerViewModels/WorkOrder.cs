using System.Collections.Generic;

namespace poolpro_mvc.Models.CustomerViewModels
{
    public class WorkOrder
    {
        //primary key
        public int WorkOrderID { get; set; }

        //foreign key
        public int CustomerID { get; set; }
        public int ServiceTechID { get; set; }

        //data 
        public List<LineItem> LineItems { get; set; }
        

    }
}