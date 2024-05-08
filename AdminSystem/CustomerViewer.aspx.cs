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
        // Create a new instance
        clsCustomer AnCustomer = new clsCustomer();
        // get the data from the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];

        Response.Write(AnCustomer.CustomerUsername);
        Response.Write(AnCustomer.CustomerPass);
        Response.Write(AnCustomer.CustomerEmail);
        Response.Write(AnCustomer.BankDetails);
        Response.Write(AnCustomer.CustomerConfirmed);
    }
}