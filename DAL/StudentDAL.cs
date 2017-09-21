using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;
namespace DAL
{
    public class StudentDAL
    {
        static string sql;
        static Student a;
        static DataSet ds;
        static DataRow dr;

        public static void AddToAdmin(Student a)
        {
            string x = a.Pincodes.Substring(a.Pincodes.Length - 6);
            sql = string.Format("insert into T_Admin(ID,Password,Privilege) values ('{0}','{1}','{2}')", a.Id, x, 0);
            DBAcess.ExecSqlCommand(sql);
        }
        public static bool Add(Student a)
        {
            //string x=string.Format("insert into T_Stduent(id,name,classes,major,college,grade,sex,address,pincodes,imgurl) values ("+a.Id+","+a.Name+","+a.Classes+","+a.Major+","+a.College+","+a.Grade+","+a.Sex+","+a.Address+","+a.Pincodes+","+a.Imgurl+")");
            sql = string.Format("insert into T_Student(id,name,classes,major,college,grade,sex,address,pincodes,imgurl,dayruxue) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", a.Id, a.Name, a.Classes, a.Major, a.College, a.Grade, a.Sex, a.Address, a.Pincodes, a.Imgurl, a.DayRuxue);
            //sql = x;
            return DBAcess.ExecSqlCommand(sql);
        }

        public static bool Update(Student a)
        {
            sql = string.Format("update T_Student set name='{0}',classes='{1}',major='{2}',college='{3}',grade='{4}',sex='{5}',address='{6}',pincodes='{7}',imgurl='{8}' where id='{9}'", a.Name, a.Classes, a.Major, a.College, a.Grade, a.Sex, a.Address, a.Pincodes, a.Imgurl, a.Id);
            return DBAcess.ExecSqlCommand(sql);
        }
       
        public static bool Delete(object id)
        {
            sql = string.Format("Delete T_Student where id='{0}'", id);
            return DBAcess.ExecSqlCommand(sql);
        }

        public static Student GetbyId(object id)
        {
            a = new Student();
            string sql = string.Format("select * from T_Student where id='{0}'", id);
            dr = DBAcess.GetDataRow(sql);
            try
            {
                a.Id = dr["id"];
                a.Name = dr["Name"].ToString();
                a.Classes = dr["Classes"].ToString();
                a.Major = dr["Major"].ToString();
                a.College = dr["College"].ToString();
                a.Grade = dr["grade"];
                a.Sex = dr["Sex"].ToString();
                a.Address = dr["Address"].ToString();
                a.Pincodes = dr["pincodes"].ToString();
                a.Imgurl = dr["Imgurl"].ToString();
                a.DayRuxue = dr["Dayruxue"].ToString();
                //a.Imgurl = dr["picture"].ToString();
                a.Main = true;
                return a;
            }
            catch
            {
                //throw ei;
                // return null;
                return a;
            }
        }
        public static List<Student> GetALL()
        {
            List<Student> list = new List<Student>();
            sql = "select * from T_Student";
            ds = DBAcess.GetDataSet(sql);
            if (ds == null)
            {
                return null;
            }
            else
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    a = new Student();
                    a.Id = dr["id"].ToString();
                    a.Name = dr["Name"].ToString();
                    a.Classes = dr["Classes"].ToString();
                    a.Major = dr["Major"].ToString();
                    a.College = dr["College"].ToString();
                    a.Grade = dr["grade"];
                    a.Sex = dr["Sex"].ToString();
                    a.Address = dr["Address"].ToString();
                    a.Pincodes = dr["pincodes"].ToString();
                    a.Imgurl = dr["Imgurl"].ToString();
                    a.Main = true;
                    list.Add(a);
                }
                return list;
            }
        }
        public static IList<Student> GetBy(string type, string b)
        {
            List<Student> list = new List<Student>();

            sql = "select * from T_Student where " + type + "=" + b + " order by id desc";



            ds = DBAcess.GetDataSet(sql);
            if (ds == null)
            {
                return null;
            }
            else
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    a = new Student();
                    a.Name = dr["Name"].ToString();
                    a.Classes = dr["Classes"].ToString();
                    a.Major = dr["Major"].ToString();
                    a.College = dr["College"].ToString();
                    a.Grade = dr["grade"];
                    a.Sex = dr["Sex"].ToString();
                    a.Address = dr["Address"].ToString();
                    a.Pincodes = dr["pincodes"].ToString();
                    a.Imgurl = dr["Imgurl"].ToString();
                    a.Main = true;
                    list.Add(a);
                }
                return list;
            }
        }

        public static IList<Student> Getbyname(string b)
        {
            return GetBy("name", b);
        }

        public static IList<Student> Getbyclasses(string b)
        {
            return GetBy("classes", b);
        }

        public static IList<Student> Getbymajor(string b)
        {
            return GetBy("major", b);
        }

        public static IList<Student> Getbycollege(string b)
        {
            return GetBy("colloge", b);
        }

        public static IList<Student> Getbygrade(string b)
        {
            return GetBy("grade", b);
        }


    }
}