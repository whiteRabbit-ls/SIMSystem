using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Score
    {
        private int sid;
        private int cid;
        private String stuid;
        private String cname;
        private int score;

        public int Sid
        {
            get { return sid; }
            set { sid = value; }
        }

        public int Cid
        {
            get { return cid; }
            set { cid = value; }
        }

        public String Stuid
        {
            get { return stuid; }
            set { stuid = value; }
        }

        public String Cname
        {
            get { return cname; }
            set { cname = value; }
        }

        public int Scores
        {
            get { return score; }
            set { score = value; }
        }
        
         public Score()
        {

        }
    }
}
