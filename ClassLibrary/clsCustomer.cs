using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the customer ID property
        private Int32 mCustomerId;
        private DateTime mDateOfBirth;

        // customer Id public property
        public Int32 CustomerId
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }

        private Int32 mBankDetails;
        public Int32 BankDetails
        {
            get
            {
                return mBankDetails;
            }
            set
            {
                mBankDetails = value;
            }
        }

        private string mCustomerUsername;
        public String CustomerUsername
        {
            get
            {
                return mCustomerUsername;
            }
            set
            {
                mCustomerUsername = value;
            }
        }

        private string mCustomerPass;
        public String CustomerPass
        {
            get
            {
                return mCustomerPass;
            }
            set
            {
                mCustomerPass = value;
            }
        }

        private string mCustomerEmail;
        public String CustomerEmail
        {
            get
            {
                return mCustomerEmail;
            }
            set
            {
                mCustomerEmail = value;
            }
        }

        private Boolean mCustomerConfirmed;
        public bool CustomerConfirmed
        {
            get
            {
                return mCustomerConfirmed;
            }
            set
            {
                mCustomerConfirmed = value;
            }
        }


        public bool Find(int CustomerId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //add the parameter for the User ID to search for
            DB.AddParameter("@CustomerId", CustomerId);

            //execute the stored  procdeure
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");

            //if on record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mCustomerUsername = Convert.ToString(DB.DataTable.Rows[0]["CustomerUsername"]);
                mCustomerPass = Convert.ToString(DB.DataTable.Rows[0]["CustomerPass"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mBankDetails = Convert.ToInt32(DB.DataTable.Rows[0]["BankDetails"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mCustomerConfirmed = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerConfirmed"]);

                //return that everything worked okay
                return true;
            }

            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }

        public string Valid(string username, string password, string email, string dateOfBirth, string bankDetails)
        {
            return "";
        }
    }
}
