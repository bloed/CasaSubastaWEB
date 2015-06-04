<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Subastas.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles.css" rel="stylesheet" />
    <style type="text/css">
        #Text1 {
            width: 173px;
        }
        #Text2 {
            width: 169px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Casa de Subastas<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (Participants Version)</div>
        <p>
            USERNAME:&nbsp; 
            <asp:TextBox ID="txt_Username" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            PASSWORD:&nbsp;
            <asp:TextBox ID="txt_Password" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btn_Login" runat="server" Height="27px" OnClick="btn_Login_Click" style="margin-left: 160px" Text="LOGIN" Width="67px" />
        </p>
    </form>
</body>
</html>
