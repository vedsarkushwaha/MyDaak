﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.IO;
using System.Threading;

public partial class msg_content : System.Web.UI.Page
{
    OleDbConnection conn;
    OleDbCommand cmd;
    OleDbDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        String mid = Request.QueryString["val"].ToString();
        conn = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;Password=db_mail;User ID=db_mail");
        conn.Open();
        rec_mail td = new rec_mail();
        cmd = new OleDbCommand("select m_heading,m_body,attachment from messages where m_uid='" + mid + "'", conn);
        dr = cmd.ExecuteReader();
        if (dr.HasRows == true)
        {
            dr.Read();
            if (dr[2].ToString() != "NA")
            {
                LinkButton1.Visible = true;
                LinkButton1.Text = dr[2].ToString();
            }
            Label1.Text =  dr[0].ToString();
            TextBox1.Text = dr[1].ToString();
        }
        else
        {
            Label1.Text = "No Heading and No Body";
        }
        dr.Close();
        conn.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String mid = Request.QueryString["val"].ToString();
        rec_mail td = new rec_mail();
        conn = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;Password=db_mail;User ID=db_mail");
        conn.Open();
        cmd = new OleDbCommand("select senders_address from mail_exchange where m_uid='" + mid + "'", conn);
        dr = cmd.ExecuteReader();
        dr.Read();
        Response.Redirect("Compose_mail.aspx?val=" + dr[0].ToString());
        dr.Close();
        conn.Close();
    }
    private void fileDownload(string fileName, string fileUrl)
    {
        Page.Response.Clear();
        bool success = ResponseFile(Page.Request, Page.Response, fileName, fileUrl, 1024000);
        if (!success)
            Response.Write("Downloading Error!");
        Page.Response.End();
    }
    public static bool ResponseFile(HttpRequest _Request, HttpResponse _Response, string _fileName, string _fullPath, long _speed)
    {
        try
        {
            FileStream myFile = new FileStream(_fullPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            BinaryReader br = new BinaryReader(myFile);
            try
            {
                _Response.AddHeader("Accept-Ranges", "bytes");
                _Response.Buffer = false;
                long fileLength = myFile.Length;
                long startBytes = 0;
                int pack = 10240; //10K bytes
                int sleep = (int)Math.Floor((double)(1000 * pack / _speed)) + 1;
                if (_Request.Headers["Range"] != null)
                {
                    _Response.StatusCode = 206;
                    string[] range = _Request.Headers["Range"].Split(new char[] { '=', '-' });
                    startBytes = Convert.ToInt64(range[1]);
                }
                _Response.AddHeader("Content-Length", (fileLength - startBytes).ToString());
                if (startBytes != 0)
                {
                    _Response.AddHeader("Content-Range", string.Format(" bytes {0}-{1}/{2}", startBytes, fileLength - 1, fileLength));
                }
                _Response.AddHeader("Connection", "Keep-Alive");
                _Response.ContentType = "application/octet-stream";
                _Response.AddHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(_fileName, System.Text.Encoding.UTF8));
                br.BaseStream.Seek(startBytes, SeekOrigin.Begin);
                int maxCount = (int)Math.Floor((double)((fileLength - startBytes) / pack)) + 1;
                for (int i = 0; i < maxCount; i++)
                {
                    if (_Response.IsClientConnected)
                    {
                        _Response.BinaryWrite(br.ReadBytes(pack));
                        Thread.Sleep(sleep);
                    }
                    else
                    {
                        i = maxCount;
                    }
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                br.Close();
                myFile.Close();
            }
        }
        catch
        {
            return false;
        }
        return true;
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        string filename = LinkButton1.Text;// LinkButton1.Text.ToString();
        fileDownload(filename, Server.MapPath("~/app_data/upload/" + filename));
    }
}
