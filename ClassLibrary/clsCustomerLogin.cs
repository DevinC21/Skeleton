using System;
using System.IO;

namespace ClassLibrary
{
    public class clsCustomerLogin
    {
        // private data member for the LoginID property
        private Int32 mLoginID;
        // private data member for the Name property
        private String mLoginName;
        // private data member for the Password property
        private String mLoginPassword;
        // private data member for the Department property
        private String mLoginDepartment;

        public int LoginID
        {
            get
            {
                // return the private data
                return mLoginID;
            }
            set
            {
                // set the private data
                mLoginID = value;
            }
        }

        public string LoginName
        {
            get
            {
                // return the private data
                return mLoginName;
            }
            set
            {
                // set the private data
                mLoginName = value;
            }
        }

        public string LoginPassword
        {
            get
            {
                // return the private data
                return mLoginPassword;
            }
            set
            {
                // set the private data
                mLoginPassword = value;
            }
        }

        public string LoginDepartment
        {
            get
            {
                // return the private data
                return mLoginDepartment;
            }
            set
            {
                // set the private data
                mLoginDepartment = value;
            }
        }

        public bool FindCustomer(string LoginName, string LoginPassword)
        {
            // create an instance of the data collection
            clsDataConnection DB = new clsDataConnection();
            // Add parameters for the Name and password to search for 
            DB.AddParameter("@LoginName", LoginName);
            DB.AddParameter("@LoginPassword", LoginPassword);
            // execute stored procedure 
            DB.Execute("sproc_tblLogin_FindLoginNamePW");
            // if one record is found
            if (DB.Count == 1)
            {
                // copy the data from the database into the private data members
                mLoginID = Convert.ToInt32(DB.DataTable.Rows[0]["LoginID"]);
                mLoginName = Convert.ToString(DB.DataTable.Rows[0]["LoginName"]);
                mLoginPassword = Convert.ToString(DB.DataTable.Rows[0]["LoginPassword"]);
                mLoginDepartment = Convert.ToString(DB.DataTable.Rows[0]["LoginDepartment"]);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}