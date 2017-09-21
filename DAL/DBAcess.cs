using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBAcess
    {
        private static string ConStr = System.Configuration.ConfigurationSettings.AppSettings["ConStr"];
        private static SqlConnection conn = new SqlConnection(ConStr);
        private static void ConOpen()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        private static void ConClose()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 执行SQL语句，返回bool
        /// </summary>
        /// <param name="sql">insert、update、delete</param>
        /// <returns></returns>
        public static bool ExecSqlCommand(string sql)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            try
            {
                ConOpen();
                int i = cmd.ExecuteNonQuery();
                return i > 0 ? true : false;
            }
            catch
            {
                return false;
            }
            finally
            {
                ConClose();
            }


        }

        public static DataRow GetDataRow(string sql)
        {
            DataSet ds = new DataSet();
            try
            {
                ConOpen();
                SqlDataAdapter dpt = new SqlDataAdapter(sql, conn);
                dpt.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                return i > 0 ? ds.Tables[0].Rows[0] : null;
            }
            catch
            {
                return null;
            }
            finally
            {
                ConClose();
            }
        }

        public static DataSet GetDataSet(string sql)
        {
            DataSet ds = new DataSet();
            try
            {
                ConOpen();
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter dpt = new SqlDataAdapter(sql, conn);
                dpt.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                return i > 0 ? ds : null;
            }
            catch
            {
                return null;
            }
            finally
            {
                ConClose();
            }
        }
    }
}
