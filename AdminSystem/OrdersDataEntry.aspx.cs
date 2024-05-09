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
        AnOrders.OrderFullName = txtOrderFullName.Text;

        //capture the orderId
        AnOrders.OrderID = Convert.ToInt32(txtOrderID.Text);

        //capture the order description
        AnOrders.OrderDescription = txtOrderDescription.Text;

        //capture the order date
        AnOrders.OrderDate = Convert.ToDateTime(txtOrderDate.Text);

        //capture the payment
        AnOrders.Payment = chkPayment.Checked;  

        //capture the order return
        AnOrders.OrderReturn = txtOrderReturn.Text;

        //capture the order description
        AnOrders.OrderStatus = txtOrderStatus.Text;







        //store the orders in the session object
        Session["AnOrders"] = AnOrders;
        //navigate to the view page
        Response.Redirect("OrdersViewer.aspx");
    }
}

