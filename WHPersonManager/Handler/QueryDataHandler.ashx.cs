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

            //获取sql
            string sql = m_httpManager.GetPostMsg(context.Request.InputStream);
            //执行sql
            DataTable dtRes = m_dbManager.GetDataTable(sql);
            //返回JSON结果
            string jsonRes = m_httpManager.Convert2Json(dtRes);

            context.Response.Write(jsonRes);
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