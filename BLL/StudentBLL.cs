using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Model;
using System.Collections;

namespace BLL
{
    public class StudentBLL
    {
        public static bool Add(Student a)
        {
            //StudentDal.AddToAdmin(a);
            return StudentDAL.Add(a);

        }
        public static bool Revise(Student a)
        {
            return StudentDAL.Update(a);
        }
        public static bool Delete(object a)
        {
            return StudentDAL.Delete(a);
        }
        public static Student FindAboutId(object id)
        {
            return StudentDAL.GetbyId(id);
        }
        public static List<Student> GetALL()
        {
            return StudentDAL.GetALL();
        }
    }
}
