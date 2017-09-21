using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class DALLogshow
    {
        public static IList<SystemLog> Show()
        {

            List<SystemLog> list = new List<SystemLog>();
            string sql = "select LogID,Operator.DateTime,Activity,Status,IPAdd,DetailInfo from T_SystemLog";
            DataSet ds = DBAcess.GetDataSet(sql);
            if (ds == null)
            {
                return null;
            }
            else
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    SystemLog sl = new SystemLog();
                    sl.LogID = (dr["LogID"].ToString());
                    sl.Operator = (dr["Operator"].ToString());
                    sl.DateTimes = (dr["DateTime"].ToString());
                    sl.Activity = (dr["Activity"].ToString());
                    sl.Status = (dr["Status"].ToString());
                    sl.IPAdd = (dr["IPAdd"].ToString());
                    sl.DetailInfo = (dr["DetailInfo"].ToString());
                    list.Add(sl);
                }
                return list;
            }

        }
    }
}
