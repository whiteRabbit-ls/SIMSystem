using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Model;
using System.Data;
using System.Data.SqlClient;


namespace BLL
{
    public class BLLSaveLog
    {

        public static bool AddSL(SystemLog sl)
        {
            return DALLoginsertion.AddSL(sl);
        }

        public static IList<SystemLog> getList()
        {
            return DALLogshow.Show();
        }
    }

}
