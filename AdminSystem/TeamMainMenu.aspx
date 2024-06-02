<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

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
           background: url(https://travelnevada.com/wp-content/uploads/2020/05/lass-id-original-1570485087-5d9bb35fcedaf.jpg) no-repeat;
           background-size: cover;
           background-position: center;
        }

        .MainMenu{
           width: 550px;
           background: transparent;
           border: 2px solid rgba(0, 0, 0, 0.2);
           backdrop-filter: blur(20px);
           box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
           color: #fff;
           border-radius: 10px;
           padding: 30px 40px;
        }

        .Label{
           font-size: 36px;
           font-weight: 500;
           text-align:center;
        }

        .Buttons{
           display: flex;
           flex-direction: column;
           justify-content: center;
           align-items: center;
        }

        .ButtonUser{
            padding: 20px;
        }

        .ButtonOrders{
            padding: 20px;
        }

        .ButtonCustomer{
            padding: 20px;
        }

        .ButtonStock{
            padding: 20px;
        }

    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="MainMenu">

        <div class="Label">
        <asp:Label ID="lblMainMenu" runat="server" Text="Team Auto Main Menu"></asp:Label>
        </div>

        <div class="Buttons">

        <div class="ButtonUser">
        <asp:Button ID="btnUser" runat="server" Text="Users" BackColor="Transparent" BorderStyle="Outset" OnClick="btnUser_Click" ForeColor="White" Height="50px" Width="450px"/>
        </div>

        <div class="ButtonOrders">
        <asp:Button ID="btnOrders" runat="server" Text="Orders" BackColor="Transparent" BorderStyle="Outset" OnClick="btnOrders_Click" ForeColor="White" Height="50px" Width="450px"/>
        </div>

        <div class="ButtonCustomer">
        <asp:Button ID="btnCustomer" runat="server" Text="Customers" BackColor="Transparent" BorderStyle="Outset" OnClick="btnCustomer_Click" ForeColor="White" Height="50px" Width="450px"/>
        </div>

        <div class="ButtonStock">
        <asp:Button ID="btnStock" runat="server" Text="Stock" BackColor="Transparent" BorderStyle="Outset" OnClick="btnStock_Click" ForeColor="White" Height="50px" Width="450px"/>
        </div>

        </div>
        
    </div>
    </form>
</body>
</html>
