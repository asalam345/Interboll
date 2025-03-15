
<%@ WebService Language="C#" Class="Service" %>

using System;
using System.Web;
using System.Data;
using System.Linq;
using System.Web.Services;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Web.Script.Services;
using System.Web.Services.Protocols;

[System.Web.Script.Services.ScriptService]
public class Service : System.Web.Services.WebService 
{
    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public List<Profile> GetAutoCompleteData(string getPrefixData)
    {
        List<Profile> list = new List<Profile>();
        
        string conString = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
        using (SqlConnection conn = new SqlConnection(conString))
        {
            using (SqlCommand cmd = new SqlCommand("spAutoCompleteTextBox", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SearchText", getPrefixData);
                conn.Open();
                
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        Profile profile = new Profile();
                        profile.Name = string.Format("{0}", sdr["getResult"]);
                        profile.Picture = string.Format("{0}", sdr["profile_image"]);
                        list.Add(profile);
                        //list.Add(string.Format("{0}", sdr["getResult"]));
                        //list.Add(string.Format("{0}", sdr["profile_image"]));
                    }
                }
                conn.Close();
            }
        }
        //return list.ToArray();
        return list;
    }



    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string[] GetAutoCompleteData1(string getPrefixData)
    {
        List<string> list = new List<string>();
        string conString = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
        using (SqlConnection conn = new SqlConnection(conString))
        {
            using (SqlCommand cmd = new SqlCommand("spAutoCompleteTextBox1", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SearchText", getPrefixData);
                conn.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        list.Add(string.Format("{0}", sdr["getResult"]));
                    }
                }
                conn.Close();
            }
        }
        return list.ToArray();
    }
}

public class Profile
{
    public string Name { set; get; }
    public string Picture { set; get; }
}