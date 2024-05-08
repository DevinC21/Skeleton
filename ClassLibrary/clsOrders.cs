using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        public bool Payment { get; set; }
        public int OrderID { get; set; }
        public string OrderFullName { get; set; }
        public string OrderDescription { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderReturn { get; set; }
        public string OrderStatus { get; set; }
    }
}