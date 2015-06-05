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
        <asp:GridView ID="_Grid" runat="server" style="margin-left: 90px; margin-top: 32px">
        </asp:GridView>
        <asp:Label ID="Label1" runat="server" Text="Auction ID"></asp:Label>
        <asp:TextBox ID="_txt_ID" runat="server" style="margin-left: 38px; margin-top: 32px" Width="117px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="_btn_List" runat="server" OnClick="_btn_List_Click" style="margin-left: 22px" Text="List" Width="60px" />
        <p style="height: 97px">
            <asp:Button ID="_btn_Back" runat="server" OnClick="_btn_Back_Click" style="margin-left: 150px" Text="Back" />
        </p>
    </form>
</body>
</html>
