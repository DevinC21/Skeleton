<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserLogin.aspx.cs" Inherits="UserLogin" %>

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
        background: url(https://th.bing.com/th/id/R.dc29d4e1ac9974fdeb1ba6524b7e3edb?rik=qMqvam9x5dxnmw&riu=http%3a%2f%2fwww.marinoperformancemotors.com%2fimagetag%2f12892%2f3%2fl%2fUsed-2014-Ferrari-458-Italia.jpg&ehk=ZtXx0oGZeiDH3FwvSEfSGDHWjODUuxjbf8dv5XT%2fccw%3d&risl=&pid=ImgRaw&r=0) no-repeat;
        background-size: cover;
        background-position: center;
     }

     .Login{
        width: 420px;
        background: transparent;
        border: 2px solid rgba(0, 0, 0, 0.2);
        backdrop-filter: blur(20px);
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
        color: #fff;
        border-radius: 10px;
        padding: 30px 40px;
     }

     .UserLoginPage{
        font-size: 36px;
        font-weight: 500;
        text-align:center;
     }

     .LoginName{
        display: flex;
        justify-content: center;
        align-items: center;
        width: 100%;
        height: 50px;
     }

     .LoginPassword{
        display: flex;
        justify-content: center;
        align-items: center;
        width: 100%;
        height: 50px;
     }

     .Name{
        display: flex;
        justify-content: center;
        align-items: center;
        width: 100%;
        height: 100%;
        padding-bottom: 20px;
     }

     .Password{
        display: flex;
        justify-content: center;
        align-items: center;
        width: 100%;
        height: 100%;
        padding-bottom: 20px;
     }

     .Button{
        display: flex;
        flex-direction: row;
        justify-content: center;
        align-items: center;
     }

     .ButtonLogin{
         padding: 10px;
     }

     .ButtonCancel{
         padding: 10px;
     }

    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="Login">

        <div class="UserLoginPage">
        <asp:Label ID="lblLogin" runat="server" Text="User Login Page"></asp:Label>
        </div>

        <div class="LoginName">
        <asp:Label ID="lblLoginName" runat="server" Text="Login Name" ForeColor="White"></asp:Label>
        </div>
        <div class="Name">
        <asp:TextBox ID="txtLoginName" runat="server" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" Height="30px" Width="500px"></asp:TextBox>
        </div>

        <div class="LoginPassword">
        <asp:Label ID="lblLoginPassword" runat="server" Text="Password" ForeColor="White"></asp:Label>
        </div>
        <div class="Password">
        <asp:TextBox ID="txtLoginPassword" runat="server" TextMode="Password" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" Height="30px" Width="500px"></asp:TextBox>
        </div>

        <div class="Error">
        <asp:Label ID="lblError" runat="server" ></asp:Label>
        </div>

        <div class="Button">

        <div class="ButtonLogin">
        <asp:Button ID="btnLogin" runat="server" Text="Login" BackColor="Transparent" BorderStyle="Outset" OnClick="btnLogin_Click" ForeColor="White" Height="30px" Width="100px"/>
        </div>

        <div class="ButtonCancel">
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" BackColor="Transparent" BorderStyle="Outset" OnClick="btnCancel_Click" ForeColor="White" Height="30px" Width="100px"/>
        </div>

        </div>

    </div>
    </form>
</body>
</html>