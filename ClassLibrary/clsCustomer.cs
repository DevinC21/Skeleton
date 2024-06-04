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
            String Error = "";
            DateTime DateTemp;

            if (username.Length == 0)
            {
                Error = Error + "The Username may not be blank : ";
            }

            if (username.Length > 20)
            {
                Error = Error + "The Username must be less than 20 characters : ";
            }

            if (password.Length == 0)
            {
                Error = Error + "The password may not be blank : ";
            }

            if (password.Length > 16)
            {
                Error = Error + "The password must be less than 16 characters : ";
            }

            if (email.Length == 0)
            {
                Error = Error + "The Email may not be blank : ";
            }

            if (email.Length > 50)
            {
                Error = Error + "The Email must be less than 50 characters : ";
            }

            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the UserDob value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateOfBirth);

                //check to see if the date is more than 100 years ago
                if (DateTemp < DateComp.AddYears(-100))
                {
                    //record the error
                    Error = Error + "The Date cannot be more than 100 years ago. ";
                }

                //check to see if the date is less than 12 years ago
                if (DateTemp > DateComp.AddYears(-12))
                {
                    //record the error
                    Error = Error + "The Date cannot be less than 12 years ago. ";
                }
            }

            catch
            {
                //record the error
                Error = Error + "The Date was not a valid date. ";
            }

            if (bankDetails.Length == 0)
            {
                Error = Error + "The Bank Details may not be blank : ";
            }

            if (bankDetails.Length > 50)
            {
                Error = Error + "The Bank Details must be less than 50 characters : ";
            }

            return Error;
        }

    }
}
