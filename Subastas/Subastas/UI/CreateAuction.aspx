<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateAuction.aspx.cs" Inherits="Subastas.CreateAuction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            width: 281px;
            height: 70px;
        }
    </style>
</head>
<body style="height: 417px; width: 544px">
    <form id="form1" runat="server">
    <div>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CREATE SUBASTA</div>
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
        <p>
            Image:</p>
        <asp:Button ID="Button1" runat="server" Height="25px" OnClick="Button1_Click" style="margin-left: 19px; margin-top: 21px" Text="Done" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 27px" Text="Back" Width="41px" />
    </form>
</body>
</html>
