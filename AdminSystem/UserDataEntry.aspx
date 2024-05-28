<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblUserID" runat="server" style="z-index: 1; left: 10px; top: 30px; position: absolute" Text="User ID"></asp:Label>
        <asp:TextBox ID="txtUserID" runat="server" style="z-index: 1; left: 125px; top: 30px; position: absolute" width="125px" height="20px"></asp:TextBox>

        <asp:Label ID="lblUserContactNumber" runat="server" style="z-index: 1; left: 10px; top: 60px; position: absolute" Text="Contact Number"></asp:Label>
        <asp:TextBox ID="txtUserContactNumber" runat="server" style="z-index: 1; left: 125px; top: 60px; position: absolute" width="125px" height="20px"></asp:TextBox>

        <asp:Label ID="lblUserPrivileges" runat="server" style="z-index: 1; left: 10px; top: 90px; position: absolute;" Text="User Privileges"></asp:Label>
        <asp:TextBox ID="txtUserPrivileges" runat="server" style="z-index: 1; left: 125px; top: 90px; position: absolute" width="125px" height="20px"></asp:TextBox>

        <asp:Label ID="lblUserDob" runat="server" style="z-index: 1; left: 10px; top: 120px; position: absolute;" Text="Date of Birth"></asp:Label>
        <asp:TextBox ID="txtUserDob" runat="server" style="z-index: 1; left: 125px; top: 120px; position: absolute" width="125px" height="20px"></asp:TextBox>

        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 10px; top: 150px; position: absolute" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 125px; top: 150px; position: absolute" width="125px" height="20px"></asp:TextBox>

        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 10px; top: 180px; position: absolute" Text="Username"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 125px; top: 180px; position: absolute" width="125px" height="20px"></asp:TextBox>

        <asp:CheckBox ID="chkLoggedIn" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" style="z-index: 1; left: 125px; top: 210px; position: absolute" Text="Logged In?" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 240px; position: absolute"></asp:Label>

        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 10px; top: 300px; position: absolute" width="50px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 65px; top: 300px; position: absolute" width="75px" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 300px; top: 30px; position: absolute" width="60px" Text="Find" OnClick="btnFind_Click" />
        <asp:Button ID="btnMainMenu" runat="server" style="z-index: 1; left: 200px; top: 300px; position: absolute" width="160px" Text="Return to Main Menu" OnClick="btnMainMenu_Click" />
    </form>
</body>
</html>