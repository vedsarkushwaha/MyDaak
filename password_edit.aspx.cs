using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class password_edit : System.Web.UI.Page
{
    OleDbConnection conn;
    OleDbCommand cmd;
    OleDbDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        conn = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;Password=db_mail;User ID=db_mail");
        string u_name, password;
        password = TextBox1.Text;
        u_name = Session["us_name"].ToString();
        conn.Open();
        cmd = new OleDbCommand("select password from username where user_id='" + u_name + "'", conn);
        dr = cmd.ExecuteReader();
        if (dr.HasRows == false)
            Label2.Visible = true;
        else
        {
            dr.Read();
            if (dr["password"].ToString() == password.ToString())
            {
                cmd = new OleDbCommand("update username set password='" + TextBox2.Text + "' where user_id='" + u_name + "'", conn);
                dr = cmd.ExecuteReader();
                Response.Write("<script LANGUAGE='JavaScript' >alert('password Changed');document.location='" + ResolveClientUrl("~/mail_box.aspx") + "';</script>");
            }
            else 
                Label2.Visible = true;
        }
        dr.Close();
        conn.Close();
    }
}
