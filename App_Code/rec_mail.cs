using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

public class rec_mail
{
	public int r_mail(string receiver,string heading,string body)
	{
		MailMessage mail = new MailMessage();
	        mail.To.Add(receiver);
        	mail.From = new MailAddress("mydaakcompany@gmail.com");
	        mail.Subject = heading;
        	mail.Body = body;
	        mail.IsBodyHtml = true;
        	SmtpClient smtp = new SmtpClient();
	        smtp.Host = "smtp.gmail.com";
        	smtp.Credentials = new System.Net.NetworkCredential("mydaakcompany", "05313664");	
	        smtp.EnableSsl = true;
        	smtp.Send(mail);
            return 1;
	}
    public string ec(string a)
    {
        int n,i,z=1;
        char []b=a.ToCharArray();
        n = a.Length;
        for (i = 0; i < n; i++)
        {
            b[i] = Convert.ToChar(Convert.ToInt32(b[i])+z);
            z++;
        }
        string enc_val=new string(b);
        return enc_val;
    }
    public string dc(string a)
    {
        int n, i, z=1;
        char[] b = a.ToCharArray();
        n = a.Length;
        for (i = 0; i < n; i++)
        {
            b[i] = Convert.ToChar(Convert.ToInt32(b[i]) - z);
            z++;
        }
        string enc_val = new string(b);
        return enc_val;
    }
    public string un_enc(string un, string ps)
    {
        int n,m, i, z = 1;
        char[] a = un.ToCharArray();
        char[] b = ps.ToCharArray();
        n = un.Length;
        for(i=0;i<n;i++)
        {
            a[i] = Convert.ToChar(Convert.ToInt32(a[i]) + Convert.ToInt32(b[i]) + z);
            z++;
        }
        m = ps.Length - un.Length;
        for (i = 0; i < n; i++)
        {
            a[i] = Convert.ToChar(Convert.ToInt32(a[i]) - m);
        }
        string unenc = new string(a);
        return unenc;
    }
}