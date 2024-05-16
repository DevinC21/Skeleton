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
        Response.Write(AnUser.UserID);

        //display the User Contact Number for this entry
        Response.Write(AnUser.UserContactNumber);

        //display the User Privileges for this entry
        Response.Write(AnUser.UserPrivileges);

        //display the User DOB for this entry
        Response.Write(AnUser.UserDob);

        //display the Logged In for this entry
        Response.Write(AnUser.LoggedIn);

        //display the Customer ID for this entry
        Response.Write(AnUser.CustomerID);

        //display the Username for this entry
        Response.Write(AnUser.UserName);
    }
}