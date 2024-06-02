<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserList.aspx.cs" Inherits="_1_List" %>

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
        background: url(https://www.wallpaperflare.com/static/1020/166/418/458-italia-ferrari-red-red-wallpaper.jpg) no-repeat;
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
        color: #fff;
        border-radius: 10px;
        padding: 30px 40px;
     }

     .Label{
        font-size: 36px;
        font-weight: 500;
        text-align:center;
     }

     .UserList{
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

    .User{
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
        <asp:Label ID="lblUser" runat="server" Text="User List Page"></asp:Label>
        </div>


        <div class="UserList">
        <asp:ListBox ID="lstUserList" runat="server" Height="250px" Width="500px" BackColor="Transparent" ForeColor="White"></asp:ListBox>
        </div>

        <div class="Buttons">
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Width="60px" Text="Add" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" />
        <asp:Button ID="btnEdit" runat="server" Width="80px" Text="Edit" OnClick="btnEdit_Click" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" />
        <asp:Button ID="btnDelete" runat="server" Width="100px" Text="Delete" OnClick="btnDelete_Click" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" />
        </div>

        <div class="Filter">
        <asp:Label ID="lblFilter" runat="server" Text="Enter a Username" ForeColor="White"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
        </div>

        <div class="Buttons2">
        <asp:Button ID="btnApplyFilter" runat="server" Width="140px" Text="Apply Filter" OnClick="btnApplyFilter_Click" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" />
        <asp:Button ID="btnClearFilter" runat="server" Width="140px" Text="Clear Filter" OnClick="btnClearFilter_Click" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" />
        <asp:Button ID="btnMainMenu" runat="server" Width="180px" Text="Return to Main Menu" OnClick="btnMainMenu_Click" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" />
        </div>

        <div class="User">
        <asp:Button ID="btnUser" runat="server" Width="60px" Text="User" OnClick="btnUser_Click" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" />
        </div>

        <div class="Error">
        <asp:Label ID="lblError" runat="server"></asp:Label>
        </div>

    </div>
    </form>
</body>
</html>
