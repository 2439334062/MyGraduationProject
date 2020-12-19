using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MyWeb_Hub.DAL
{
    public class GroupChatDAL
    {
        public int AddRoomDAL(string roomName, string UserName)
        {
            if (GetOnly(roomName,UserName ))
            {
                string sql1 = "insert into [Chat].[dbo].[GroupChat] ([roomName],[userName],[Time]) values('{0}','{1}','{2}')";
                sql1 = string.Format(sql1, roomName, UserName, DateTime.Now.ToString());
                int a = SqlHelper.GetNonQuery(sql1);
                if (a > 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 3;
            }
        }
        public bool GetOnly(string roomName, string UserName)
        {
            string sql = "SELECT *  FROM [Chat].[dbo].[GroupChat]   where roomName='" + roomName + "' and userName ='"+UserName+"'";
            DataSet ds = SqlHelper.GetDataSet(sql);
            DataTable dt = ds.Tables[0];
            int n = dt.Rows.Count;
            if (n > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}