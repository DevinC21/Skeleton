﻿using System;

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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //add the parameter for the User ID to search for
            DB.AddParameter("@UserID", UserID);

            //execute the stored  procdeure
            DB.Execute("sproc_tblUser_FilterByUserID");

            //if on record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserContactNumber = Convert.ToInt32(DB.DataTable.Rows[0]["UserContactNumber"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mUserPrivileges = Convert.ToString(DB.DataTable.Rows[0]["UserPrivileges"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mUserDob = Convert.ToDateTime(DB.DataTable.Rows[0]["UserDob"]);
                mLoggedIn = Convert.ToBoolean(DB.DataTable.Rows[0]["LoggedIn"]);

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

        public string Valid(string userPrivileges, string userDob, string userName, string userContactNumber)
        {
            //create a string variable to store the error
            String Error = "";

            //create a temporary variable to store the date values
            DateTime DateTemp;

            //if the Username is blank
            if (userName.Length < 5)
            {
                //record the error
                Error = Error + "The username may be blank : ";
            }

            //if the Username is greater than 20 characters
            if (userName.Length > 20)
            {
                //record the error
                Error = Error + "The username must be less than 20 characters :";
            }
            
            //if the User Privileges is less than 4 characters
            if (userPrivileges.Length < 4)
            {
                //record the error
                Error = Error + "The username must contain at least 4 characters : ";
            }

            //if the User Privileges is greater than 5 characters
            if (userPrivileges.Length > 5)
            {
                //record the error
                Error = Error + "The username must be less than 6 characters :";
            }

            //create an instance of DateTime to compare with DateTemp
            //in the if statement
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the UserDob value to the DateTemp variable
                DateTemp = Convert.ToDateTime(userDob);

                //check to see if the date is more than 100 years ago
                if (DateTemp < DateComp.AddYears(-100))
                {
                    //record the error
                    Error = Error + "The date cannot be more than 100 years ago : ";
                }

                //check to see if the date is less than 12 years ago
                if (DateTemp > DateComp.AddYears(-12))
                {
                    //record the error
                    Error = Error + "The date cannot be less than 12 years ago : ";
                }
            }
            
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

                //if the User Contact Number is less than 9 characters
                if (userContactNumber.Length < 9)
                {
                    //record the error
                    Error = Error + "The Contact Number is too small. It must be 9 integers : ";
                }

                //if the User Contact Number is greater than 8 characters
                if (userContactNumber.Length > 9)
                {
                    //record the error
                    Error = Error + "The Contact Number is too large. It must be 9 integers : ";
                }

            //return any error messages
            return Error;
        }
    }
}