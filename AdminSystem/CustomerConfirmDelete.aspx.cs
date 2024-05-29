using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    // variable to store the primary key value of the record to be deleted
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the customer to be deleted from the session object
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();

        CustomerBook.ThisCustomer.Find(CustomerId);

        CustomerBook.Delete();

        Response.Redirect("CustomerList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}