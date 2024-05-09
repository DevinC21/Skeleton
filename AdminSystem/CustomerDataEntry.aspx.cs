using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
       //create a new instance of clsCustomer
       clsCustomer AnCustomer = new clsCustomer();

        // capture the username
        AnCustomer.CustomerUsername = txtUsername.Text;

        // capture the password
        AnCustomer.CustomerPass = txtPassword.Text;

        // capture the email
        AnCustomer.CustomerEmail = txtEmail.Text;

        // capture the Bank Details
        AnCustomer.BankDetails = Convert.ToInt32(txtBankDetails.Text);

        // capture the Confirmed
        AnCustomer.CustomerConfirmed = chkConfirmed.Checked;

        //capture the UserDob
        AnCustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);

        //capture the CustomerID
        AnCustomer.CustomerId = Convert.ToInt32(txtCustomerId.Text);

        // store the data in the session object
        Session["AnCustomer"] = AnCustomer;

        // navigate to the view page
        Response.Redirect("CustomerViewer.aspx");
    }
}