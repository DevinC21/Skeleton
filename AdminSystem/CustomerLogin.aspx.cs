using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the class we want to create
        clsCustomerLogin AnLogin = new clsCustomerLogin();

        //create the variables to store the login name and login password
        string LoginName = txtLoginName.Text;
        string LoginPassword = txtLoginPassword.Text;

        //create a Boolean variable to store the results of the find login operation
        Boolean Found = false;

        //get the name entered by the user
        LoginName = Convert.ToString(txtLoginName.Text);

        //get the password entered by the user
        LoginPassword = Convert.ToString(txtLoginPassword.Text);

        //find the record
        Found = AnLogin.FindCustomer(LoginName, LoginPassword);

        //add a session to capture the login name
        //Session["AnLogin"] = AnLogin;

        //if name and/or password is empty
        if (txtLoginName.Text == "")
        {
            //record the error
            lblError.Text = "Enter a Login Name ";
        }
        else if (txtLoginName.Text == "")
        {
            //record the error
            lblError.Text = "Enter a Password ";
        }
        //if found
        else if (Found == true)
        {
            //redirect to the list page
            Response.Redirect("CustomerList.aspx");
        }
        else if (Found == false)
        {
            //record the error
            lblError.Text = "Login details are incorrect. Please try again ";
        }
    }
}