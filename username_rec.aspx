<%@ Page Language="C#" AutoEventWireup="true" CodeFile="username_rec.aspx.cs" Inherits="username_rec" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" 
            Text="Username Recovery"></asp:Label>
    </p>
    <p>
        Enter recovery E-Mail Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        &nbsp;<asp:TextBox ID="TextBox3" runat="server" Width="208px"></asp:TextBox>
    </p>
    <p style="width: 291px">
        &nbsp;
        <asp:Label ID="Label2" runat="server" BorderColor="Red" ForeColor="Red" 
            Text="E-Mail Address Not Found" Visible="False"></asp:Label>
&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Next" Width="65px" 
            onclick="Button1_Click" />
        </p>
    </form>
</body>
</html>
