using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPMPublicLib.DBManager
{
    /// <summary>
    /// 获取数据库访问类
    /// </summary>
    public class DbHelper
    {
        /// <summary>
        /// 数据库链接串 设置，修改
        /// </summary>
        public static string m_ConnStr
        {
            get;
            set;
        }

        /// <summary>
        /// 获取当前连接串对应的数据库帮助类
        /// </summary>
        /// <returns></returns>
        public static IDbManager FactoryDbManager()
        { 
            //根据数据库链接串加载不同数据库驱动实现的帮助类
            //目前只有一个数据库驱动类实现，直接返回
            return new DbManager(m_ConnStr);
        }
    }
}
