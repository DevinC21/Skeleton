<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

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
       background: url(https://images.hdqwalls.com/download/ferrari-458-italia-rear-cgi-pm-1440x900.jpg) no-repeat;
       background-size: cover;
       background-position: center;
    }

    .DataEntry{
       width: 520px;
       background: transparent;
       border: 2px solid rgba(0, 0, 0, 0.2);
       backdrop-filter: blur(20px);
       box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
       color: #fff;
       border-radius: 10px;
       padding: 30px 40px;
       display: flex;
       flex-direction: column;
    }

    .UserDataEntry{
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

    .UserID{
        display: flex;
        flex-direction: row;
        gap: 20px;
        align-items: center;
    }

    .UserContactNumber{
        display: flex;
        flex-direction: row;
        gap: 20px;
        padding-top: 10px;
        align-items: center;
    }

    .UserPrivileges{
        display: flex;
        flex-direction: row;
        gap: 20px;
        padding-top: 10px;
        align-items: center;
    }

    .UserDob{
        display: flex;
        flex-direction: row;
        gap: 20px;
        padding-top: 10px;
        align-items: center;
    }

    .CustomerID{
        display: flex;
        flex-direction: row;
        gap: 20px;
        padding-top: 10px;
        align-items: center;
    }

    .UserName{
        display: flex;
        flex-direction: row;
        gap: 20px;
        padding-top: 10px;
        align-items: center;
    }

    .LoggedIn{
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

        <div class="UserDataEntry">
        <asp:Label ID="lblDataEntry" runat="server" Text="User Data Entry Page"></asp:Label>
        </div>

        <div class="Labels">

        <div class="UserID">
        <asp:Label ID="lblUserID" runat="server" Text="User ID"></asp:Label>
        <asp:TextBox ID="txtUserID" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
        </div>

        <div class="UserContactNumber">
        <asp:Label ID="lblUserContactNumber" runat="server" Text="Contact Number"></asp:Label>
        <asp:TextBox ID="txtUserContactNumber" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
        </div>

        <div class="UserPrivileges">
        <asp:Label ID="lblUserPrivileges" runat="server" Text="User Privileges"></asp:Label>
        <asp:TextBox ID="txtUserPrivileges" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
        </div>

        <div class="UserDob">
        <asp:Label ID="lblUserDob" runat="server" Text="Date of Birth"></asp:Label>
        <asp:TextBox ID="txtUserDob" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
        </div>

        <div class="CustomerID">
        <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
        </div>

        <div class="UserName">
        <asp:Label ID="lblUserName" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White"></asp:TextBox>
        </div>

        </div>

        <div class="LoggedIn">
        <asp:CheckBox ID="chkLoggedIn" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Logged In?" />
        </div>

        <div class="Error">
        <asp:Label ID="lblError" runat="server"></asp:Label>
        </div>

        <div class="Buttons1">

        <div class="ButtonOK">
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" Height="30px" Width="60px" />
        </div>

        <div class="ButtonCancel">
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" Height="30px" Width="100px" />
        </div>

        </div>

        <div class="Buttons2">

        <div class="ButtonFind">
        <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" Height="30px" Width="80px" />
        </div>

        <div class="ButtonMainMenu">
        <asp:Button ID="btnMainMenu" runat="server" Text="Return to Main Menu" OnClick="btnMainMenu_Click" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" Height="30px" Width="160px" />
        </div>

        </div>

    </div>
    </form>
</body>
</html>