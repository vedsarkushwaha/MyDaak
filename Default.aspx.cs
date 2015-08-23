using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class _Default : System.Web.UI.Page 
{
    OleDbConnection conn;
    OleDbCommand cmd;
    OleDbDataReader dr;
    protected void Button1_Click(object sender, EventArgs e)
    {
        conn = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;Password=db_mail;User ID=db_mail");
        string u_name, password;
        u_name = TextBox1.Text;
        password = TextBox2.Text;
        rec_mail rr = new rec_mail();
        string comp=rr.un_enc(u_name, password);
        //u_name = raw_u_name + password[2];
        //Response.Write(u_name);
        conn.Open();
        cmd=new OleDbCommand ("select enc_fun(user_id,password) from username where user_id='"+ u_name +"'",conn);
        dr = cmd.ExecuteReader();
        //dr.Read();
        //Response.Write(raw_u_name + dr["password"].ToString()[2]);
        if (dr.HasRows == false)
            Label2.Visible = true;
        else
        {
            dr.Read();

            if (dr[0].ToString() == comp)
            {
                Session["us_name"] = u_name;
                Response.Redirect("Mail_box.aspx");
            }
            else
                Label2.Visible = true;
        }
        dr.Close();
        conn.Close();
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}