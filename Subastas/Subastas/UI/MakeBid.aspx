<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MakeBid.aspx.cs" Inherits="Subastas.MakeBid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 362px; width: 431px">
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; MAKE BID</div>
        <p>
            Amount:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_Amount" runat="server"></asp:TextBox>
        </p>
        <p id="lbl_ItemDescription">
            Item description:
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 35px; margin-top: 157px" Text="Back" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 53px" Text="Accept" />
    </form>
</body>
</html>
