
﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="accout_recovery.aspx.cs" Inherits="accout_recovery" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1
        {
            height: 362px;
            width: 752px;
            margin-right: 656px;
        }
        
        #frm
        {
            height: 270px;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <p style="font-size: xx-large">
        Explain the Problem!!!</p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<iframe id="frm" frameborder="1" src="<% =urload %>" align="right" 
        width="450"></iframe>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <div style="width: 738px; height: 284px; margin-bottom: 0px;">
       
       
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="grp" 
            Text="Trouble with username" />
        <br />
        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="grp" 
            Text="Trouble with password" />
        <br />
        <asp:RadioButton ID="RadioButton4" runat="server" GroupName="grp" 
            Text="Others" />
        <br />
        <br />
        <br />
       
       
    <asp:Button ID="Button2" runat="server" Text="Next" Width="51px" 
               onclick="Button2_Click" />
   
    </div>
    </form>
</body>
</html>
