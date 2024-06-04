﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

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

     text{
        display: flex;
        justify-content: center;
        align-items: center;
     }

     body{
        display: flex;
        justify-content: center;
        align-items: center;
        min-height: 100vh;
        background: url(https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/6cac3c7e-7310-4788-a635-e9e6b224b84d/dhj6e36-e8606762-1cd2-4fbc-8cf5-eb26102e8eb6.gif?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzZjYWMzYzdlLTczMTAtNDc4OC1hNjM1LWU5ZTZiMjI0Yjg0ZFwvZGhqNmUzNi1lODYwNjc2Mi0xY2QyLTRmYmMtOGNmNS1lYjI2MTAyZThlYjYuZ2lmIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.OsKwksgjbyTww5VTUYsQPR5U2eHIv5byq0aSbLBLgVI) no-repeat;
        background-size: cover;
        background-position: center;
     }

     .List{
        display: flex;
        justify-content: center;
        flex-direction: column;
        width: 520px;
        background: transparent;
        border: 2px solid rgba(0, 0, 0, 0.2);
        backdrop-filter: blur(20px);
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
        color: yellow;
        border-radius: 10px;
        padding: 30px 40px;
     }

     .Label{
        font-size: 36px;
        font-weight: 500;
        text-align:center;
     }

     .StockList{
        display: flex;
        justify-content: center;
        align-items: center;
     }

     .Buttons{
        display: flex;
        flex-direction: row;
        justify-content: center;
        align-items: center;
        gap: 20px;
        padding-top: 20px;
     }

     .Buttons2{
        display: flex;
        flex-direction: row;
        justify-content: center;
        align-items: center;
        gap: 20px;
        padding-top: 20px;
     }

     .Filter{
        display: flex;
        flex-direction: row;
        justify-content: center;
        align-items: center;
        gap: 20px;
        padding-top: 20px;
     }

    .Stock{
       display: flex;
       flex-direction: row;
       justify-content: center;
       align-items: center;
       padding-top: 20px;
    }

     </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="List">

        <div class="Label">
        <asp:Label ID="lblStock" runat="server" Text="Stock List Page"></asp:Label>
        </div>


        <div class="StockList">
        <asp:ListBox ID="lstStockList" runat="server" Height="250px" Width="500px" BackColor="Transparent" ForeColor="White"></asp:ListBox>
        </div>

        <div class="Buttons">
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Width="60px" Text="Add" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" />
        <asp:Button ID="btnEdit" runat="server" Width="80px" Text="Edit" OnClick="btnEdit_Click" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" />
        <asp:Button ID="btnDelete" runat="server" Width="100px" Text="Delete" OnClick="btnDelete_Click" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" />
        </div>

        <div class="Filter">
        <asp:Label ID="lblFilter" runat="server" Text="Enter a Brand" ForeColor="White"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
        </div>

        <div class="Buttons2">
        <asp:Button ID="btnApplyFilter" runat="server" Width="140px" Text="Apply Filter" OnClick="btnApplyFilter_Click" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" />
        <asp:Button ID="btnClearFilter" runat="server" Width="140px" Text="Clear Filter" OnClick="btnClearFilter_Click" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" />
        <asp:Button ID="btnMainMenu" runat="server" Width="180px" Text="Return to Main Menu" OnClick="btnMainMenu_Click" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" />
        </div>

        <div class="Stock">
        <asp:Button ID="btnStock" runat="server" Width="60px" Text="Stock" OnClick="btnStock_Click" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" />
        </div>

        <div class="Error">
        <asp:Label ID="lblError" runat="server"></asp:Label>
        </div>

    </div>
    </form>
</body>
</html>
