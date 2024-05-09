using System;

namespace ClassLibrary
{
    public class clsUser
    {
        //private data member for the User ID property
        private Int32 mUserID;

        //User ID public property
        public int UserID
        {
            get
            {
                //this line of code sends data out of the property
                return mUserID;
            }
            set
            {
                //this line of code allows data into the property
                mUserID = value;
            }
        }

        //private data member for the User Contact Number property
        private Int32 mUserContactNumber;

        //User Contact Number public property
        public int UserContactNumber
        {
            get
            {
                //this line of code sends data out of the property
                return mUserContactNumber;
            }
            set
            {
                //this line of code allows data into the property
                mUserContactNumber = value;
            }
        }

        //private data member for the Customer ID property
        private Int32 mCustomerID;

        //Customer ID public property
        public int CustomerID
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerID;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerID = value;
            }
        }

        //private data member for the User Privileges property
        private string mUserPrivileges;

        //User Privileges public property
        public string UserPrivileges
        {
            get
            {
                //this line of code sends data out of the property
                return mUserPrivileges;
            }
            set
            {
                //this line of code allows data into the property
                mUserPrivileges = value;
            }
        }

        //private data member for the User Privileges property
        private string mUserName;

        //Username public property
        public string UserName
        {
            get
            {
                //this line of code sends data out of the property
                return mUserName;
            }
            set
            {
                //this line of code allows data into the property
                mUserName = value;
            }
        }

        //private data member for the User DOB property
        private DateTime mUserDob;

        //User DOB public property
        public DateTime UserDob
        {
            get
            {
                //this line of code sends data out of the property
                return mUserDob;
            }
            set
            {
                //this line of code allows data into the property
                mUserDob = value;
            }
        }

        //private data member for the Logged In property
        private Boolean mLoggedIn;
        //Logged In public property
        public bool LoggedIn
        {
            get
            {
                //this line of code sends data out of the property
                return mLoggedIn;
            }
            set
            {
                //this line of code allows data into the property
                mLoggedIn = value;
            }
        }


        public bool Find(int UserID)
        {
            //set the private data members to the test data value
            mUserID = 1;
            mUserContactNumber = 999;
            mCustomerID = 1;
            mUserPrivileges = "Admin";
            mUserName = "MazdaZohaib";
            mUserDob = Convert.ToDateTime("26/11/03");
            mLoggedIn = true;
            //always return true
            return true;
        }

    }
}