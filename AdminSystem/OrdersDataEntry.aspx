<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    &nbsp;<form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 24px; top: 69px; position: absolute; right: 618px" Text="Order ID" width="139px"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 162px; top: 66px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblOrderFullName" runat="server" style="z-index: 1; left: 22px; top: 109px; position: absolute; width: 139px; height: 24px" Text="Order FullName"></asp:Label>
        <p>
            <asp:TextBox ID="txtOrderDescription" runat="server" style="z-index: 1; left: 161px; top: 151px; position: absolute" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtOrderFullName" runat="server" style="z-index: 1; left: 162px; top: 109px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <asp:Label ID="lblOrderDescription" runat="server" style="z-index: 1; left: 20px; top: 154px; position: absolute; height: 25px" Text="Order Description" width="139px"></asp:Label>
        <p>
            <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 20px; top: 193px; position: absolute; height: 19px" Text="Order Date" width="139px"></asp:Label>
        </p>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 161px; top: 185px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblPayment" runat="server" style="z-index: 1; left: 24px; top: 231px; position: absolute" Text="Payment" width="139px"></asp:Label>
        <asp:TextBox ID="txtPayment" runat="server" style="z-index: 1; left: 160px; top: 230px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblOrderReturn" runat="server" style="z-index: 1; left: 22px; top: 269px; position: absolute" Text="Order Return" width="139px"></asp:Label>
        <asp:TextBox ID="txtOrderReturn" runat="server" style="z-index: 1; left: 162px; top: 270px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblOrderStatus" runat="server" style="z-index: 1; left: 26px; top: 312px; position: absolute" Text="OrderStatus" width="139px"></asp:Label>
        <asp:TextBox ID="txtOrderStatus" runat="server" style="z-index: 1; left: 162px; top: 308px; position: absolute; height: 22px;"></asp:TextBox>
        <asp:CheckBox ID="chkPayment" runat="server" style="z-index: 1; left: 141px; top: 357px; position: absolute" Text="Order Confirmation" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 23px; top: 392px; position: absolute; bottom: 254px;"></asp:Label>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 96px; top: 427px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 25px; top: 426px; position: absolute" Text="OK" OnClick="btnOK_Click1" />
    </form>
</body>
</html>
