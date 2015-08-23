using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using System.Collections;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class inbox_sent : System.Web.UI.Page
{
    OleDbConnection conn;
    OleDbDataReader dr;
    OleDbCommand cmd;
    string e_name, page_type;
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataSource = getdatatable();
        GridView1.DataBind();
    }

    private DataTable getdatatable()
    {
        page_type = Request.QueryString["val"].ToString();
        e_name = Session["us_name"].ToString();
        conn = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;Password=db_mail;User ID=db_mail");
        conn.Open();
        DataTable test = new DataTable("test");
        DataColumn c2 = new DataColumn("Date");
        DataColumn c3 = new DataColumn();
        DataColumn c4 = new DataColumn("Heading");
        DataColumn c5 = new DataColumn("Status");
        DataColumn c1 = new DataColumn("M_UID");
        
        //HyperLinkColumn c6 = new HyperLinkColumn();
        test.Columns.Add(c1);
        test.Columns.Add(c2);
        test.Columns.Add(c3);
        test.Columns.Add(c4);
        rec_mail td = new rec_mail();
        
        if (page_type == "inb")
        {
            cmd = new OleDbCommand("select receiving_date,senders_address,m_heading,b.m_uid from mail_exchange a,messages b where a.m_uid=b.m_uid and (a.m_uid NOT IN (select m_uid from draft)) and receivers_address='" +e_name + "'", conn);
            c3.ColumnName = "Sender";
        }
        else if (page_type == "sen")
        {
            cmd = new OleDbCommand("select sending_date,receivers_address,m_heading,b.m_uid,status from mail_exchange a,messages b where a.m_uid=b.m_uid and (a.m_uid NOT IN (select m_uid from draft)) and senders_address='" + e_name+ "'", conn);
            c3.ColumnName = "Receiver";
            test.Columns.Add(c5);
        }
        else if (page_type == "dra")
        {
            cmd = new OleDbCommand("select m_modified_date,receivers_address,m_heading,b.m_uid from mail_exchange a,messages b, draft c where a.m_uid=b.m_uid and b.m_uid=c.m_uid and senders_address='" + e_name + "'", conn);
            c3.ColumnName = "Receiver";
        }
        GridView1.DataSource = test;
        GridView1.DataBind();
        dr = cmd.ExecuteReader();
        if (dr.HasRows == true)
        {
            while (dr.Read())
            {
                DataRow r1 = test.NewRow();
                r1[1] = dr[0].ToString();
                r1[2] = dr[1].ToString();
                r1[3] = dr[2].ToString();
                r1[0] = dr[3].ToString();
                if (page_type == "sen")
                {
                    r1[4] = dr[4].ToString();
                    //r1[5] = dr[5].ToString();
                    //HyperLinkColumn(r1[5]);
                }
                //else
                //    r1[4] = td.enc(dr[4].ToString());`
                test.Rows.Add(r1);
            }
        }
        return test;
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string a = (GridView1.SelectedRow.Cells[1].Text).ToString();
        OleDbDataReader drr;
        if (page_type == "inb")
        {
            cmd = new OleDbCommand("update messages set status='read' where m_uid=" + a, conn);
            drr = cmd.ExecuteReader();
        }
        Response.Redirect("msg_content.aspx?val=" + a);
    }
}