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
    public class AdminBLL
    {
        public static bool Add(Admin a)
        {
            return AdminDAL.Add(a);
        }

        public static bool Update(Admin a)
        {
            return AdminDAL.Update(a);
        }

        public static bool Delete(String id)
        {
            return AdminDAL.Delete(id);
        }
        public static IList<Admin> adminList()
        {
            return AdminDAL.adminList();
        }
        public static bool checkAdmin(Admin a)
        {
            return AdminDAL.checkAdmin(a);
        }
        public static Admin getRow(string id)
        {
            return AdminDAL.getRow(id);
        }
    }
}
