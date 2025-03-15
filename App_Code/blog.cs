using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using System.IO;
using System.Web.Security;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;


/// <summary>
/// Summary description for blog
/// </summary>
public class blog
{
    private const string initVector = "tu89geji340t89u2";
    private const string passPhraseSalt = "OiiOPasswordLock";
    private const int keysize = 256;

    public static string Salt
    {
        get { return passPhraseSalt; }
    }
    public blog()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    #region News
    public string InsertBlog(string iuserId, string blogTitle, string blogDescription, int published, String Image_Name, String Image_Path, string caption1, String Image_Name1, String Image_Path1, string caption2, String Image_Name2, String Image_Path2, string caption3, Byte Blog_Type, Int32 Hit)
    {
        object ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "BlogInsert",
            new SqlParameter("@iuserId", iuserId),
            new SqlParameter("@blogTitle", blogTitle),
            new SqlParameter("@blogDescription", blogDescription),
            new SqlParameter("@publishStatus", published),
           new SqlParameter("@Image_Name", Image_Name),
            new SqlParameter("@Image_Path", Image_Path),
           new SqlParameter("@Caption1", caption1),
            //
            new SqlParameter("@Image_Name_2", Image_Name1),
            new SqlParameter("@Image_Path_2", Image_Path1),
            new SqlParameter("@Caption_2", caption2),
            //
            new SqlParameter("@Image_Name_3", Image_Name2),
           new SqlParameter("@Image_Path_3", Image_Path2),
           new SqlParameter("@Caption_3", caption3),
           new SqlParameter("@Blog_Type", Blog_Type),
            new SqlParameter("@Hit", Hit)
        );
        return Convert.ToString(ret);
    }

    public void UpdateBlog(string blogId, string updatedBy, string blogTitle, string blogDescription, int published, String Image_Name, String Image_Path, string caption1, String Image_Name1, String Image_Path1, string caption2, String Image_Name2, String Image_Path2, string caption3, Byte Blog_Type, Int32 Hit)
    {

        SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "BlogUpdate",
            new SqlParameter("@blogId", blogId),
            new SqlParameter("@blogTitle", blogTitle),
            new SqlParameter("@blogDescription", blogDescription),
            new SqlParameter("@publishStatus", published),
               new SqlParameter("@Image_Name", Image_Name),
              new SqlParameter("@Image_Path", Image_Path),
                   new SqlParameter("@Caption1", caption1),
            //
            new SqlParameter("@Image_Name_2", Image_Name1),
              new SqlParameter("@Image_Path_2", Image_Path1),
              new SqlParameter("@Caption_2", caption2),
            //
              new SqlParameter("@Image_Name_3", Image_Name2),
              new SqlParameter("@Image_Path_3", Image_Path2),
              new SqlParameter("@Caption_3", caption3),
              new SqlParameter("@Blog_Type", Blog_Type),
              new SqlParameter("@Hit", Hit)
       );
    }

    public void DeleteBlog(string blogId)
    {
        SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
           CommandType.StoredProcedure,
           "dae_BlogDelete",
           new SqlParameter("@blogId", blogId)
       );
    }

    public void UpdateBlogApproval(string blogId)
    {
        SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
           CommandType.StoredProcedure,
           "dae_BlogApprovalUpdate",
           new SqlParameter("@blogId", blogId)
       );
    }

    public DataSet SelectBlogsAll()
    {

        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
           CommandType.StoredProcedure,
           "dt_BlogSelectAll"
       );

        return ds;
    }

    public DataSet SelectPublishedBlogsforUser(string iuserId)
    {

        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
           CommandType.StoredProcedure,
           "dae_BlogSelectPublished",
            new SqlParameter("@iuserId", iuserId)
       );

        return ds;
    }
    public DataSet SelectUnpublishedBlogsforUser(string iuserId)
    {

        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
           CommandType.StoredProcedure,
           "dae_BlogSelectUnpublished",
            new SqlParameter("@iuserId", iuserId)
       );

        return ds;
    }

    public DataSet SelectPublishedBlogs()
    {

        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
           CommandType.StoredProcedure,
           "dae_BlogSelectPublishedAll"

       );

        return ds;
    }

    public DataSet SelectUnapprovedBlogsforAdmin()
    {

        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
           CommandType.StoredProcedure,
           "dae_BlogSelectUnpublished"
       );

        return ds;
    }

    public DataSet SelectUnapprovedBlogsforUser()
    {

        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
           CommandType.StoredProcedure,
           "dae_BlogSelectUnpublished"
       );

        return ds;
    }



    public DataSet SelectBlog(string blogId)
    {

        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
           CommandType.StoredProcedure,
           "BlogSelect",
            new SqlParameter("@blogId", blogId)

       );

        return ds;
    }


    public static string Encrypt(string plainText)
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
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);

        }

    }
    public static string Decrypt(string cipherText)
    {
        try
        {

            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            #region for removing space
            cipherText = cipherText.Trim().Replace(" ", "+");
            int len = cipherText.Length % 4;
            if (len > 0)
            {
                cipherText = cipherText.PadRight(cipherText.Length + (4 - len), '=');
            }
            #endregion
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
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);

        }



        //    public bool IsUserExists(string userName, string userPassword)
        //    {
        //            bool isExists = false;
        //            try
        //            {
        //                _userInfo = (from tr in _dbContext.UserInfos
        //                             where tr.LoginName.Trim().ToLower() == userName.Trim().ToLower() && tr.LoginPassword.Trim().ToLower() == userPassword.Trim().ToLower()
        //                             && tr.IsActiveUser == true && tr.IsRemoved == false
        //                             select tr).SingleOrDefault();
        //                // _dbContext.Dispose();

        //                if (_userInfo != null)
        //                {
        //                    isExists = true;
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                throw new Exception(ex.Message, ex);
        //            }

        //            return isExists;

        //        }
        //    }
        //}

    }
}
#endregion
