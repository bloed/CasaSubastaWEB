<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RestartAuction.aspx.cs" Inherits="Subastas.RestartAuction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 434px; width: 526px">
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; RESTART AUCTIONS</div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 70px; margin-top: 368px" Text="Back" />
        <asp:Button ID="btn_Restart" runat="server" OnClick="btn_Restart_Click" style="margin-left: 91px" Text="Restart" />
    </form>
</body>
</html>
