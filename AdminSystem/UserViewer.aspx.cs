using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsUser
        clsUser AnUser = new clsUser();

        //get the data from the session object
        AnUser = (clsUser)Session["AnUser"];

        //display the User ID for this entry
        Response.Write("User ID: " + AnUser.UserID + "<br>");

        //display the User Contact Number for this entry
        Response.Write("User Contact Number: " + AnUser.UserContactNumber + "<br>");

        //display the User Privileges for this entry
        Response.Write("User Privileges: " + AnUser.UserPrivileges + "<br>");

        //display the User DOB for this entry
        Response.Write("User Date Of Birth: " + AnUser.UserDob + "<br>");

        //display the Logged In for this entry
        Response.Write("Logged In: " + AnUser.LoggedIn + "<br>");

        //display the Customer ID for this entry
        Response.Write("Customer ID: " + AnUser.CustomerID + "<br>");

        //display the Username for this entry
        Response.Write("Username: " + AnUser.UserName + "<br>");
    }
}