using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.ManagedDataAccess.Client;

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
        /// </summary>
        /// <param name="querySql"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string querySql)
        {
            DataSet dsRes = new DataSet();
            DataTable dtRes = new DataTable();
            if (string.IsNullOrEmpty(querySql))
                throw new ArgumentException("无效SQL:空");
            else if (querySql.ToUpper().IndexOf("SELECT") < 0)
                throw new ArgumentException("无效SQL：不包含“SELECT”关键字");
            else
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
                }
                catch (Exception)
                {
                    throw;
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

        public int DeleteData(string deleteSql)
        {
            throw new NotImplementedException();
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
    }
}
