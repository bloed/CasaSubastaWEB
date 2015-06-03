<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuAll.aspx.cs" Inherits="Subastas.MenuAll" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="width: 313px; height: 288px">
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; OTHER</div>
        <asp:Button ID="Button1" runat="server" style="margin-left: 54px" Text="List Auctions" OnClick="Button1_Click" />
        <p>
            <asp:Button ID="Button4" runat="server" style="margin-left: 54px" Text="Bids History Of Product" OnClick="Button4_Click" />
        </p>
        <asp:Button ID="Button2" runat="server" style="margin-left: 54px" Text="Auctions History Of User" OnClick="Button2_Click" />
        <p>
            <asp:Button ID="Button3" runat="server" style="margin-left: 54px" Text="Won Bids History of User" OnClick="Button3_Click" />
        </p>
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" style="margin-left: 54px" Text="Back" />
    </form>
</body>
</html>
