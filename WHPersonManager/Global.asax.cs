using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using WPMPublicLib.DBManager;
using WPMPublicLib.LogHelper;

namespace WHPersonManager
{
    /// <summary>
    /// 全局程序启动时执行此文件
    /// </summary>
    public class Global : System.Web.HttpApplication
    {

        /// <summary>
        /// IIS启动时执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_Start(object sender, EventArgs e)
        {
            //启动日志配置
            LogHelper.InitLog();
            LogHelper.WriteInfoLog("日志工具初始化完成");
            //初始化数据连接配置
            DbHelper.m_ConnStr = "User Id=jhwhpm;Password=jhwhpm;Data Source=(DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST = 10.10.230.199)(PORT = 1521)))(CONNECT_DATA =(SERVICE_NAME = jhemr)))";
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}