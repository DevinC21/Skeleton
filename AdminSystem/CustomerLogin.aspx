<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Label ID="lblLogin" runat="server" style="z-index: 1; left: 10px; top: 30px; position: absolute" Text="Customer Login Page"></asp:Label>

    <asp:Label ID="lblLoginName" runat="server" style="z-index: 1; left: 10px; top: 90px; position: absolute" Text="Login Name"></asp:Label>
    <asp:TextBox ID="txtLoginName" runat="server" style="z-index: 1; left: 125px; top: 90px; position: absolute" width="125px" height="20px"></asp:TextBox>

    <asp:Label ID="lblLoginPassword" runat="server" style="z-index: 1; left: 10px; top: 120px; position: absolute" Text="Password"></asp:Label>
    <asp:TextBox ID="txtLoginPassword" runat="server" style="z-index: 1; left: 125px; top: 120px; position: absolute" width="125px" height="20px" TextMode="Password"></asp:TextBox>

    <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 300px; top: 105px; position: absolute" ForeColor="#FF3300"></asp:Label>

    <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 120px; top: 180px; position: absolute" width="50px" Text="Login" OnClick="btnLogin_Click" />
    <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 185px; top: 180px; position: absolute" width="75px" Text="Cancel"/>
    </form>
</body>
</html>
