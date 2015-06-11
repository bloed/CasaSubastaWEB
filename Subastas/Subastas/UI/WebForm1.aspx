<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Subastas.UI.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <div>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; RESTART SUBASTA</div>
        <p>
            Item´s Name:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_ItemName" runat="server"></asp:TextBox>
        </p>
        <p>
            Subcategory:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_SubCategory" runat="server"></asp:TextBox>
        </p>
        <p>
            Category:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_Category" runat="server"></asp:TextBox>
        </p>
        <p>
            Delivery Details:
            <asp:TextBox ID="txt_DeliveryDetails" runat="server"></asp:TextBox>
        </p>
        <p>
            Last Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_LastDate" runat="server"></asp:TextBox>
        </p>
        <p>
            Initial Price:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_InitialPrice" runat="server"></asp:TextBox>
        </p>
        <p>
            Item´s Description:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_ItemDescription" runat="server" Width="380px"></asp:TextBox>
        </p>
        <p id="wtf">
            Image:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:FileUpload ID="up_Image" runat="server" />
        </p>
        <asp:Button ID="Button1" runat="server" Height="25px" OnClick="Button1_Click" style="margin-left: 19px; margin-top: 21px" Text="Done" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 27px" Text="Back" Width="41px" />
    
    </div>
    </form>
</body>
</html>
