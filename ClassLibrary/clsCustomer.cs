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


        public bool Find(int customerId)
        {
            mCustomerId = 21;
            mDateOfBirth = Convert.ToDateTime("23/12/2022");
            mCustomerUsername = "Charlie";
            mCustomerPass = "Password";
            mCustomerEmail = "example@gmail.com";
            mBankDetails = 1001001;
            mCustomerConfirmed = true;
            return true;
        }
    }
}