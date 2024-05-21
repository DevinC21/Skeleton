<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstUserList" runat="server" Height="350px" Width="500px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 10px; top: 425px; position: absolute;" width="60px" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 80px; top: 425px; position: absolute;" width="80px" Text="Edit" OnClick="btnEdit_Click" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 480px; position: absolute;"></asp:Label>
    </form>
</body>
</html>
