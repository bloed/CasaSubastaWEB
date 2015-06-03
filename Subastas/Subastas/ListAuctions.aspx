<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListAuctions.aspx.cs" Inherits="Subastas.ListAuctions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 470px; width: 403px">
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LIST AUCTIONS</div>
    &nbsp;<br />
        Category:&nbsp;&nbsp;&nbsp;&nbsp;
        <input id="txt_Category" type="text" /><p>
            Subcategory
            <input id="txt_Subcategory" type="text" /><asp:Button ID="Button1" runat="server" style="margin-left: 37px" Text="List" />
        </p>
        <asp:GridView ID="GridView1" runat="server" style="margin-left: 76px">
        </asp:GridView>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 152px; margin-top: 65px" Text="Back" />
    </form>
</body>
</html>
