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
using System.Text;

[System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService 
{
    string conString = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
    string CurrentUserId = System.Web.HttpContext.Current.Session["CurrentUserId"] != null ? System.Web.HttpContext.Current.Session["CurrentUserId"].ToString() : string.Empty;
    string setBlankImagePath = "USERPANEL/img/upload/blank_user.png";

    [WebMethod(EnableSession = true)]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public bool AddNewMessage(string u_idTo, string message)
    {
        bool InsertData;
        using (SqlConnection con = new SqlConnection(conString))
        {
            using (SqlCommand cmd0 = new SqlCommand("spUser_Message_Insert_Check_Friend_ChatBoxOpen", con))
            {
                cmd0.CommandType = CommandType.StoredProcedure;
                cmd0.Parameters.AddWithValue("@u_id", CurrentUserId);
                cmd0.Parameters.AddWithValue("@u_friendId", u_idTo);

                if (con.State == ConnectionState.Closed) con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(selectCommand: cmd0);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                if (dt.Rows.Count == 0)
                {
                    using (SqlCommand cmd = new SqlCommand("spMessage_Insert", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@u_idFrom", CurrentUserId);
                        cmd.Parameters.AddWithValue("@u_idTo", u_idTo);
                        cmd.Parameters.AddWithValue("@m_textMessage", message);
                        cmd.Parameters.AddWithValue("@m_attachFile", null);
                        cmd.Parameters.AddWithValue("@m_fileName", null);
                        cmd.Parameters.AddWithValue("@m_fileExtension", null);
                        cmd.Parameters.AddWithValue("@m_sendReceiveStatus", true);
                        cmd.Parameters.AddWithValue("@m_readUnreadStatus", false);
                        cmd.Parameters.AddWithValue("@isRemovedFrom", false);
                        cmd.Parameters.AddWithValue("@isRemovedTo", false);

                        if (con.State == ConnectionState.Closed) con.Open();
                        int Result = cmd.ExecuteNonQuery();
                        if (Result > 0) InsertData = true;
                        else InsertData = false;
                        return InsertData;
                    }
                }
                else
                {
                    using (SqlCommand cmd1 = new SqlCommand("spMessage_Insert", con))
                    {
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@u_idFrom", CurrentUserId);
                        cmd1.Parameters.AddWithValue("@u_idTo", u_idTo);
                        cmd1.Parameters.AddWithValue("@m_textMessage", message);
                        cmd1.Parameters.AddWithValue("@m_attachFile", null);
                        cmd1.Parameters.AddWithValue("@m_fileName", null);
                        cmd1.Parameters.AddWithValue("@m_fileExtension", null);
                        cmd1.Parameters.AddWithValue("@m_sendReceiveStatus", true);
                        cmd1.Parameters.AddWithValue("@m_readUnreadStatus", true);
                        cmd1.Parameters.AddWithValue("@isRemovedFrom", false);
                        cmd1.Parameters.AddWithValue("@isRemovedTo", false);

                        if (con.State == ConnectionState.Closed) con.Open();
                        int Result = cmd1.ExecuteNonQuery();
                        if (Result > 0) InsertData = true;
                        else InsertData = false;
                        return InsertData;
                    }
                }
            }
        } 
    }

    [WebMethod(EnableSession = true)]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public List<GetMessage> GetMessageShow(string u_idTo)
    {
        List<GetMessage> com = new List<GetMessage>();
        using (SqlConnection con = new SqlConnection(conString))
        {
            using (SqlCommand cmd = new SqlCommand("spMessage_View", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@u_idFrom", CurrentUserId);
                cmd.Parameters.AddWithValue("@u_idTo", u_idTo);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        string getImagePathFrom;
                        if (rdr["u_fromPhoto"].ToString() != string.Empty)
                        {
                            getImagePathFrom = rdr["u_fromPhoto"].ToString();
                        }
                        else
                        {
                            getImagePathFrom = setBlankImagePath;
                        }
                        string getImagePathTo;
                        if (rdr["u_toPhoto"].ToString() != string.Empty)
                        {
                            getImagePathTo = rdr["u_toPhoto"].ToString();
                        }
                        else
                        {
                            getImagePathTo = setBlankImagePath;
                        }
                        com.Add(new GetMessage
                        {
                            u_idFrom = rdr["u_idFrom"].ToString(),
                            u_idTo = rdr["u_idTo"].ToString(),
                            m_textMessage = rdr["m_textMessage"].ToString(),
                            u_fromPhoto = getImagePathFrom,
                            u_toPhoto = getImagePathTo,
                            createdDate = rdr["createdDate"].ToString()
                        });
                    }
                }
            }
        }
        return com;
    }

    [WebMethod(EnableSession = true)]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public List<GetOnlineFriendList> GetOnlineFriendListShow()
    {
        List<GetOnlineFriendList> com = new List<GetOnlineFriendList>();
        using (SqlConnection con = new SqlConnection(conString))
        {
            using (SqlCommand cmd = new SqlCommand("spUser_FriendList_Show", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@u_id", CurrentUserId);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        string getImagePath;
                        if (rdr["Profile_Image"].ToString() != string.Empty)
                        {
                            getImagePath = rdr["Profile_Image"].ToString();
                        }
                        else
                        {
                            getImagePath = setBlankImagePath;
                        }
                        com.Add(new GetOnlineFriendList
                        {
                            f_id = rdr["f_id"].ToString(),
                            u_id = rdr["u_id"].ToString(),
                            u_friendId = rdr["u_friendId"].ToString(),
                            First_Name = rdr["First_Name"].ToString(),
                            Last_Name = rdr["Last_Name"].ToString(),
                            isOnline = rdr["isOnline"].ToString(),
                            Profile_Image = getImagePath,
                            isBusy = rdr["isBusy"].ToString()
                        });
                    }
                }
            }
        }
        return com;
    }


    [WebMethod(EnableSession = true)]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public List<GetOnlineFriendMessageList> GetOnlineFriendMessageListShow()
    {
        List<GetOnlineFriendMessageList> com = new List<GetOnlineFriendMessageList>();
        using (SqlConnection con = new SqlConnection(conString))
        {
            using (SqlCommand cmd = new SqlCommand("spUser_MessageUserNotifyOnline_Show", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@u_id", CurrentUserId);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        string getImagePath;
                        if (rdr["Profile_Image"].ToString() != string.Empty)
                        {
                            getImagePath = rdr["Profile_Image"].ToString();
                        }
                        else
                        {
                            getImagePath = setBlankImagePath;
                        }
                        com.Add(new GetOnlineFriendMessageList
                        {
                            u_idFrom = rdr["u_idFrom"].ToString(),
                            u_idTo = rdr["u_idTo"].ToString(),
                            count_message = rdr["count_message"].ToString(),
                            First_Name = rdr["First_Name"].ToString(),
                            Last_Name = rdr["Last_Name"].ToString(),
                            Profile_Image = getImagePath,
                            isOnline = rdr["isOnline"].ToString(),
                            isBusy = rdr["isBusy"].ToString()
                        });
                    }
                }
            }
        }
        return com;
    }

    [WebMethod(EnableSession = true)]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public List<GetOnlineFriendListCount> GetOnlineFriendListCount()
    {
        List<GetOnlineFriendListCount> com = new List<GetOnlineFriendListCount>();
        using (SqlConnection con = new SqlConnection(conString))
        {
            using (SqlCommand cmd = new SqlCommand("spUser_FriendListOnlineCount_Show", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@u_id", CurrentUserId);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        com.Add(new GetOnlineFriendListCount
                        {
                            onlineUser = rdr["onlineUser"].ToString()
                        });
                    }
                }
            }
        }
        return com;
    }

    [WebMethod(EnableSession = true)]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public List<GetOnlineFriendMessageUserCount> GetOnlineFriendMessageUserCount()
    {
        List<GetOnlineFriendMessageUserCount> com = new List<GetOnlineFriendMessageUserCount>();
        using (SqlConnection con = new SqlConnection(conString))
        {
            using (SqlCommand cmd = new SqlCommand("spUser_MessageUserNotifyOnlineCount_Show", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@u_id", CurrentUserId);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        com.Add(new GetOnlineFriendMessageUserCount
                        {
                            onlineUser = rdr["onlineUser"].ToString()
                        });
                    }
                }
            }
        }
        return com;
    }

   
    [WebMethod(EnableSession = true)]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public void AddNewChatWindow(string u_friendId)
    {
        using (SqlConnection con = new SqlConnection(conString))
        {
            using (SqlCommand cmd = new SqlCommand("sptbUser_ChatBox_Open_Check_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@u_id", CurrentUserId);
                cmd.Parameters.AddWithValue("@u_friendId", u_friendId);

                if (con.State == ConnectionState.Closed) con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(selectCommand: cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                
                if(dt.Rows.Count == 0)
                {
                    using (SqlCommand cmd1 = new SqlCommand("sptbUser_ChatBox_Open_Insert", con))
                    {
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@u_id", CurrentUserId);
                        cmd1.Parameters.AddWithValue("@u_friendId", u_friendId);
                        cmd1.Parameters.AddWithValue("@u_isBoxActive", true);
                        cmd1.Parameters.AddWithValue("@isRemoved", false);

                        if (con.State == ConnectionState.Closed) con.Open();
                        cmd1.ExecuteNonQuery();
                    }
                }
                else
                {
                    using (SqlCommand cmd2 = new SqlCommand("sptbUser_ChatBox_Open_Update", con))
                    {
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@u_id", CurrentUserId);
                        cmd2.Parameters.AddWithValue("@u_friendId", u_friendId);
                        cmd2.Parameters.AddWithValue("@u_isBoxActive", true);

                        if (con.State == ConnectionState.Closed) con.Open();
                        cmd2.ExecuteNonQuery();
                    }
                }
            }
        }

        using (SqlConnection con = new SqlConnection(conString))
        {
            using (SqlCommand cmd = new SqlCommand("spUser_update_online_busy", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@u_id", CurrentUserId);
                cmd.Parameters.AddWithValue("@isBusy", true);

                if (con.State == ConnectionState.Closed) con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        using (SqlConnection con = new SqlConnection(conString))
        {
            using (SqlCommand cmd = new SqlCommand("spUser_MessageRead_Update", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@u_id", CurrentUserId);
                cmd.Parameters.AddWithValue("@u_friendId", u_friendId);

                if (con.State == ConnectionState.Closed) con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }


    [WebMethod(EnableSession = true)]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public List<ChatBoxOpenList> ChatBoxOpen()
    {
        List<ChatBoxOpenList> com = new List<ChatBoxOpenList>();
        using (SqlConnection con = new SqlConnection(conString))
        {
            using (SqlCommand cmd = new SqlCommand("sptbUser_ChatBox_Open_All", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@u_id", CurrentUserId);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        string getImagePath;
                        if(rdr["Profile_Image"].ToString() != string.Empty)
                        {
                            getImagePath = rdr["Profile_Image"].ToString();
                        }
                        else
                        {
                            getImagePath = setBlankImagePath;
                        }
                        com.Add(new ChatBoxOpenList
                        {
                            box_id = rdr["box_id"].ToString(),
                            u_id = rdr["u_id"].ToString(),
                            u_friendId = rdr["u_friendId"].ToString(),
                            u_friendIdEncrypt = blog.Encrypt(rdr["u_friendId"].ToString()),
                            Profile_Image = getImagePath,
                            First_Name = rdr["First_Name"].ToString(),
                            Last_Name = rdr["Last_Name"].ToString()
                        });
                    }
                }
            }
        }
        return com;
    }

    [WebMethod(EnableSession = true)]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public void ChatBoxClose(string u_friendId)
    {
        using (SqlConnection con = new SqlConnection(conString))
        {
            using (SqlCommand cmd = new SqlCommand("sptbUser_ChatBox_Open_Update", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@u_id", CurrentUserId);
                cmd.Parameters.AddWithValue("@u_friendId", u_friendId);
                cmd.Parameters.AddWithValue("@u_isBoxActive", false);
                
                if (con.State == ConnectionState.Closed) con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        using (SqlConnection con = new SqlConnection(conString))
        {
            using (SqlCommand cmd = new SqlCommand("spUser_update_online_busy", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@u_id", CurrentUserId);
                cmd.Parameters.AddWithValue("@isBusy", false);

                if (con.State == ConnectionState.Closed) con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

public class GetOnlineFriendList
{
    public string f_id { get; set; }
    public string u_id { get; set; }
    public string u_friendId { get; set; }
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
    public string isOnline { get; set; }
    public string Profile_Image { get; set; }
    public string isBusy { get; set; }
}

public class GetOnlineFriendMessageList
{
    public string u_idFrom { get; set; }
    public string u_idTo { get; set; }
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
    public string Profile_Image { get; set; }
    public string count_message { get; set; }
    public string isOnline { get; set; }
    public string isBusy { get; set; }
}

public class GetOnlineFriendListCount
{
    public string onlineUser { get; set; }
}

public class GetOnlineFriendMessageUserCount
{
    public string onlineUser { get; set; }
}

public class ChatBoxOpenList
{
    public string box_id { get; set; }
    public string u_id { get; set; }
    public string u_friendId { get; set; }
    public string u_friendIdEncrypt { get; set; }
    public string Profile_Image { get; set; }
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
}

public class GetMessage
{
    public string u_idFrom { get; set; }
    public string u_idTo { get; set; }
    public string m_textMessage { get; set; }
    public string u_fromPhoto { get; set; }
    public string u_toPhoto { get; set; }
    public string createdDate { get; set; }
}