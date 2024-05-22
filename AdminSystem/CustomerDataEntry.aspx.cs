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
        String CustomerUsername = txtUsername.Text;

        // capture the password
        String CustomerPass = txtPassword.Text;

        // capture the email
        String CustomerEmail = txtEmail.Text;

        // capture the Bank Details
        String BankDetails = txtBankDetails.Text;

        // capture the Confirmed
        String CustomerConfirmed = chkConfirmed.Text;

        //capture the UserDob
        String DateOfBirth = txtDateOfBirth.Text;

        //capture the CustomerID
        String CustomerId = txtCustomerId.Text;

        String Error = "";
        Error = AnCustomer.Valid(CustomerUsername, CustomerPass, CustomerEmail, BankDetails, DateOfBirth);
        if (Error == "")
        {
            AnCustomer.CustomerUsername = CustomerUsername;
            AnCustomer.CustomerPass = CustomerPass;
            AnCustomer.CustomerEmail = CustomerEmail;
            AnCustomer.BankDetails = Convert.ToInt32(BankDetails);
            AnCustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            Session["AnCustomer"] = AnCustomer;

            // navigate to the view page
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();

        Int32 CustomerId;

        Boolean Found = false;

        CustomerId = Convert.ToInt32(txtCustomerId.Text);

        Found = AnCustomer.Find(CustomerId);

        if (Found == true)
        {
            txtUsername.Text = AnCustomer.CustomerUsername;
            txtPassword.Text = AnCustomer.CustomerPass;
            txtEmail.Text = AnCustomer.CustomerEmail;
            txtDateOfBirth.Text = AnCustomer.DateOfBirth.ToString();
            txtBankDetails.Text = AnCustomer.BankDetails.ToString();
            chkConfirmed.Checked = AnCustomer.CustomerConfirmed;
        }
    }
}