using System;

namespace ClassLibrary
{
    public class clsUser
    {
        public bool LoggedIn { get; set; }
        public int UserID { get; set; }
        public int UserContactNumber { get; set; }
        public string UserPrivileges { get; set; }
        public DateTime UserDob { get; set; }
        public int CustomerID { get; set; }
        public string UserName { get; set; }
    }
}