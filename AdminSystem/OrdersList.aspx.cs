﻿using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
        //create a new instance of clsUserLogin
        //clsOrdersLogin AnLogin = new clsOrdersLogin();

        //get data from the session object
        //AnLogin = (clsOrdersLogin)Session["AnLogin"];

        //display the login name
        //Response.Write("Logged in as: " + AnLogin.LoginName);
    }

    void DisplayOrders()
    {
        clsOrdersCollection Orders = new clsOrdersCollection();
        lstOrdersList.DataSource = Orders.OrdersList;
        lstOrdersList.DataValueField = "OrderID";
        lstOrdersList.DataTextField = "OrderFullName";
        lstOrdersList.DataBind();

    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderID"] = -1;
        Response.Redirect("OrdersDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        if (lstOrdersList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrdersList.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("OrdersDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        if (lstOrdersList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrdersList.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("OrdersConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsOrdersCollection AnOrders = new clsOrdersCollection();
        AnOrders.ReportByOrderFullName(txtFilter.Text);
        lstOrdersList.DataSource = AnOrders.OrdersList;
        lstOrdersList.DataValueField = "OrderID";
        lstOrdersList.DataTextField = "OrderFullName";
        lstOrdersList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsOrdersCollection AnOrders = new clsOrdersCollection();
        AnOrders.ReportByOrderFullName("");
        txtFilter.Text = "";
        lstOrdersList.DataSource = AnOrders.OrdersList;
        lstOrdersList.DataValueField = "OrderID";
        lstOrdersList.DataTextField = "OrderFullName";
        lstOrdersList.DataBind();
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");

    }

    protected void btnOrders_Click(object sender, EventArgs e)
    {
        //create a new instance of clsUserLogin
        clsOrdersLogin AnLogin = new clsOrdersLogin();

        //get data from the session object
        AnLogin = (clsOrdersLogin)Session["AnLogin"];

        //display the login name
        Response.Write("Logged in as: " + AnLogin.LoginName);
    }
}


