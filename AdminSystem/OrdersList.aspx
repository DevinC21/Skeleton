<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrdersList" runat="server" style="z-index: 1; left: 16px; top: 51px; position: absolute; height: 328px; width: 345px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 20px; top: 405px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 96px; top: 405px; position: absolute; width: 55px;" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 179px; top: 404px; position: absolute; margin-bottom: 4px;" Text="Delete" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 23px; top: 455px; position: absolute"></asp:Label>
    </form>
</body>
</html>