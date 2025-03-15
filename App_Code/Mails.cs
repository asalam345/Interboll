using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using System.IO;
using System.Web.Security;

/// <summary>
/// Summary description for Mails
/// </summary>
public class Mails
{
	public Mails()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static void SendMail(string from, string to, string subject, string body)
    {
        string[] toEmail = { to };
        SendMail(from, toEmail, subject, body, "");
    }
    public static void SendMail(string from, string to, string subject, string body, string replyTo)
    {
        string[] toEmail = { to };
        SendMail(from, toEmail, subject, body, replyTo);
    }
    public static void SendMail(string from, string[] to, string subject, string body)
    {
        SendMail(from, to, subject, body, "");
    }

    public static void SendMail(string from, string[] to, string subject, string body, string replyTo)
    {
        //return;

        SmtpClient mailClient = new SmtpClient(ConfigurationManager.AppSettings["SmtpHost"]); //auth.smtp.1and1.co.uk
        //SmtpClient mailClient = new SmtpClient("mail.skydx.com");

        mailClient.UseDefaultCredentials = false;
        //mailClient.Credentials = CredentialCache.DefaultNetworkCredentials;
        mailClient.Credentials = new NetworkCredential(parseEmail(from), ConfigurationManager.AppSettings["SmtpPassword"]);

        //--- Create the mail message

        
        MailMessage mailMessage = new MailMessage();

        foreach (string toMail in to)
        {
            MailAddress toAddress = new MailAddress(toMail);
            mailMessage.To.Add(toAddress);
        }

        MailAddress fromAddress = new MailAddress(from);
        mailMessage.From = fromAddress;
        mailMessage.Subject = subject;
        mailMessage.Body = body;


        if (!string.IsNullOrEmpty(replyTo))
            mailMessage.ReplyTo = new MailAddress(replyTo);
        mailMessage.IsBodyHtml = true;
        mailClient.Send(mailMessage);
    }

    public static string parseEmail(string fullEmail)
    {
        string emailAdd = fullEmail;
        emailAdd = emailAdd.Replace("&lt;", "<");
        emailAdd = emailAdd.Replace("&gt;", ">");
        int posStart = emailAdd.IndexOf("<");
        int posEnd = emailAdd.IndexOf(">");
        if (posStart >= 0 && posEnd > 0)
        {
            emailAdd = emailAdd.Substring(posStart + 1, posEnd - posStart - 1);
        }
        return emailAdd;
    }



    public static void SendEmailVerificationMail(string toEmail, string key)
    {
        try
        {
            //--- Now send a mail to user from admin
            StreamReader objSR = File.OpenText(HttpContext.Current.Server.MapPath(WebsiteConfig.MailTemplateFolder + "emailverify.htm"));
            string filedata = objSR.ReadToEnd();
            objSR.Close();
            filedata = filedata.Replace("#toEmail#", toEmail);
            filedata = filedata.Replace("#key#", key);
            filedata = filedata.Replace("#adminEmail#", WebsiteConfig.AdminEmail);


            Mails.SendMail(WebsiteConfig.NoreplyEmail, toEmail, "Welcome to Loving That Store", filedata);
        }
        catch (Exception ex)
        {
            //Response.Redirect(Page.AppRelativeVirtualPath + "?msg=error");
        }
    }

    public static void SendWelcomeMail(string firstname, string lastname, string userEmail, string password)
    {
        try
        {
            //--- Now send a mail to user from admin
            StreamReader objSR = File.OpenText(HttpContext.Current.Server.MapPath(WebsiteConfig.MailTemplateFolder + "subscribed.htm"));
            string filedata = objSR.ReadToEnd();
            objSR.Close();
            //filedata = filedata.Replace("#name#", txtName.Text.Trim());
            filedata = filedata.Replace("#firstname#", firstname);
            filedata = filedata.Replace("#lastname#", lastname);
            filedata = filedata.Replace("#password#", password);
            filedata = filedata.Replace("#userEmail#", parseEmail(userEmail));
            filedata = filedata.Replace("#login_auth#", CryptoXor.Encode(parseEmail(userEmail)));
            filedata = filedata.Replace("#adminEmail#", parseEmail(WebsiteConfig.AdminEmail));

            Mails.SendMail(WebsiteConfig.NoreplyEmail, userEmail,
               "Thank you for registering at lovingthatdeal.com", filedata, WebsiteConfig.AdminEmail);


            //Response.Redirect(Page.AppRelativeVirtualPath + "?msg=ok");
        }
        catch (Exception ex)
        {
            //Response.Redirect(Page.AppRelativeVirtualPath + "?msg=error");
            //this.Title = ex.ToString();
        }
    }


    public static void SendSubscriptionConfirmMail(string userEmail)
    {
        try
        {
            //--- Now send a mail to user from admin
            StreamReader objSR = File.OpenText(HttpContext.Current.Server.MapPath(WebsiteConfig.MailTemplateFolder + "subscribed.htm"));
            string filedata = objSR.ReadToEnd();
            objSR.Close();
            //filedata = filedata.Replace("#name#", txtName.Text.Trim());
          
            filedata = filedata.Replace("#userEmail#", parseEmail(userEmail));
            filedata = filedata.Replace("#adminEmail#", parseEmail(WebsiteConfig.AdminEmail));

            Mails.SendMail(WebsiteConfig.NoreplyEmail, userEmail,
                "Subscription complete", filedata, WebsiteConfig.AdminEmail);


            //Response.Redirect(Page.AppRelativeVirtualPath + "?msg=ok");
        }
        catch (Exception ex)
        {
            //Response.Redirect(Page.AppRelativeVirtualPath + "?msg=error");
            //this.Title = ex.ToString();
        }
    }


    public static void SendPasswordRecoveryMail(string userName, string password, string userEmail)
    {
        string[] toEmails = { userEmail };

        //--- Now send a mail to user from admin
        StreamReader objSR = File.OpenText(HttpContext.Current.Server.MapPath(WebsiteConfig.MailTemplateFolder + "passrecovery.htm"));
        string filedata = objSR.ReadToEnd();
        objSR.Close();
        filedata = filedata.Replace("#username#", userName);
        filedata = filedata.Replace("#password#", password);
        filedata = filedata.Replace("#email#", userEmail);
        filedata = filedata.Replace("#adminEmail#", parseEmail(WebsiteConfig.AdminEmail));


        Mails.SendMail(WebsiteConfig.AdminEmail, toEmails,
           "Your login information, as requested from lovingthatdeal.com", filedata);

        //Error handed by calling method.
    }


    public static void NotifyAdmin(string subject, string errmessage)
    {
        try
        {
            //--- Now send a mail to user from admin

            Mails.SendMail(WebsiteConfig.NoreplyEmail, WebsiteConfig.AdminEmail,
               subject, errmessage);
        }
        catch (Exception ex)
        {
            //Response.Redirect(Page.AppRelativeVirtualPath + "?msg=error");
        }
    }
}