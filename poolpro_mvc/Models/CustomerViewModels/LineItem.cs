namespace poolpro_mvc.Models.CustomerViewModels
{
    public class LineItem
    {
        //primary key
        public int LineItemID { get; set; }

        //foreign key
        public int WordOrderID { get; set; }

        //data
        public string Description { get; set; }
        public string Units { get; set; }
        public double UnitCost { get; set; }
        public int Quantity { get; set; }
    }
}