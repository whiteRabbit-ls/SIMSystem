using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
using Model;

namespace BLL
{
    public class ScoreBLL
    {
        public static bool Add(Score s)
        {
            return ScoreDAL.Add(s);
        }

        public static bool Update(Score s)
        {
            return ScoreDAL.Update(s);
        }

        public static bool Delete(int sid)
        {
            return ScoreDAL.Delete(sid);
        }

        public static IList<Score> getList(String stuid)
        {
            return ScoreDAL.Find(stuid);
        }
        public static IList<Score> getAll()
        {
            return ScoreDAL.getAll();
        }

        public static Dictionary<int, String> getCourse()
        {
            return ScoreDAL.getCourse();
        }
        public static Score getRow(int sid)
        {
            return ScoreDAL.getRow(sid);
        }
    }
}
