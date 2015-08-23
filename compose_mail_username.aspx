<%@ Page Language="C#" AutoEventWireup="true" CodeFile="compose_mail_username.aspx.cs" Inherits="compose_mail_uername" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p style="width: 211px">
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="260px" Width="210px" Font-Bold="True" Font-Names="Calibri" ForeColor="Black" style="margin-top: 0px"></asp:ListBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Select" />
        </p>
    </form>
</body>
</html>
