<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>

    @import url('https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&display=swap');

    * {
       margin: 0px;
       padding: 0px;
       box-sizing: border-box;
       font-family: "Poppins", sans-serif;
    }

    body{
       display: flex;
       justify-content: center;
       align-items: center;
       min-height: 100vh;
       background: url(https://images8.alphacoders.com/122/thumb-1920-1228400.jpg) no-repeat;
       background-size: cover;
       background-position: center;
    }

    .DataEntry{
       width: 520px;
       background: transparent;
       border: 2px solid rgba(0, 0, 0, 0.2);
       backdrop-filter: blur(20px);
       box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
       color: #4cff00;
       border-radius: 10px;
       padding: 30px 40px;
       display: flex;
       flex-direction: column;
    }

    .OrdersDataEntry{
       font-size: 36px;
       font-weight: 500;
       text-align:center;
    }

    .Labels{
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-items: center;
        padding: 20px;
    }

    .OrderID{
        display: flex;
        flex-direction: row;
        gap: 20px;
        align-items: center;
    }

    .OrderFullName{
        display: flex;
        flex-direction: row;
        gap: 20px;
        padding-top: 10px;
        align-items: center;
    }

    .OrderDescription{
        display: flex;
        flex-direction: row;
        gap: 20px;
        padding-top: 10px;
        align-items: center;
    }

    .OrderDate{
        display: flex;
        flex-direction: row;
        gap: 20px;
        padding-top: 10px;
        align-items: center;
    }


    .OrderReturn{
        display: flex;
        flex-direction: row;
        gap: 20px;
        padding-top: 10px;
        align-items: center;
    }

    .OrderStatus {
         display: flex;
         flex-direction: row;
         gap: 20px;
         padding-top: 10px;
         align-items: center;
    }
    .Payment{
        display: flex;
        justify-content: center;
        gap: 20px;
    }

    .Buttons1{
       display: flex;
       flex-direction: row;
       justify-content: center;
       align-items: center;
    }

    .Buttons2{
       display: flex;
       flex-direction: row;
       justify-content: center;
       align-items: center;
    }

    .ButtonOK{
        padding: 10px;
    }

    .ButtonCancel{
        padding: 10px;
    }

    .ButtonFind{
        padding: 10px;
    }

    .ButtonMainMenu{
        padding: 10px;
    }

</style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="DataEntry">

        <div class="OrdersDataEntry">
        <asp:Label ID="lblDataEntry" runat="server" Text="Orders Data Entry Page"></asp:Label>
        </div>

        <div class="Labels">

        <div class="OrderID">
        <asp:Label ID="lblOrderID" runat="server" Text="Order ID"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
        </div>

        <div class="OrderFullName">
        <asp:Label ID="lblOrderFullName" runat="server" Text="Contact Number"></asp:Label>
        <asp:TextBox ID="txtOrderFullName" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
        </div>

        <div class="OrderDescription">
        <asp:Label ID="lblOrderDescription" runat="server" Text="User Privileges"></asp:Label>
        <asp:TextBox ID="txtOrderDescription" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
        </div>


        <div class="OrderDate">
        <asp:Label ID="lblOrderDate" runat="server" Text="Order Date"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
        </div>

        <div class="OrderReturn">
        <asp:Label ID="lblOrderReturn" runat="server" Text="Order Return"></asp:Label>
        <asp:TextBox ID="txtOrderReturn" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
        </div>

        <div class="OrderStatus">
        <asp:Label ID="lblOrderStatus" runat="server" Text="Order Status"></asp:Label>
        <asp:TextBox ID="txtOrderStatus" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
        </div>

        </div>

        <div class="Payment">
        <asp:CheckBox ID="chkPayment" runat="server" OnCheckedChanged="chkPayment_CheckedChanged" Text="Payment Confirmed" />
        </div>

        <div class="Error">
        <asp:Label ID="lblError" runat="server"></asp:Label>
        </div>

        <div class="Buttons1">

        <div class="ButtonOK">
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click1" Text="OK" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" Height="30px" Width="60px" />
        </div>

        <div class="ButtonCancel">
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" Height="30px" Width="100px" />
        </div>

        </div>

        <div class="Buttons2">

        <div class="ButtonFind">
        <asp:Button ID="Button1" runat="server" Text="Find" OnClick="btnFind_Click" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" Height="30px" Width="80px" />
        </div>

        <div class="ButtonMainMenu">
        <asp:Button ID="btnMainMenu" runat="server" Text="Return to Main Menu" OnClick="btnMainMenu_Click" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" Height="30px" Width="160px" />
        </div>
    
        </div>

    </div>
    </form>
</body>
</html>