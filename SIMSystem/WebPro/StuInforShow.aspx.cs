using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using System.Collections;
using BLL;

namespace SIMSystem
{
    public partial class StuInforShow : System.Web.UI.Page
    {

        Student x = new Student();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                x = StudentBLL.FindAboutId(getId());
                setStudent(x);
                //Idxuehao.Text = getId().ToString();
                //Yichang.Text = x.ei.ToString();
            }
        }
        private object getId()
        {
            try
            {
                int id = int.Parse(Session["stuid"].ToString().Trim());
                Yichang.Text = id.ToString();
                return id;
            }
            catch (Exception ei)
            {
                object id = 12345;
                Yichang.Text = ei.ToString();
                return id;
            }
        }
        private void setStudent(Student a)
        {
            Idxuehao.Text = getId().ToString();
            Xingming.Text = a.Name;
            Xingbie.Text = a.Sex;
            Shenfenzhenghao.Text = a.Pincodes;
            Shengri.Text = a.DayChusheng;
            Zhengzhi.Text = a.Political;
            Dizhi.Text = a.Address;
            Youbian.Text = a.Postcodes;
            Ruxue.Text = a.DayRuxue;
            Xueyuan.Text = a.College;
            Zhuanye.Text = a.Major;
            Fangxiang.Text = a.Direction;
            Nianji.Text = a.Grade.ToString();
            Banji.Text = a.Classes;
            毕业情况.Text = a.Biye;
            IDbiyezhengshu.Text = a.IDbiye;
            Daybiye.Text = a.DayBiye;
            Imagetouxiang.ImageUrl = "~/images/" + a.Imgurl;

        }
    }
}