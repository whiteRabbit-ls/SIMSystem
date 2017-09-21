using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class AdminDAL
    {
	static string sql;
        static Admin sc;
        static DataSet ds;
        static DataRow dr;
	
 	public static bool Add(Admin a)
        {
            sql = string.Format("insert into T_Admin (ID,Password,Privilege) values ('{0}','{1}','{2}')", a.Id, a.Password, a.Privilege);
            return DBAcess.ExecSqlCommand(sql);
        }

        public static bool Update(Admin a)
        {
            sql = string.Format("update T_Admin set Password='{0}',Privilege='{1}' where ID='{2}' ", a.Password, a.Privilege ,a.Id);
            return DBAcess.ExecSqlCommand(sql);

        }

        public static bool Delete(String id)
        {
            sql = string.Format("delete T_Admin where id='{0}'", id);
            return DBAcess.ExecSqlCommand(sql);
        }
	public static IList<Admin> adminList()
        {
            List<Admin> list = new List<Admin>();
            sql = "select * from T_Admin";
            ds = DBAcess.GetDataSet(sql);
            if (ds == null)
            {
                return null;
            }
            else
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    sc = new Admin();
                    sc.Id = dr["Id"].ToString();
                    sc.Password = dr["Password"].ToString();
                    sc.Privilege = int.Parse(dr["Privilege"].ToString());
                    list.Add(sc);
                }
                return list;
            }
        }
	public static bool checkAdmin(Admin a)
	{
            sql = string.Format("select * from T_Admin where ID='{0}' and Password='{1}' and Privilege='{2}'", a.Id,a.Password,a.Privilege);
	    ds = DBAcess.GetDataSet(sql);
	    if (ds != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    public static Admin getRow(string id)
    {
        sc = new Admin();
        string sql = string.Format("select * from T_Admin where id='{0}'", id);
        dr = DBAcess.GetDataRow(sql);
        try
        {
            sc.Id = dr["id"].ToString();
            sc.Password = dr["password"].ToString();
            sc.Privilege = int.Parse(dr["privilege"].ToString());
            return sc;
        }
        catch
        {
            return null;
        }
    }
    }
}
