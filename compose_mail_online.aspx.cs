using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class compose_mail_extended : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string to, from, subject, body;
        //rec_mail m = new rec_mail();
        //m.r_mail(TextBox1.Text, TextBox3.Text, TextBox2.Text);
        to = TextBox1.Text;
        from = Session["us_name"].ToString() + "@mydaakcompany.com";
        subject = TextBox3.Text;
        body = TextBox2.Text;
        Response.Redirect("http://mecswitchgears.com/sendmailvedu.php?sub=" + subject + "&msg=" + body + "&to=" + to + "&from=" + from);
        Label1.Visible = true;
    }
}