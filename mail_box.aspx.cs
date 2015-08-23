using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class mail_box : System.Web.UI.Page
{
    public string urload;
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Session["us_name"].ToString();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Remove("us_name");
        Response.Redirect("Default.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("profile_edit.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("password_edit.aspx");
    }
}