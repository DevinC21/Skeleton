<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersLogin.aspx.cs" Inherits="OrdersLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:Label ID="lblLoginName" runat="server" style="z-index: 1; left: 38px; top: 91px; position: absolute" Text="Login Name"></asp:Label>
        <asp:TextBox ID="txtLoginName" runat="server" style="z-index: 1; left: 125px; top: 90px; position: absolute" width="125px" height="20px"></asp:TextBox>

        <asp:Label ID="lblLoginPassword" runat="server" style="z-index: 1; left: 42px; top: 124px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="txtLoginPassword" runat="server" style="z-index: 1; left: 125px; top: 120px; position: absolute" width="125px" height="20px" TextMode="Password"></asp:TextBox>

        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 300px; top: 105px; position: absolute" ForeColor="#FF3300"></asp:Label>

        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 211px; top: 165px; position: absolute" width="50px" Text="Login" OnClick="btnLogin_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 106px; top: 164px; position: absolute" width="75px" Text="Cancel" OnClick="btnCancel_Click"/>
         <p>
         <asp:Label ID="lblLogin" runat="server" style="z-index: 1; left: 122px; top: 31px; position: absolute" Text="Orders Login Page"></asp:Label>

         </p>
    </form>
</body>
</html>