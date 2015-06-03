<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BidsHistoryProduct.aspx.cs" Inherits="Subastas.BidsHistoryProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; BIDS HISTORY OF PRODUCT</div>
        <asp:GridView ID="GridView1" runat="server" style="margin-left: 90px; margin-top: 32px">
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 145px; margin-top: 68px" Text="Back" />
    </form>
</body>
</html>
