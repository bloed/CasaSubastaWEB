<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetIdentification.aspx.cs" Inherits="Subastas.GetIdentification" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 181px; width: 328px">
    <form id="form1" runat="server">
    <div style="height: 55px">
    
    </div>
        <p>
            Identification:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_Id" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" style="margin-left: 90px" Text="Accept" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 23px" Text="Back" />
    </form>
</body>
</html>
