<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BidAuction.aspx.cs" Inherits="Subastas.BidAuction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            margin-left: 29px;
        }
    </style>
</head>
<body style="height: 247px; width: 457px">
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SEARCH FOR AUCTIONS</div>
        <p>
            &nbsp;</p>
        <p>
            Category:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_Category" runat="server"></asp:TextBox>
        </p>
        <p>
            Subcategory:&nbsp;
            <asp:TextBox ID="txt_Subcategory" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 50px; margin-top: 25px" Text="Back" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 76px" Text="Accept" />
    </form>
</body>
</html>
