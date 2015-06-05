<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ParticipantsMenu.aspx.cs" Inherits="Subastas.ParticipantsMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 35px;
        }
    </style>
</head>
<body style="height: 336px; width: 318px">
    <form id="form1" runat="server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PARTICIPANTS<p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btn_StartAuction" runat="server" OnClick="Button1_Click" style="margin-left: 100px" Text="Start Auction" />
        </p>
        <asp:Button ID="btn_RestartAuction" runat="server" style="margin-left: 100px" Text="Restart Auction" OnClick="btn_RestartAuction_Click" />
        <p>
            <asp:Button ID="btn_Bid" runat="server" style="margin-left: 99px; height: 26px;" Text="Bid" Width="59px" OnClick="btn_Bid_Click" />
        </p>
        <p>
            <asp:Button ID="btn_More" runat="server" style="margin-left: 100px" Text="More" OnClick="btn_More_Click" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" style="margin-left: 99px" Text="Comment your sales" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 102px" Text="Comment your wins" />
        </p>
    </form>
</body>
</html>
