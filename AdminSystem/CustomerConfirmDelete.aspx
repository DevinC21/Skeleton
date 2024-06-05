<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

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
    background: url(https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/6cac3c7e-7310-4788-a635-e9e6b224b84d/dhj6p1q-da712693-b86d-44c5-9b3f-12172fb9bbec.gif?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzZjYWMzYzdlLTczMTAtNDc4OC1hNjM1LWU5ZTZiMjI0Yjg0ZFwvZGhqNnAxcS1kYTcxMjY5My1iODZkLTQ0YzUtOWIzZi0xMjE3MmZiOWJiZWMuZ2lmIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.tpNfSMh0ZaoapIu7pZxYZueuQ89xi-cDYqDkUqPFCck) no-repeat;
    background-size: cover;
    background-position: center;
 }

 .ConfirmDelete{
    width: 550px;
    background: transparent;
    border: 2px solid rgba(0, 0, 0, 0.2);
    backdrop-filter: blur(20px);
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
    color: dodgerblue;
    border-radius: 10px;
    padding: 30px 40px;
 }

 .Label{
    font-size: 20px;
    font-weight: 500;
    text-align:center;
 }

 .Buttons{
    display: flex;
    flex-direction: row;
    justify-content: center;
    align-items: center;
    gap: 20px;
    padding-top: 20px;
 }

 </style>

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="ConfirmDelete">

        <div class="Label">
        <asp:Label ID="lblDelete" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
        </div>

        <div class="Buttons">
        <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" Height="30px" Width="80px" />
        <asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" BackColor="Transparent" BorderStyle="Outset" ForeColor="White" Height="30px" Width="80px" />
        </div>

    </div>
    </form>
    </body>
</html>


