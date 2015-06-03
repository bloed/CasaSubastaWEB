<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WonBidsHistoryUser.aspx.cs" Inherits="Subastas.WonBidsHistoryUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; WON BIDS HISTORY OF USER</div>
        <asp:GridView ID="GridView1" runat="server" style="margin-left: 156px; margin-top: 12px">
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 223px; margin-top: 17px" Text="Back" />
    </form>
</body>
</html>
