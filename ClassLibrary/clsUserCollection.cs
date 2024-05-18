using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsUserCollection
    {
        //private data member for the list
        List<clsUser> mUserList = new List<clsUser>();

        //public property for the user list
        public List<clsUser> UserList
        {
            get
            {
                //return the private data
                return mUserList;
            }
            set
            {
                //set the private data
                mUserList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mUserList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsUser ThisUser { get; set; }

        //constructor for the class
        public clsUserCollection()
        {
            //variable for the index
            Int32 Index = 0;

            //variable to store the record count
            Int32 RecordCount = 0;

            //object for the data connect
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblUser_SelectAll");

            //get the count of records
            RecordCount = DB.Count;

            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank user
                clsUser AnUser = new clsUser();

                //read in the fields for the current record
                AnUser.LoggedIn = Convert.ToBoolean(DB.DataTable.Rows[Index]["LoggedIn"]);
                AnUser.UserID = Convert.ToInt32(DB.DataTable.Rows[Index]["UserID"]);
                AnUser.UserContactNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["UserContactNumber"]);
                AnUser.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnUser.UserName = Convert.ToString(DB.DataTable.Rows[Index]["UserName"]);
                AnUser.UserPrivileges = Convert.ToString(DB.DataTable.Rows[Index]["UserPrivileges"]);
                AnUser.UserDob = Convert.ToDateTime(DB.DataTable.Rows[Index]["UserDob"]);

                //add the record to the private data member
                mUserList.Add(AnUser);

                //point at the next record
                Index++;
            }
        }
    }
}