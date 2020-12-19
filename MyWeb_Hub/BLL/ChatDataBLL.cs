using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MyWeb_Hub.DAL;
using MyWeb_Hub.Models;

namespace MyWeb_Hub.BLL
{
    public class ChatDataBLL
    {
        /// <summary>
        /// 把聊天数据写入数据库
        /// </summary>
        /// <param name="chatDataModels"></param>
        /// <returns></returns>
        public int AddChatDataBLL(ChatDataModels chatDataModels)
        {
            int a = new ChatDataDLL().AddChatDataDAL(chatDataModels);
            if (a > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public DataTable GetFriendsDataBLL(string sender, string receiver)
        {
            DataSet ds = new ChatDataDLL().QueryChatDataDAL(sender,receiver);
            DataTable dt = ds.Tables[0];
            int len = dt.Rows.Count;

            return dt;
        }
    }
}