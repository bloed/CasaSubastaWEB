<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AuctionHistoryUse.aspx.cs" Inherits="Subastas.AuctionHistoryUse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; AUCTION HISTORY OF USER</div>
        <asp:GridView ID="GridView1" runat="server" style="margin-left: 140px; margin-top: 17px">
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 200px; margin-top: 16px" Text="Button" />
    </form>
</body>
</html>
