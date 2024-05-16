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

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", OrderID);
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            if (DB.Count == 1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mOrderFullName = Convert.ToString(DB.DataTable.Rows[0]["OrderFullName"]);
                mOrderDescription = Convert.ToString(DB.DataTable.Rows[0]["OrderDescription"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mPayment = Convert.ToBoolean(DB.DataTable.Rows[0]["Payment"]);
                mOrderReturn = Convert.ToString(DB.DataTable.Rows[0]["OrderReturn"]);
                mOrderStatus = Convert.ToString(DB.DataTable.Rows[0]["OrderStatus"]);


                return true;

            }
            else
            {
                return false;
            }
        }






        public string Valid(string orderFullName, string orderDescription, string orderReturn, string orderStatus, string orderDate)
        {
            String Error = "";
            if (orderFullName.Length < 1)
            {
                Error = Error + "The order fullname must be more than one character : ";
            }
            if (orderFullName.Length > 16)
            {
                Error = Error + "The order fullname must be less than 6 characters : ";
            }
           
            return Error;
        }
    }
    
}







