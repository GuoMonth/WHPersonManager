using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WPMPublicLib.DBManager;
using WPMPublicLib.EnumType;
using WPMPublicLib.HttpHelper;
using WPMPublicLib.LogHelper;

namespace WHPersonManager.Handler
{
    /// <summary>
    /// ExecuteNonSqlHandler 的摘要说明
    /// </summary>
    public class ExecuteNonSqlHandler : IHttpHandler
    {
        private HttpManager m_httpManager = new HttpManager();

        private IDbManager m_dbManager = DbHelper.FactoryDbManager();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/xml;charset=UTF-8";

            RequestMsg requestMsg = null;
            ResponseMsg<int> responseMsg = new ResponseMsg<int>();

            try
            {
                //获取请求消息
                requestMsg = m_httpManager.GetPostMsg(context.Request.InputStream);

                if (requestMsg.m_SqlType == WPMPublicLib.EnumType.SqlType.SELECT)
                {
                    throw new ArgumentException(string.Format("ExecuteNonSqlHandler 不能执行查询语句。当前错误SQL语句：{0}", requestMsg.m_Sql));
                }

                //执行sql
                string resMsg = ExecuteNonQuery(requestMsg.m_Sql,requestMsg.m_SqlType);

                //返回JSON结果
                int resNum;
                responseMsg.m_IsSuccess = int.TryParse(resMsg,out resNum);
                responseMsg.m_Msg = resMsg;
                responseMsg.m_Data = resNum;
                string jsonRes = m_httpManager.Convert2Json(responseMsg);
                context.Response.Write(jsonRes);
            }
            catch (Exception ex)
            {
                responseMsg.m_IsSuccess = false;
                responseMsg.m_Msg = string.Format("{0}-{1}-{2}-{3}", DateTime.Now, ex.Message, ex.StackTrace, requestMsg == null ? "请求消息获取失败" : requestMsg.m_Sql);
                responseMsg.m_Data = -110;
                string jsonRes = m_httpManager.Convert2Json(responseMsg);
                context.Response.Write(jsonRes);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        private string ExecuteNonQuery(string sql, SqlType sqlType)
        {
            string resMsg = string.Empty;
            switch (sqlType)
            {
                case SqlType.INSERT:
                    resMsg = m_dbManager.InsertData(sql);
                    break;
                case SqlType.UPDATE:
                    resMsg = m_dbManager.UpdateData(sql);
                    break;
                case SqlType.DELETE:
                    resMsg = m_dbManager.DeleteData(sql);
                    break;
                default:
                    resMsg = "不支持此类型SQL";
                    break;
            }
            return resMsg;
        }
    }
}