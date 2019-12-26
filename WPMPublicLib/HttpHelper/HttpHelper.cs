using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Data;
using System.IO;
using Newtonsoft.Json;


namespace WPMPublicLib.HttpHelper
{
    public class HttpHelper
    {
        private static string m_url;

        private static HttpManager m_httpManager;

        /// <summary>
        /// 初始化函数
        /// 在程序启动时，读取相关配置文件，完成初始化
        /// </summary>
        /// <param name="url"></param>
        public static void Init(string url)
        {
            m_url = url;
            m_httpManager = new HttpManager();

            //TODO：检查网络是否通畅

        }

        /// <summary>
        /// 访问后台执行查询SQL
        /// </summary>
        /// <param name="url"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static ResponseMsg<DataTable> ExecuteQuery(string sql)
        {
            RequestMsg requestMsg = new RequestMsg();
            requestMsg.m_Sql = sql;
            requestMsg.m_SqlType = EnumType.SqlType.SELECT;
            requestMsg.m_Data = new DataTable();
            return m_httpManager.PostMessage<DataTable>(m_url + "QueryDataHandler.ashx", requestMsg);
        }

        /// <summary>
        /// 访问后台 执行 删除、插入、更新SQL
        /// </summary>
        /// <param name="url"></param>
        /// <param name="sql"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static ResponseMsg<int> ExecuteNonQuery(string sql, DataTable dt)
        {
            RequestMsg requestMsg = new RequestMsg();
            requestMsg.m_Sql = sql;
            sql = sql.Trim().ToUpper();
            if(sql.StartsWith("INSERT"))
                requestMsg.m_SqlType = EnumType.SqlType.INSERT;
            else if (sql.StartsWith("DELETE"))
                requestMsg.m_SqlType = EnumType.SqlType.DELETE;
            else if(sql.StartsWith("UPDATE"))
                requestMsg.m_SqlType = EnumType.SqlType.UPDATE;
            else
                requestMsg.m_SqlType = EnumType.SqlType.SELECT;
            requestMsg.m_Data = dt ?? new DataTable();
            return m_httpManager.PostMessage<int>(m_url + "ExecuteNonSqlHandler.ashx", requestMsg);
        }
    }
}
