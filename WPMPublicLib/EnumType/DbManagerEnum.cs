using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPMPublicLib.EnumType
{
    /// <summary>
    /// sql文类型
    /// </summary>
    public enum SqlType
    {
        /// <summary>
        /// 查询语句sql
        /// </summary>
        SELECT = 1,

        /// <summary>
        /// 插入语句sql
        /// </summary>
        INSERT = 2,

        /// <summary>
        /// 更新语句sql
        /// </summary>
        UPDATE = 3,

        /// <summary>
        /// 删除语句sql
        /// </summary>
        DELETE = 4
    }
}
