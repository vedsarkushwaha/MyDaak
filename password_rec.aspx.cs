using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Net.Mail;

public partial class acc_rec_pass : System.Web.UI.Page
{
    OleDbConnection conn;
    OleDbCommand cmd;
    OleDbDataReader dr;
    string un;
    protected void Button2_Click(object sender, EventArgs e)
    {
        conn = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;Password=db_mail;User ID=db_mail");
        un = TextBox1.Text;
        conn.Open();
        cmd=new OleDbCommand("select security_ques from u_profile where username='" + un + "'",conn);
        dr = cmd.ExecuteReader();
        if (dr.HasRows == false)
            Label3.Visible = true;
        else
        {
            dr.Read();
            Label2.Text = dr["security_ques"].ToString() + "?";
            Label2.Visible = true;
        }
        dr.Close();
        conn.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sec_ans;
        sec_ans = TextBox2.Text;
        un = TextBox1.Text;
        conn = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;Password=db_mail;User ID=db_mail");
        conn.Open();
        cmd = new OleDbCommand("select security_ques_ans from u_profile where username='" + un + "'", conn);
        dr = cmd.ExecuteReader();
        if (dr.HasRows == false)
        {
            Label4.Visible = true;
        }
        else
        {
            dr.Read();
            if (dr["security_ques_ans"].ToString() == sec_ans)
            {
                cmd = new OleDbCommand("select password,alternate_email from username,u_profile where username=user_id and user_id='" + un + "'", conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                string from, to, subject, body;
                //MailMessage mail = new MailMessage();
                //mail.To.Add(dr[1].ToString());
                to = dr[1].ToString();
                //mail.From = new MailAddress("mydaakcompany@gmail.com");
                from = "mydaakcompany@gmail.com";
                //mail.Subject = "Password Recovery";
                subject = "Password Recovery";
                //mail.Body = "Your Password is " + dr["password"].ToString();
                body = "Your Password is " + dr["password"].ToString();
                //mail.IsBodyHtml = true;
                //SmtpClient smtp = new SmtpClient();
                //smtp.Host = "smtp.gmail.com";
                //smtp.Credentials = new System.Net.NetworkCredential("mydaakcompany", "test1234");
                //smtp.EnableSsl = true;
                //smtp.Send(mail);
                Response.Redirect("http://mecswitchgears.com/sendmailvedu.php?sub=" + subject + "&msg=" + body + "&to=" + to + "&from=admin@mydaakcompany");
                Label4.Text = "Your password is sent to your alternate e-mail";
                Label4.Visible = true;

            }
            else
            {
                Label4.Visible = true;
            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
