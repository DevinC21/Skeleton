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

            //create a temporary variable to store the date values
            DateTime DateTemp;

            //if the order fullname is less than 3 characters
            if (orderFullName.Length <= 2)
            {
                //record the error
                Error = Error + "The Order FullName must be more than 2 characters. ";
            }

            //if the order fullname is greater than 20 characters
            if (orderFullName.Length >= 21)
            {
                //record the error
                Error = Error + "The Order FullName must be less than 21 characters. ";
            }

            //if the order description is less than 3 characters
            if (orderDescription.Length <= 2)
            {
                //record the error
                Error = Error + "The Order Description must contain at least 4 characters. ";
            }

            //if the order description is greater than 12 characters
            if (orderDescription.Length >= 13)
            {
                //record the error
                Error = Error + "The Order Description must be less than 13 characters. ";
            }
            //if the order return is greater than 2 characters
            if (orderReturn.Length <= 1)
            {
                //record the error
                Error = Error + "The Order Return must contain at least 2 characters. ";
            }

            //if the order return is greater than 10 characters
            if (orderReturn.Length >= 11)
            {
                //record the error
                Error = Error + "The Order Return must be less than 11 characters. ";
            }
            //if the order status is greater than 10 characters
            if (orderStatus.Length <= 5)
            {
                //record the error
                Error = Error + "The Order Status must contain at least 6 characters. ";
            }

            //if the order status is greater than 5 characters
            if (orderStatus.Length >= 16)
            {
                //record the error
                Error = Error + "The Order Status must be less than 16 characters. ";
            }



            //create an instance of DateTime to compare with DateTemp
            //in the if statement
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the orderDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(orderDate);

                //check to see if the date is more than 1 years ago
                if (DateTemp < DateComp.AddYears(-1))
                {
                    //record the error
                    Error = Error + "The Date cannot be more than 1 year ago. ";
                }

                //check to see if the date is less than 1 years ago
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The Date cannot be after today. ";
                }
            }

            catch
            {
                //record the error
                Error = Error + "The Date was not a valid date. ";
            }

            //return any error messages
            return Error;
        }

    }
}