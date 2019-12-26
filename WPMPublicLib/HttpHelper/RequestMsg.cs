using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using WPMPublicLib.EnumType;

namespace WPMPublicLib.HttpHelper
{
    /// <summary>
    /// 发送到后台的请求消息
    /// </summary>
    public class RequestMsg
    {
        /// <summary>
        /// 发送到后台的SQL文
        /// </summary>
        public string m_Sql { get; set; }

        /// <summary>
        /// 指示SQL的类型
        /// </summary>
        public SqlType m_SqlType { get; set; }

        /// <summary>
        /// 发送到后台的数据
        /// </summary>
        public DataTable m_Data { get; set; }
    }
}
