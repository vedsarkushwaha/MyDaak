<%@ Page Language="C#" AutoEventWireup="true" CodeFile="profile_edit.aspx.cs" Inherits="profile_edit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
    <div style="height: 620px; width: 550pt; margin-left: 0px" dir="ltr">
    
        <br />
        <asp:Label ID="Label10" runat="server" Font-Bold="False" Font-Size="X-Large" 
            Font-Underline="True" Text="USER PROFILE"></asp:Label>
        <br />
        <br />
        <br />
        <br />
    
        <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="D. O. B"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        (Ex. 19-mar-92)<br />
        <br />
        <asp:Label ID="Label11" runat="server" Text="Gender"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" 
            onselectedindexchanged="DropDownList2_SelectedIndexChanged">
            <asp:ListItem Selected="True">m</asp:ListItem>
            <asp:ListItem>f</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Phone No"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Text="Alternate E-mail"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox10" runat="server" Width="149px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="User Name"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Enabled="False"></asp:TextBox>
        <br />
        &nbsp;<br />
        <asp:Label ID="Label8" runat="server" Text="Security Question"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged" Enabled="False" 
           >
            <asp:ListItem>Who is your first crush ?</asp:ListItem>
            <asp:ListItem>What is your first pet name ?</asp:ListItem>
            <asp:ListItem>Which is your birth place ?</asp:ListItem>
            <asp:ListItem>Write your own Question ?</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox9" runat="server" Width="192px" Enabled="False"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label12" runat="server" Text="Location"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList3" runat="server"> <asp:ListItem>Afganishtan</asp:ListItem>
            <asp:ListItem>Albania</asp:ListItem>
            <asp:ListItem>Algeria</asp:ListItem>
            <asp:ListItem>Anglo</asp:ListItem>
            <asp:ListItem>Australia</asp:ListItem>
            <asp:ListItem>Bangladesh</asp:ListItem>
            <asp:ListItem>Canada</asp:ListItem>
            <asp:ListItem>India</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Update" 
            onclick="Button1_Click" />
        </div>
    </form>
</body>
</html>
