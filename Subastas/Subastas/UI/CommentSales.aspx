<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CommentSales.aspx.cs" Inherits="Subastas.UI.CommentSales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; COMMENT YOUR SALES</div>
        <asp:GridView ID="GridView1" runat="server" style="margin-left: 97px; margin-top: 23px">
        </asp:GridView>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Auction Id:<asp:TextBox ID="txt_Id" runat="server" style="margin-left: 16px"></asp:TextBox>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Comment:&nbsp;<asp:TextBox ID="txt_Comment" runat="server" style="margin-left: 19px"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" style="margin-left: 91px" Text="Comment" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 101px" Text="Back" />
    </form>
</body>
</html>
