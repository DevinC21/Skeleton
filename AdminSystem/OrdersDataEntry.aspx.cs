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

    protected void btnOK_Click1(object sender, EventArgs e)
    {
        //create a new instance of clsOrders
        clsOrders AnOrders = new clsOrders();
        //capture the order fullname
        string OrderFullName = txtOrderFullName.Text;

        //capture the orderId
        string OrderID = txtOrderID.Text;

        //capture the order description
        string OrderDescription = txtOrderDescription.Text;

        //capture the order date
        string OrderDate = txtOrderDate.Text;

        //capture the payment
        string Payment = chkPayment.Text;

        //capture the order return
        string OrderReturn = txtOrderReturn.Text;

        //capture the order description
        string OrderStatus = txtOrderStatus.Text;

        string Error = "";

        Error = AnOrders.Valid(OrderFullName, OrderDescription, OrderReturn, OrderStatus, OrderDate);
        if (Error == "")
        {
            AnOrders.OrderFullName = txtOrderFullName.Text;

            AnOrders.OrderDescription = txtOrderDescription.Text;

            AnOrders.OrderDate = Convert.ToDateTime(txtOrderDate.Text);

            AnOrders.OrderReturn = txtOrderReturn.Text;

            AnOrders.OrderStatus = txtOrderStatus.Text;

            //store the orders in the session object
            Session["AnOrders"] = AnOrders;
            //navigate to the view page
            Response.Redirect("OrdersViewer.aspx");
        }
        else
        {
            lblError.Text = Error;

        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrders AnOrders = new clsOrders();
        Int32 OrderID;
        Boolean Found = false;
        OrderID = Convert.ToInt32(txtOrderID.Text);
        Found = AnOrders.Find(OrderID);
        if (Found == true)
        {
            txtOrderID.Text = AnOrders.OrderID.ToString();
            txtOrderFullName.Text = AnOrders.OrderFullName;
            txtOrderDescription.Text = AnOrders.OrderDescription;
            txtOrderDate.Text = AnOrders.OrderDate.ToString();
            chkPayment.Checked = AnOrders.Payment;
            txtOrderReturn.Text = AnOrders.OrderReturn;
            txtOrderStatus.Text = AnOrders.OrderStatus;
        }

    }

    protected void chkPayment_CheckedChanged(object sender, EventArgs e)
    {

    }
}