using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class Compose_mail : System.Web.UI.Page
{
    OleDbConnection conn;
    OleDbDataReader dr;
    OleDbCommand cmd;
    public static string file_name;
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        if (Request.QueryString["val"].ToString() != "na")
        {
            TextBox1.Text = Request.QueryString["val"].ToString();
            Button4.Visible = false;
            Button5.Visible = false;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string raw,s_add,  message, heading,muid;
        string[] r_add = new string[100];
        int i;
        s_add = Session["us_name"].ToString();
        raw = TextBox1.Text;
        heading = TextBox3.Text;
        message = TextBox2.Text;
        r_add=raw.Split(',');
        rec_mail te = new rec_mail();
        conn = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;Password=db_mail;User ID=db_mail");
        conn.Open();
        if (file_name == null)
            file_name = "NA";
        cmd = new OleDbCommand("insert into messages values(m_id.nextval,'" + heading + "','" + message + "','" + file_name + "',sysdate,sysdate,'delivered')", conn);
        dr = cmd.ExecuteReader();
        dr.Close();
        for (i = 0; i < r_add.Length; i++)
        {
            cmd = new OleDbCommand("insert into mail_exchange values('" + s_add + "',m_id.currval,sysdate,sysdate,'" + r_add[i].ToString() + "')", conn);
            dr = cmd.ExecuteReader();
        }
        dr.Close();
        cmd = new OleDbCommand("select m_id.currval from dual", conn);
        dr = cmd.ExecuteReader();
        dr.Read();
        muid=dr[0].ToString();
        dr.Close();
        conn.Close();
        Label1.Text = "Message Sent. Your message id is " +muid;
        Label1.Visible = true;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string s_add, r_add, message, heading,muid;
        s_add = Session["us_name"].ToString();
        r_add = TextBox1.Text;
        heading = TextBox3.Text;
        message = TextBox2.Text;
        rec_mail te = new rec_mail();
        conn = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;Password=db_mail;User ID=db_mail");
        conn.Open();
        cmd = new OleDbCommand("insert into messages values(m_id.nextval,'" + heading + "','" + message + "'," + file_name + "',sysdate,sysdate,'Draft')", conn);
        dr = cmd.ExecuteReader();
        cmd = new OleDbCommand("insert into mail_exchange values('" + s_add + "',m_id.currval,sysdate,sysdate,'" + r_add + "')", conn);
        dr = cmd.ExecuteReader();
        cmd = new OleDbCommand("insert into draft values(m_id.currval)", conn);
        dr = cmd.ExecuteReader();
        dr.Close();
        cmd = new OleDbCommand("select m_id.currval from dual", conn);
        dr = cmd.ExecuteReader();
        dr.Read();
        muid = dr[0].ToString();
        dr.Close();
        conn.Close();
        Label1.Text = "Message Saved. Your message id is " + muid;
        Label1.Visible = true;
        dr.Close();
        conn.Close();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string file_adr;
        FileUpload1.Visible = true;
        if (FileUpload1.HasFile)
            try
            {
                file_adr = "C:\\Users\\Vedsar\\Documents\\Visual Studio 2012\\Projects\\My_daak\\App_Data\\Upload\\" + FileUpload1.FileName;
                FileUpload1.SaveAs(file_adr);
                file_name = FileUpload1.FileName;
                Label1.Text = "Uploaded File Name: " +
                    FileUpload1.PostedFile.FileName +
                    "<br />File Size: " +
                    FileUpload1.PostedFile.ContentLength +
                    "<br />File Type: " +
                    FileUpload1.PostedFile.ContentType;
            }
            catch (Exception ex)
            {
                Label1.Text = "Error occured: " + ex.Message.ToString();
            }
        else
        {
            Label1.Text = "Select a file for upload";
        }
        Label1.Visible = true;
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("compose_mail_username.aspx");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("compose_mail_online.aspx");
    }
}