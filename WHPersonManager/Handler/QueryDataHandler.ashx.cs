using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WPMPublicLib.HttpHelper;
using WPMPublicLib.DBManager;
using System.Data;

namespace WHPersonManager.Handler
{
    /// <summary>
    /// Handler 的摘要说明
    /// </summary>
    public class QueryDataHandler : IHttpHandler
    {
        private HttpManager m_httpManager = new HttpManager();

        private IDbManager m_dbManager = DbHelper.FactoryDbManager();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/xml;charset=UTF-8";
            RequestMsg requestMsg = null;
            ResponseMsg<DataTable> responseMsg = new ResponseMsg<DataTable>();
            try
            {
                //获取请求消息
                requestMsg = m_httpManager.GetPostMsg(context.Request.InputStream);

                if (requestMsg.m_SqlType != WPMPublicLib.EnumType.SqlType.SELECT)
                {
                    throw new ArgumentException(string.Format("QueryDataHandler 只能执行查询语句。当前错误SQL语句：{0}",requestMsg.m_Sql));
                }
                //执行sql
                DataTable dtRes = m_dbManager.GetDataTable(requestMsg.m_Sql);

                //返回JSON结果
                responseMsg.m_IsSuccess = true;
                responseMsg.m_Msg = "查询成功";
                responseMsg.m_Data = dtRes;
                string jsonRes = m_httpManager.Convert2Json(responseMsg);
                context.Response.Write(jsonRes);
            }
            catch (Exception ex)
            {
                responseMsg.m_IsSuccess = false;
                responseMsg.m_Msg = string.Format("{0}-{1}-{2}-{3}", DateTime.Now, ex.Message, ex.StackTrace, requestMsg == null ? "请求消息获取失败" : requestMsg.m_Sql);
                responseMsg.m_Data = new DataTable();
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
    }
}