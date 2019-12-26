using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPMPublicLib.HttpHelper
{

    /// <summary>
    /// 后台响应返回的消息
    /// </summary>
    public class ResponseMsg<T>
    {
        /// <summary>
        /// True:操作成功
        /// False：操作失败
        /// </summary>
        public bool m_IsSuccess { get; set; }

        /// <summary>
        /// 后台返回的提示信息
        /// </summary>
        public string m_Msg { get; set; }

        /// <summary>
        /// 后台返回的数据
        /// </summary>
        public T m_Data { get; set; }
    }
}
