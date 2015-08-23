using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class profile_edit : System.Web.UI.Page
{
    OleDbConnection con;
    protected void Page_Load(object sender, EventArgs e)
    {
        string un;
        un = Session["us_name"].ToString();
        con = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;Password=db_mail;User ID=db_mail");
        con.Open();
        OleDbCommand cmd1 = new OleDbCommand("select f_name,l_name,to_char(dob,'dd-mon-yy'),gender,phone_no,alternate_email,username,security_ques,security_ques_ans,location from u_profile where username='" + un + "'", con);
        OleDbDataReader dr1 = cmd1.ExecuteReader();
        dr1.Read();
        TextBox1.Text = dr1[0].ToString();//fname
        TextBox2.Text = dr1[1].ToString();//lname
        TextBox3.Text = dr1[2].ToString();//dob
        TextBox4.Text = dr1[4].ToString();//phone
        TextBox5.Text = dr1[6].ToString();//username
        DropDownList2.Text = dr1[3].ToString();//gender
        DropDownList1.Text = dr1[7].ToString();//security question
        DropDownList3.Text  = dr1[9].ToString();//location
        TextBox10.Text = dr1[5].ToString();//altername e-mail
        TextBox9.Text = dr1[8].ToString(); //security question answer
        dr1.Close();
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string un;
        un = Session["us_name"].ToString();
        con = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;Password=db_mail;User ID=db_mail");
        con.Open();
        OleDbCommand cmd1 = new OleDbCommand("update u_profile set f_name='" + TextBox1.Text  + "',l_name='"+ TextBox2.Text + "',dob='" + TextBox3.Text  + "',gender='" + DropDownList2.Text  + "',phone_no=" + TextBox4.Text  + ",alternate_email='" + TextBox10.Text + "',location='" + DropDownList3.Text  + "' where username='" + un + "'", con);
        OleDbDataReader dr1 = cmd1.ExecuteReader();
        dr1.Close();
        con.Close();
        //Response.Write(un);
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}