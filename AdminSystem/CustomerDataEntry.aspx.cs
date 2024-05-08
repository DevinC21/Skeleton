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
       clsCustomer anCustomer = new clsCustomer();

        // capture the username
        anCustomer.CustomerUsername = txtUsername.Text;

        // capture the password
        anCustomer.CustomerPass = txtPassword.Text;

        // capture the email
        anCustomer.CustomerEmail = txtEmail.Text;

        // capture the Bank Details
        anCustomer.BankDetails = Convert.ToInt32(txtBankDetails.Text);

        // capture the Confirmed
        anCustomer.CustomerConfirmed = chkConfirmed.Checked;

        // store the data in the session object
        Session["AnCustomer"] = anCustomer;

        // navigate to the view page
        Response.Redirect("CustomerViewer.aspx");
    }
}