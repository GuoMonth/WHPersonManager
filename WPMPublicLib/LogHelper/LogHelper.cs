using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPMPublicLib.LogHelper
{
    /// <summary>
    /// 日志帮助类
    /// <see cref="https://www.cnblogs.com/lsgsanxiao/p/5845300.html"/>
    /// </summary>
    public class LogHelper
    {
        /// <summary>
        /// 静态只读实体对象info信息
        /// </summary>
        public static readonly log4net.ILog Loginfo = log4net.LogManager.GetLogger("loginfo");

        /// <summary>
        ///  静态只读实体对象error信息
        /// </summary>
        public static readonly log4net.ILog Logerror = log4net.LogManager.GetLogger("logerror");

        /// <summary>
        /// 初始化日志配置
        /// </summary>
        public static void InitLog()
        {
            var path = System.IO.Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "log4net.config");
            var fi = new System.IO.FileInfo(path);
            log4net.Config.XmlConfigurator.Configure(fi);
        }

        /// <summary>
        ///  添加info信息
        /// </summary>
        /// <param name="info">自定义日志内容说明</param>
        public static void WriteInfoLog(string info)
        {
            try
            {
                if (Loginfo.IsInfoEnabled)
                {
                    Loginfo.Info(info);
                }
            }
            catch(Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// 添加异常信息
        /// </summary>
        /// <param name="info">自定义日志内容说明</param>
        /// <param name="ex">异常信息</param>
        public static void WriteErrorLog(string info, Exception ex)
        {
            try
            {
                if (Logerror.IsErrorEnabled)
                {
                    Logerror.Error(info, ex);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 添加异常信息
        /// </summary>
        /// <param name="info">自定义日志内容说明</param>
        public static void WriteErrorLog(string info)
        {
            try
            {
                if (Logerror.IsErrorEnabled)
                {
                    Logerror.Error(info);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

