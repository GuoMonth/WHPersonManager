﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using WPMPublicLib.EnumType;

namespace WPMPublicLib.DBManager
{
    public class DbManager : IDbManager,IDisposable
    {
        #region 变量 && 属性

        /// <summary>
        /// 数据库链接串
        /// </summary>
        private string m_connStr;

        /// <summary>
        /// 数据库链接串
        /// </summary>
        public string m_ConnStr {
            get {
                return this.m_connStr;
            }
        }

        /// <summary>
        /// 数据库链接
        /// </summary>
        private OracleConnection m_conn;

        /// <summary>
        /// 数据库链接
        /// </summary>
        public OracleConnection m_Conn {
            get {
                if (this.m_conn == null) {
                    this.m_conn = new OracleConnection(this.m_ConnStr);
                }
                if (this.m_conn.State != ConnectionState.Open) {
                    this.m_conn.Open();
                }
                return this.m_conn;
            }
        }

        /// <summary>
        /// 数据库命令执行
        /// </summary>
        private OracleCommand m_com;

        /// <summary>
        /// 数据库命令执行
        /// </summary>
        public OracleCommand m_Com {
            get {
                if (this.m_com == null) {
                    this.m_com = new OracleCommand();
                }
                return this.m_com;
            }
        }

        #endregion

        #region 构造函数
        
        /// <summary>
        /// 有参构造函数
        /// </summary>
        /// <param name="connStr"></param>
        public DbManager(string connStr)
        {
            if (string.IsNullOrEmpty(connStr))
                throw new ArgumentException("无效数据库链接串：空");
            else
            {
                this.m_connStr = connStr;
            }
        }

        #endregion

        #region 接口实现 IDbManager
        
        
        /// <summary>
        /// 查询sql
        /// 如果正常执行则返回查询结果
        /// 如果执行异常则返回null
        /// </summary>
        /// <param name="querySql"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string querySql)
        {
            DataSet dsRes = new DataSet();
            DataTable dtRes = new DataTable();
            string errMsg = string.Empty;
            if (!SqlSimpleCheck(querySql, SqlType.SELECT, ref errMsg))
            {
                //记录错误日志
                LogHelper.LogHelper.WriteErrorLog(errMsg);
                return null;
            }

            querySql = querySql.Trim(' ','"');

            using(OracleDataAdapter dataAda = new OracleDataAdapter())
            {
                try
                {
                    this.m_Com.CommandType = CommandType.Text;
                    this.m_Com.CommandText = querySql;
                    this.m_Com.Connection = this.m_Conn;
                    dataAda.SelectCommand = this.m_Com;
                    dataAda.Fill(dsRes);
                    if (dsRes != null && dsRes.Tables != null && dsRes.Tables.Count > 0)
                    {
                        dtRes = dsRes.Tables[0];
                    }
#if DEBUG
                    LogHelper.LogHelper.WriteInfoLog(string.Format("执行SQL：{0}", querySql));
#endif
                }
                catch (Exception ex)
                {
                    LogHelper.LogHelper.WriteErrorLog(string.Format("执行SQL：{0}失败{1}", querySql, Environment.NewLine), ex);
                    dtRes = null;
                }
                finally
                {
                    this.m_Conn.Close();
                }
            }

            return dtRes;
        }

        public DataTable GetDataTable(string querySql, object[] objects)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 执行删除语句
        /// 当返回值为-1时 说明执行sql发生异常
        /// </summary>
        /// <param name="deleteSql">删除sql</param>
        /// <returns></returns>
        public int DeleteData(string deleteSql)
        {
            int resRows = 0; //影响的行数

            string errMsg = string.Empty;
            if (!SqlSimpleCheck(deleteSql, SqlType.DELETE, ref errMsg))
            {
                //记录错误日志
                LogHelper.LogHelper.WriteErrorLog(errMsg);
                return -1;
            }

            deleteSql = deleteSql.Trim(' ', '"');

            //打开事务
            OracleTransaction oracleTransaction = this.m_Conn.BeginTransaction(IsolationLevel.ReadCommitted);

            try
            {
                this.m_Com.CommandType = CommandType.Text;
                this.m_Com.CommandText = deleteSql;
                this.m_Com.Connection = this.m_Conn;
                resRows = this.m_Com.ExecuteNonQuery();
                oracleTransaction.Commit();
#if DEBUG
                LogHelper.LogHelper.WriteInfoLog(string.Format("执行SQL：{0}", deleteSql));
#endif
            }
            catch (Exception ex)
            {

                LogHelper.LogHelper.WriteErrorLog(string.Format("执行SQL：{0}失败{1}", deleteSql, Environment.NewLine), ex);
                resRows = -1;
            }
            finally
            {
                this.m_Conn.Close();
            }

            return resRows;
        }

        public int DeleteData(string deleteSql, object[] objects)
        {
            throw new NotImplementedException();
        }

        public int InsertData(string insertSql)
        {
            throw new NotImplementedException();
        }

        public int InsertData(string insertSql, object[] objects)
        {
            throw new NotImplementedException();
        }

        public int InsertData(DataSet insertData)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(string updateSql)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(string updateSql, object[] objects)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region 接口实现 IDisposable

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region 方法
        /// <summary>
        /// sql的简单检查
        /// 规则一：sql非空
        /// 规则二：sql 包含必要的关键字
        /// </summary>
        /// <param name="sql">sql原文</param>
        /// <param name="sqlType">sql类型</param>
        /// <param name="errMsg">错误信息</param>
        /// <returns></returns>
        private bool SqlSimpleCheck(string sql, SqlType sqlType,ref string errMsg)
        {
            bool resCheck = true;
            StringBuilder sbErrMsg = new StringBuilder();

            if (string.IsNullOrEmpty(sql))
            {
                sbErrMsg.AppendLine("无效SQL:空");
                resCheck &= false;
            }

            sql = sql.ToUpper();

            switch (sqlType)
            {
                case SqlType.SELECT:
                    if (sql.IndexOf("SELECT") < 0)
                    { 
                        sbErrMsg.AppendLine("无效SQL：不包含“SELECT”关键字");
                        resCheck &= false;
                    }
                    if (sql.IndexOf("FROM") < 0)
                    {
                        sbErrMsg.AppendLine("无需SQL：不包含“FROM”关键字");
                        resCheck &= false;
                    }
                        break;
                case SqlType.INSERT:
                    if (sql.IndexOf("INSERT") < 0)
                    {
                        sbErrMsg.AppendLine("无效SQL：不包含“INSERT”关键字");
                        resCheck &= false;
                    }
                    break;
                case SqlType.UPDATE:
                    if (sql.IndexOf("UPDATE") < 0)
                    {
                        sbErrMsg.AppendLine("无效SQL：不包含“UPDATE”关键字");
                        resCheck &= false;
                    }
                    break;
                case SqlType.DELETE:
                    if (sql.IndexOf("DELETE") < 0)
                    {
                        sbErrMsg.AppendLine("无效SQL：不包含“DELETE”关键字");
                        resCheck &= false;
                    }
                    break;
                default:
                    break;
            }

            return resCheck;
        }
        #endregion
    }
}
