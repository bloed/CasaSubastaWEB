<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CommentWins.aspx.cs" Inherits="Subastas.UI.CommentWins" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; COMMENT YOUR WINS</div>
        <asp:GridView ID="GridView1" runat="server" style="margin-left: 100px; margin-top: 13px">
        </asp:GridView>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Auction Id:<asp:TextBox ID="txt_Id" runat="server" style="margin-left: 6px"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Comment:<asp:TextBox ID="txt_Comment" runat="server" style="margin-left: 10px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 103px" Text="Back" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 94px" Text="Comment" />
        <br />
        <br />
    </form>
</body>
</html>
