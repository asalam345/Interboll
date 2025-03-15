using System;
using System.IO;
using System.Net;
using System.Web;
using System.Linq;
using System.Data;
using System.Text;
using System.Web.UI;
using System.Drawing;
using System.Net.Mail;
using System.Collections;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Security.Cryptography;

public class GameDbContext : System.Web.UI.Page
{
    /*---------------------------Database Connection String Section-------------------*/

    private string dbConnectionString = WebConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;

    /*---------------------------Form To Storeprocedure Section-------------------*/

    public void SaveData_StoredProcedure(string storedProcedureName, ArrayList storedProcedureParameters)
    {
        using (SqlConnection conn = new SqlConnection(dbConnectionString))
        {
            using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < storedProcedureParameters.Count; i++)
                {
                    cmd.Parameters.Add(storedProcedureParameters[i]);
                }
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void HitCounterSaveUpdate_StoredProcedure(string storedProcedureName)
    {
        using (SqlConnection conn = new SqlConnection(dbConnectionString))
        {
            using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void UpdateData_StoredProcedure(string storedProcedureName, ArrayList storedProcedureParameters)
    {
        using (SqlConnection conn = new SqlConnection(dbConnectionString))
        {
            using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < storedProcedureParameters.Count; i++)
                {
                    cmd.Parameters.Add(storedProcedureParameters[i]);
                }
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void DeleteData_StoredProcedure(string storedProcedureName, ArrayList storedProcedureParameters)
    {
        using (SqlConnection conn = new SqlConnection(dbConnectionString))
        {
            using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < storedProcedureParameters.Count; i++)
                {
                    cmd.Parameters.Add(storedProcedureParameters[i]);
                }
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

    public DataTable GetSelectedData_StoredProcedure(string storedProcedureName, ArrayList storedProcedureParameters)
    {
        using (SqlConnection conn = new SqlConnection(dbConnectionString))
        {
            using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < storedProcedureParameters.Count; i++)
                {
                    cmd.Parameters.Add(storedProcedureParameters[i]);
                }
                SqlDataAdapter sda = new SqlDataAdapter(selectCommand: cmd);
                DataTable dt = new DataTable();
                conn.Open();
                sda.Fill(dt);
                return dt;
            }
        }
    }

    public DataTable GetAllData_StoredProcedure(string storedProcedureName)
    {
        using (SqlConnection conn = new SqlConnection(dbConnectionString))
        {
            using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(selectCommand: cmd);
                DataTable dt = new DataTable();
                conn.Open();
                sda.Fill(dt);
                return dt;
            }
        }
    }

    /*---------------------------Form To SQL Section-------------------*/

    public void SaveData_SqlTable(string tableName, ArrayList tableValues)
    {
        using (SqlConnection conn = new SqlConnection(dbConnectionString))
        {
            string getValues = null;
            for (int i = 0; i < tableValues.Count; i++)
            {
                getValues += tableValues[i];
            }
            string sqlQuery = "insert into " + tableName + " values(" + getValues + ")";
            using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
            {
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void UpdateData_SqlTable(string tableName, ArrayList tableParameters, ArrayList tableValues, string id, int idValue)
    {
        for (int i = 0; i < tableParameters.Count; i++)
        {
            using (SqlConnection conn = new SqlConnection(dbConnectionString))
            {
                string sqlQuery = "update " + tableName + " set " + tableParameters[i] + " = " + tableValues[i] + " where " + id + " = " + idValue;
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

    /*---------------------------Image Upload Section-------------------*/

    public string Upload_ImagePath(HttpPostedFile getFile, string getSavePath)
    {
        try
        {
            string filePath = null, fileName = null, fileType = null, fileExtention = null, imageName = null;
            int getLength_KB = 350; //350KB
            int fileLength = 0, setGetLength = 0;
            setGetLength = getLength_KB * 1024;
            fileName = getFile.FileName;
            fileExtention = Path.GetExtension(fileName);
            fileLength = getFile.ContentLength;
            fileType = getFile.ContentType.ToLower();

            if (fileType == "image/jpg" || fileType == "image/jpeg" || fileType == "image/png" || fileType == "image/gif")
            {
                if (fileLength < setGetLength)
                {
                    imageName = "I"+ DateTime.Now.ToString("yyyyMMddhhmmssfff") + fileExtention;
                    getFile.SaveAs(Server.MapPath(getSavePath + "/" + imageName));
                    filePath = getSavePath + "/" + imageName;
                    return filePath;
                }
                else
                {
                    filePath = "Sorry! Image must be less then " + getLength_KB + " KB !!!";
                    return filePath;
                }
            }
            else
            {
                filePath = "Sorry! Image must be in jpg/jpeg/png/gif !!!";
                return filePath;
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public string Upload_ImagePath_A(HttpPostedFile getFile, string getSavePath)
    {
        try
        {
            string filePath = null, fileName = null, fileType = null, fileExtention = null, imageName = null;
            int getLength_KB = 1024; //1024KB
            int fileLength = 0, setGetLength = 0;
            setGetLength = getLength_KB * 1024;
            fileName = getFile.FileName;
            fileExtention = Path.GetExtension(fileName);
            fileLength = getFile.ContentLength;
            fileType = getFile.ContentType.ToLower();

            if (fileType == "image/jpg" || fileType == "image/jpeg" || fileType == "image/png" || fileType == "image/gif")
            {
                if (fileLength < setGetLength)
                {
                    imageName = "IA" + DateTime.Now.ToString("yyyyMMddhhmmssff") + fileExtention;
                    getFile.SaveAs(Server.MapPath(getSavePath + "/" + imageName));
                    filePath = getSavePath + "/" + imageName;
                    return filePath;
                }
                else
                {
                    filePath = "Sorry! Image must be less then " + getLength_KB + " KB !!!";
                    return filePath;
                }
            }
            else
            {
                filePath = "Sorry! Image must be in jpg/jpeg/png/gif !!!";
                return filePath;
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public string Upload_ImagePath_B(HttpPostedFile getFile, string getSavePath)
    {
        try
        {
            string filePath = null, fileName = null, fileType = null, fileExtention = null, imageName = null;
            int getLength_KB = 1024; //1024KB
            int fileLength = 0, setGetLength = 0;
            setGetLength = getLength_KB * 1024;
            fileName = getFile.FileName;
            fileExtention = Path.GetExtension(fileName);
            fileLength = getFile.ContentLength;
            fileType = getFile.ContentType.ToLower();

            if (fileType == "image/jpg" || fileType == "image/jpeg" || fileType == "image/png" || fileType == "image/gif")
            {
                if (fileLength < setGetLength)
                {
                    imageName = "IB" + DateTime.Now.ToString("yyyyMMddhhmmssff") + fileExtention;
                    getFile.SaveAs(Server.MapPath(getSavePath + "/" + imageName));
                    filePath = getSavePath + "/" + imageName;
                    return filePath;
                }
                else
                {
                    filePath = "Sorry! Image must be less then " + getLength_KB + " KB !!!";
                    return filePath;
                }
            }
            else
            {
                filePath = "Sorry! Image must be in jpg/jpeg/png/gif !!!";
                return filePath;
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public string Upload_ImagePath_C(HttpPostedFile getFile, string getSavePath)
    {
        try
        {
            string filePath = null, fileName = null, fileType = null, fileExtention = null, imageName = null;
            int getLength_KB = 1024; //1024KB
            int fileLength = 0, setGetLength = 0;
            setGetLength = getLength_KB * 1024;
            fileName = getFile.FileName;
            fileExtention = Path.GetExtension(fileName);
            fileLength = getFile.ContentLength;
            fileType = getFile.ContentType.ToLower();

            if (fileType == "image/jpg" || fileType == "image/jpeg" || fileType == "image/png" || fileType == "image/gif")
            {
                if (fileLength < setGetLength)
                {
                    imageName = "IC" + DateTime.Now.ToString("yyyyMMddhhmmssff") + fileExtention;
                    getFile.SaveAs(Server.MapPath(getSavePath + "/" + imageName));
                    filePath = getSavePath + "/" + imageName;
                    return filePath;
                }
                else
                {
                    filePath = "Sorry! Image must be less then " + getLength_KB + " KB !!!";
                    return filePath;
                }
            }
            else
            {
                filePath = "Sorry! Image must be in jpg/jpeg/png/gif !!!";
                return filePath;
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public string Upload_ImagePath_D(HttpPostedFile getFile, string getSavePath)
    {
        try
        {
            string filePath = null, fileName = null, fileType = null, fileExtention = null, imageName = null;
            int getLength_KB = 1024; //1024KB
            int fileLength = 0, setGetLength = 0;
            setGetLength = getLength_KB * 1024;
            fileName = getFile.FileName;
            fileExtention = Path.GetExtension(fileName);
            fileLength = getFile.ContentLength;
            fileType = getFile.ContentType.ToLower();

            if (fileType == "image/jpg" || fileType == "image/jpeg" || fileType == "image/png" || fileType == "image/gif")
            {
                if (fileLength < setGetLength)
                {
                    imageName = "ID" + DateTime.Now.ToString("yyyyMMddhhmmssff") + fileExtention;
                    getFile.SaveAs(Server.MapPath(getSavePath + "/" + imageName));
                    filePath = getSavePath + "/" + imageName;
                    return filePath;
                }
                else
                {
                    filePath = "Sorry! Image must be less then " + getLength_KB + " KB !!!";
                    return filePath;
                }
            }
            else
            {
                filePath = "Sorry! Image must be in jpg/jpeg/png/gif !!!";
                return filePath;
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public string Upload_Video_A(HttpPostedFile getFile, string getSavePath)
    {
        try
        {
            string filePath = null, fileName = null, fileType = null, fileExtention = null, videoName = null;
            int getLength_MB = 100; //100MB
            int fileLength = 0, setGetLength = 0;
            setGetLength = getLength_MB * 1024 * 1024;
            fileName = getFile.FileName;
            fileExtention = Path.GetExtension(fileName);
            fileLength = getFile.ContentLength;
            fileType = getFile.ContentType.ToLower();

            if (fileType == "video/mp4")
            {
                if (fileLength < setGetLength)
                {
                    videoName = "VA" + DateTime.Now.ToString("yyyyMMddhhmmssff") + fileExtention;
                    getFile.SaveAs(Server.MapPath(getSavePath + "/" + videoName));
                    filePath = getSavePath + "/" + videoName;
                    return filePath;
                }
                else
                {
                    filePath = "Sorry! Video must be less then " + getLength_MB + " MB !!!";
                    return filePath;
                }
            }
            else
            {
                filePath = "Sorry! Video must be in mp4 !!!";
                return filePath;
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    /*---------------------------Password or String Security Section-------------------*/

    private string initVector = "tu89geji340t89u2";
    private string passPhraseSalt = "OiiOPasswordLock";
    private int keysize = 256;

    public string StringEncrypt(string plainText)
    {
        try
        {
            byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhraseSalt, null);
            byte[] keyBytes = password.GetBytes(keysize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] cipherTextBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            return Convert.ToBase64String(cipherTextBytes);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public string StringDecrypt(string cipherText)
    {
        try
        {
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            cipherText = cipherText.Trim().Replace(" ", "+");
            int len = cipherText.Length % 4;
            if (len > 0)
            {
                cipherText = cipherText.PadLeft(cipherText.Length + (4 - len), '+');
            }
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhraseSalt, null);
            byte[] keyBytes = password.GetBytes(keysize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
        }
        catch (Exception)
        {
            throw;
        }
    }

    /*---------------------------E-Mail Send Section-------------------*/

    private string mailFromDefault = "customerservice@oiiostudy.com";
    private string mailFromPassword = "oiio@2016bd";
    private string mailSecureServer = "smtpout.asia.secureserver.net";
    private int mailSecureServerPort = 25;

    public void EmailSend_To_Subject_Body(string mailTo, string mailSubject, string mailBody)
    {
        try
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(mailTo.Trim());
            mailMessage.Subject = mailSubject;
            mailMessage.Body = mailBody;
            mailMessage.From = new MailAddress(mailFromDefault);
            mailMessage.IsBodyHtml = true;
            mailMessage.Priority = MailPriority.High;
            SmtpClient smtpClient = new SmtpClient(mailSecureServer, mailSecureServerPort);
            smtpClient.EnableSsl = false;
            smtpClient.Credentials = new NetworkCredential(mailFromDefault, mailFromPassword);
            smtpClient.Send(mailMessage);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void EmailSend_To_Subject_Body_AttachmentA(string mailTo, string mailSubject, string mailBody, string attachmentPathA)
    {
        try
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(mailTo.Trim());
            mailMessage.Subject = mailSubject;
            mailMessage.Body = mailBody;
            mailMessage.From = new MailAddress(mailFromDefault);
            mailMessage.IsBodyHtml = true;
            mailMessage.Priority = MailPriority.High;
            mailMessage.Attachments.Add(new Attachment(Server.MapPath(attachmentPathA)));
            SmtpClient smtpClient = new SmtpClient(mailSecureServer, mailSecureServerPort);
            smtpClient.EnableSsl = false;
            smtpClient.Credentials = new NetworkCredential(mailFromDefault, mailFromPassword);
            smtpClient.Send(mailMessage);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void EmailSend_To_From_Subject_Body(string mailTo, string mailFrom, string mailSubject, string mailBody)
    {
        try
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(mailTo.Trim());
            mailMessage.Subject = mailSubject;
            mailMessage.Body = mailBody;
            mailMessage.From = new MailAddress(mailFrom.Trim());
            mailMessage.IsBodyHtml = true;
            mailMessage.Priority = MailPriority.High;
            SmtpClient smtpClient = new SmtpClient(mailSecureServer, mailSecureServerPort);
            smtpClient.EnableSsl = false;
            smtpClient.Credentials = new NetworkCredential(mailFromDefault, mailFromPassword);
            smtpClient.Send(mailMessage);
        }
        catch (Exception)
        {
            throw;
        }
    }
}