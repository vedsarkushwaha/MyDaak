using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Net.Mail;

public partial class username_rec : System.Web.UI.Page
{
    OleDbConnection conn;
    OleDbDataReader dr;
    OleDbCommand cmd;
    protected void Button1_Click(object sender, EventArgs e)
    {
        string rec_acc;
        string to, from, subject, body;
        string un, ps;
        conn = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;Password=db_mail;User ID=db_mail");
        rec_acc = TextBox3.Text;
        conn.Open();
        cmd = new OleDbCommand("select password,user_id from username,u_profile where username.user_id=u_profile.username and alternate_email='" + rec_acc + "'" , conn);
        dr = cmd.ExecuteReader();
        if (dr.HasRows == false)
            Label2.Visible = true;
        else
        {
            dr.Read();
            un = dr["user_id"].ToString();
            ps = dr["password"].ToString();
            MailMessage mail = new MailMessage();
            //mail.To.Add(rec_acc);
            to = rec_acc;
            //mail.From = new MailAddress("mydaakcompany@gmail.com");
            from = "admin@mydaakcompany.com";
            //mail.Subject = "Account Recovery";
            subject = "Username Recovery";
            //mail.Body = "Your username is " + un; //+ " and Password is " + ps;
            body = "Your username is " + un; //+ " and Password is " + ps;
            //mail.IsBodyHtml = true;
            //SmtpClient smtp = new SmtpClient();
            //smtp.Host = "smtp.gmail.com";
            //smtp.Credentials = new System.Net.NetworkCredential("mydaakcompany", "05313664");
            //smtp.EnableSsl = true;
            //smtp.Send(mail);
            Response.Redirect("http://mecswitchgears.com/sendmailvedu.php?sub=" + subject + "&msg=" + body + "&to=" + to + "&from=admin@mydaakcompany");
                
        }
    }
}