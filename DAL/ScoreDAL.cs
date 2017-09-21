using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class ScoreDAL
    {
        static string sql;
        static Score sc;
        static DataSet ds;
        static DataRow dr;


        public static bool Add(Score a)
        {
            sql = string.Format("insert into T_Score (cid,stuid,score) values ('{0}','{1}','{2}')", a.Cid, a.Stuid, a.Scores);
            return DBAcess.ExecSqlCommand(sql);
        }

        public static bool Update(Score a)
        {
            sql = string.Format("update T_Score set score='{0}' where sid='{1}' ", a.Scores, a.Sid);
            return DBAcess.ExecSqlCommand(sql);
        }

        public static bool Delete(int sid)
        {
            sql = string.Format("Delete T_Score where sid='{0}'", sid);
            return DBAcess.ExecSqlCommand(sql);
        }

        public static IList<Score> Find(String stuid)
        {
            List<Score> list = new List<Score>();
            string sql = string.Format("select sid,stuid,T_Score.cid,cname,score from T_Score,T_Course where stuid='{0}' and T_Score.cid=T_Course.cid", stuid);
            ds = DBAcess.GetDataSet(sql);
            if (ds == null)
            {
                return null;
            }
            else
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    sc = new Score();
                    sc.Sid = int.Parse(dr["sid"].ToString());
                    sc.Stuid = dr["stuid"].ToString();
                    sc.Cid = int.Parse(dr["cid"].ToString());
                    sc.Cname = dr["cname"].ToString();
                    sc.Scores = int.Parse(dr["score"].ToString());
                    list.Add(sc);
                }
                return list;
            }
        }
        public static IList<Score> getAll()
        {
            List<Score> list = new List<Score>();
            string sql = "select sid,stuid,T_Score.cid,cname,score from T_Score,T_Course where T_Score.cid=T_Course.cid";
            ds = DBAcess.GetDataSet(sql);
            if (ds == null)
            {
                return null;
            }
            else
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    sc = new Score();
                    sc.Sid = int.Parse(dr["sid"].ToString());
                    sc.Stuid = dr["stuid"].ToString();
                    sc.Cid = int.Parse(dr["cid"].ToString());
                    sc.Cname = dr["cname"].ToString();
                    sc.Scores = int.Parse(dr["score"].ToString());
                    list.Add(sc);
                }
                return list;
            }
        }
        public static Dictionary<int,String> getCourse()
        {
            int cid;
            String cname;
            Dictionary<int, String> dic = new Dictionary<int, String>();
            string sql = string.Format("select * from T_Course" );
            ds = DBAcess.GetDataSet(sql);
            if (ds == null)
            {
                return null;
            }
            else
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    cid = int.Parse(dr["cid"].ToString());
                    cname = dr["cname"].ToString();
                    dic.Add(cid,cname);
                }
                return dic;
            }
        }
        public static Score getRow(int sid) 
        {
            sc = new Score();
            string sql = string.Format("select T_Score.cid,cname,score from T_Score,T_Course where sid='{0}'", sid);
            dr = DBAcess.GetDataRow(sql);
            try
            {
                sc.Cid = int.Parse(dr["cid"].ToString());
                sc.Cname = dr["cname"].ToString();
                sc.Scores = int.Parse(dr["score"].ToString());
                return sc;
            }
            catch
            {
                return null;
            }
        }
    }
}
