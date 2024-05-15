<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 20px; top: 30px; position: absolute; right: 618px" Text="Order ID" width="139px"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 160px; top: 30px; position: absolute" width="128px"></asp:TextBox>

        <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 360px; top: 30px; position: absolute; height: 26px;" Text="Find" OnClick="btnFind_Click" />

        <asp:Label ID="lblOrderFullName" runat="server" style="z-index: 1; left: 20px; top: 60px; position: absolute; width: 139px; height: 24px" Text="Order FullName"></asp:Label>
        <asp:TextBox ID="txtOrderFullName" runat="server" style="z-index: 1; left: 160px; top: 60px; position: absolute" width="128px"></asp:TextBox>

        <asp:Label ID="lblOrderDescription" runat="server" style="z-index: 1; left: 20px; top: 90px; position: absolute; height: 25px" Text="Order Description" width="139px"></asp:Label>
        <asp:TextBox ID="txtOrderDescription" runat="server" style="z-index: 1; left: 160px; top: 90px; position: absolute" width="128px"></asp:TextBox>

        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 20px; top: 120px; position: absolute; height: 19px" Text="Order Date" width="139px"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 160px; top: 120px; position: absolute" width="128px"></asp:TextBox>

        <asp:Label ID="lblOrderReturn" runat="server" style="z-index: 1; left: 20px; top: 150px; position: absolute" Text="Order Return" width="139px"></asp:Label>
        <asp:TextBox ID="txtOrderReturn" runat="server" style="z-index: 1; left: 160px; top: 150px; position: absolute" width="128px"></asp:TextBox>

        <asp:Label ID="lblOrderStatus" runat="server" style="z-index: 1; left: 20px; top: 180px; position: absolute" Text="OrderStatus" width="139px"></asp:Label>
        <asp:TextBox ID="txtOrderStatus" runat="server" style="z-index: 1; left: 160px; top: 180px; position: absolute; height: 22px;" width="128px"></asp:TextBox>

        <asp:CheckBox ID="chkPayment" runat="server" OnCheckedChanged="chkPayment_CheckedChanged"  style="z-index: 1; left: 160px; top: 210px; position: absolute" Text="Payment Confirmation" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 20px; top: 240px; position: absolute; bottom: 254px;"></asp:Label>

        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 100px; top: 270px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 20px; top: 270px; position: absolute; " Text="OK" OnClick="btnOK_Click1" />
    </form>
</body>
</html>