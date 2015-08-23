using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class compose_mail_uername : System.Web.UI.Page
{
    OleDbConnection conn;
    OleDbDataReader dr;
    OleDbCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        conn = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;Password=db_mail;User ID=db_mail");
        conn.Open();
        cmd = new OleDbCommand("select username from u_profile", conn);
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            ListBox1.Items.Add(dr[0].ToString());
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string un;
        un = ListBox1.SelectedValue.ToString();
        Response.Redirect("compose_mail.aspx?val=" + un);
        ListBox1.Items.Clear();
    }
}