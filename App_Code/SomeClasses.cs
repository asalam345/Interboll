using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SomeClasses
/// </summary>
public class SomeClasses
{
    public string GenerateCharecter()
    {
        string strPwdchar = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string strPwd = "";
        Random rnd = new Random();
        for (int i = 0; i <= 20; i++)
        {
            int iRandom = rnd.Next(5, strPwdchar.Length - 1);
            strPwd += strPwdchar.Substring(iRandom, 1);
        }
        return strPwd;

    }
}


public class tbDomain
{
    public long Id { set; get; }
    public string Name { set; get; }
    public string Charecter { set; get; }
    public DateTime RegDate { set; get; }
}

public class tbUserDomainAgreement
{
    public long Id { set; get; }
    public long DomainId { set; get; }
    public long UserId { set; get; }
    public DateTime ADate { set; get; }
}

public class tbUser
{
    public long Id { set; get; }
    public string First_Name { set; get; }
    public string Last_Name { set; get; }
    public string LoginName { set; get; }//email
    public string Profile_Image { set; get; }
    public int U_Gender { set; get; }
}

