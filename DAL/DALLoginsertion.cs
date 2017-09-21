using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Model;

namespace DAL
{
    public class DALLoginsertion
    {
        public static string sql;
        public static SystemLog sl;
        public static DataSet logdataset;
        public static DataRow logdatarow;

        public static bool AddSL(SystemLog sl)
        {
            sql = string.Format("insert into T_SystemLog (Operator,Activity,Status,IPAdd,DetailInfo) values ('{0}','{1}','{2}','{3}','{4}') ", sl.Operator, sl.Activity, sl.Status, sl.IPAdd, sl.DetailInfo);
            return DBAcess.ExecSqlCommand(sql);
        }


    }
}
