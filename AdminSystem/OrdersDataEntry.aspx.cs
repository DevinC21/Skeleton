using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            if (OrderID != -1)
            {
                DisplayOrder();
            }
        }
    }

    void DisplayOrder()
    {
        clsOrdersCollection Orders = new clsOrdersCollection();
        Orders.ThisOrders.Find(OrderID);

        txtOrderID.Text = Orders.ThisOrders.OrderID.ToString();
        txtOrderFullName.Text = Orders.ThisOrders.OrderFullName.ToString();
        txtOrderDescription.Text = Orders.ThisOrders.OrderDescription.ToString();
        txtOrderDate.Text = Orders.ThisOrders.OrderDate.ToString();
        chkPayment.Checked = Orders.ThisOrders.Payment;
        txtOrderReturn.Text = Orders.ThisOrders.OrderReturn.ToString();
        txtOrderStatus.Text = Orders.ThisOrders.OrderStatus.ToString();


    }

    protected void btnOK_Click1(object sender, EventArgs e)
    {
        //create a new instance of clsOrders
        clsOrders AnOrders = new clsOrders();
        //capture the order fullname
        string OrderFullName = txtOrderFullName.Text;


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
            AnOrders.OrderID = OrderID;

            AnOrders.OrderFullName = OrderFullName;

            AnOrders.OrderDescription = OrderDescription;

            AnOrders.OrderReturn = OrderReturn;

            AnOrders.OrderStatus = OrderStatus;

            AnOrders.OrderDate = Convert.ToDateTime(txtOrderDate.Text);

            AnOrders.Payment = chkPayment.Checked;

            clsOrdersCollection OrdersList = new clsOrdersCollection();

            if (OrderID == -1)
            {
                OrdersList.ThisOrders = AnOrders;
                OrdersList.Add();
            }
            else
            {
                OrdersList.ThisOrders.Find(OrderID);
                OrdersList.ThisOrders = AnOrders;
                OrdersList.Update();

            }
            Response.Redirect("OrdersList.aspx");
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
   
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("OrdersList.aspx");
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}
