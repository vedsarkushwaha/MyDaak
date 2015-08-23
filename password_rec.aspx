<%@ Page Language="C#" AutoEventWireup="true" CodeFile="password_rec.aspx.cs" Inherits="acc_rec_pass" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" 
            Text="Password Recovery"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Enter Username&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;         
        <asp:TextBox ID="TextBox1" runat="server" Width="135px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" BorderColor="Red" ForeColor="Red" 
            Text="E-Mail Address Not Found" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Next" 
            style="margin-left: 0px" />
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;Answer&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
&nbsp;<asp:Label ID="Label4" runat="server" BorderColor="Red" ForeColor="Red" 
            Text="Wrong Answer" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Next" Width="65px" 
            onclick="Button1_Click" />
    </p>
    </form>
    <p>
&nbsp;
    </p>
</body>
</html>
