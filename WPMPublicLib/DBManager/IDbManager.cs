using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WPMPublicLib.DBManager
{
    /// <summary>
    /// 通过sql获取数据库数据
    /// </summary>
    /// <param name="querySql">查询sql，不包含参数</param>
    /// <returns>查询结果</returns>
    public interface IDbManager
    {
        /// <summary>
        /// 通过sql获取数据库数据
        /// </summary>
        /// <param name="querySql">查询sql，不包含参数</param>
        /// <returns>查询结果</returns>
        DataTable GetDataTable(string querySql);

        /// <summary>
        /// 通过sql获取数据库数据
        /// </summary>
        /// <param name="querySql">查询sql，包含参数</param>
        /// <param name="objects">sql中的参数</param>
        /// <returns>查询结果</returns>
        DataTable GetDataTable(string querySql, object[] objects);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deleteSql"></param>
        /// <returns></returns>
        string DeleteData(string deleteSql);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deleteSql"></param>
        /// <param name="objects"></param>
        /// <returns></returns>
        int DeleteData(string deleteSql, object[] objects);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="insertSql"></param>
        /// <returns></returns>
        string InsertData(string insertSql);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="insertSql"></param>
        /// <param name="objects"></param>
        /// <returns></returns>
        int InsertData(string insertSql, object[] objects);

        /// <summary>
        /// 插入数据
        /// 支持多张表同时插入数据，表名由DataSet中的Table的TableName对应，字段名要和数据库列名保持一致（顺序也要一致）
        /// 事务一致：要么整体都插入成功，否则全部回滚。
        /// </summary>
        /// <param name="insertData">待插入到数据库的数据集合。</param>
        /// <returns>影响的行数（插入的记录数）</returns>
        int InsertData(DataSet insertData);

        string UpdateData(string updateSql);

        int UpdateData(string updateSql, object[] objects);
    }
}
