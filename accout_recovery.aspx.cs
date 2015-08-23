'''n
'''n
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class accout_recovery : System.Web.UI.Page
{
    public string urload;
   
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (RadioButton2.Checked  == true)
            urload = "username_rec.aspx";
        else if (RadioButton3.Checked  == true)
            urload = "password_rec.aspx";
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
