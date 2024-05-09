using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        //private data member for the order id properly
        private Int32 mOrderID;

        //orderid public property
        public Int32 OrderID
        {
            get
            {
                // this line of code sends the data out of the property
                return mOrderID;
            }
            set
            {
                //this line of the code allows data into the property
                mOrderID = value;
            }
        }
        private string mOrderFullName;
        public string OrderFullName
        {
            get
            {
                return mOrderFullName;
            }
            set
            {
                mOrderFullName = value;
            }
        }
        private string mOrderDescription;
        public string OrderDescription
        {
            get
            {
                return mOrderDescription;
            }
            set
            {
                mOrderDescription = value;
            }
        }
        private DateTime mOrderDate;
        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }
        private Boolean mPayment;
        public bool Payment
        {
            get
            {
                return mPayment;
            }
            set
            {
                mPayment = value;
            }
        }
        private string mOrderReturn;
        public string OrderReturn
        {
            get
            {
                return mOrderReturn;
            }
            set
            {
                mOrderReturn = value;
            }
        }
        private string mOrderStatus;
        public string OrderStatus
        {
            get
            {
                return mOrderStatus;
            }
            set
            {
                mOrderStatus = value;
            }
        }
        public bool Find(int OrderID)
        {

            mOrderID = 21;
            mOrderFullName = "Full Name";
            mOrderDescription = "Order Description";
            mOrderDate = Convert.ToDateTime("09/05/2024");
            mPayment = true;

            return true;

        }
    }
}
