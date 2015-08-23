using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Drawing;

public partial class Registration_form : System.Web.UI.Page
{
    OleDbConnection conn;
    OleDbCommand cmd;
    OleDbCommand cmd1;
    OleDbDataReader dr;
    OleDbDataReader dr1;
    protected void Button1_Click(object sender, EventArgs e)
    {
        if ((TextBox1.Text == "") || (TextBox10.Text == "") || (TextBox5.Text == "") || (TextBox6.Text == "") || (TextBox7.Text == "") || (TextBox9.Text == ""))
        {
            if (TextBox1.Text == "")
            {
                TextBox1.ForeColor = Color.Red;
                Label1.ForeColor = Color.Red;
            }
            if (TextBox10.Text == "")
            {
                TextBox10.ForeColor = Color.Red;
                Label9.ForeColor = Color.Red;
                //Label13.Visible = true;
            }
            if (TextBox5.Text == "")
            {
                TextBox5.ForeColor = Color.Red;
                Label5.ForeColor = Color.Red;
                //Label13.Visible = true;
            }
            if (TextBox6.Text == "")
            {
                TextBox6.ForeColor = Color.Red;
                Label6.ForeColor = Color.Red;
                //Label13.Visible = true;
            }
            if (TextBox7.Text == "")
            {
                TextBox7.ForeColor = Color.Red;
                Label7.ForeColor = Color.Red;
                //Label13.Visible = true;
            }
            if (TextBox9.Text == "")
            {
                TextBox9.ForeColor = Color.Red;
                Label8.ForeColor = Color.Red;
                //Label13.Visible = true;
            }
            if (TextBox6.Text != TextBox7.Text)
            {
                Label14.Visible = true;
            }
            Label13.Text = "Values of some fields are invalid. Please Check!!!";
            Label13.Visible = true;
        }
        else
        {
            if (CheckBox1.Checked == true)
            {
                conn = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;Password=db_mail;User ID=db_mail");
                conn.Open();
                cmd = new OleDbCommand("insert into u_profile values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + DropDownList2.Text + "','" + TextBox4.Text + "','" + TextBox10.Text + "','" + TextBox5.Text + "','" + DropDownList1.Text + "','" + TextBox9.Text + "','" + DropDownList3.Text + "')", conn);
                dr = cmd.ExecuteReader();
                cmd1 = new OleDbCommand("update username set password='" + TextBox6.Text + "'where user_id='" + TextBox5.Text + "'", conn);
                dr1 = cmd1.ExecuteReader();
                conn.Close();
                Label13.Text = "Account Created";
                Label13.Visible=true;
                Response.Write("<script LANGUAGE='JavaScript' >alert('Account Created');document.location='" + ResolveClientUrl("~/Default.aspx") + "';</script>");
            }
            else
            {
                CheckBox1.Text = "Check This Box!!!";
                CheckBox1.ForeColor = Color.Red;
            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
            TextBox1.ForeColor = Color.Black;
            Label1.ForeColor = Color.Black;
            Label13.Visible = false;
            TextBox10.ForeColor = Color.Black;
            Label9.ForeColor = Color.Black;
            TextBox5.ForeColor = Color.Black;
            Label5.ForeColor = Color.Black;
            TextBox6.ForeColor = Color.Black;
            Label6.ForeColor = Color.Black;
            TextBox7.ForeColor = Color.Black;
            Label7.ForeColor = Color.Black;
            TextBox9.ForeColor = Color.Black;
            Label8.ForeColor = Color.Black;
            Label14.Visible = false;
            CheckBox1.ForeColor = Color.Black;
    }
}