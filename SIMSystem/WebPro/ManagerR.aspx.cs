using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace SIMSystem
{
    public partial class SIMSystem : System.Web.UI.Page
    {
        Student x = new Student();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                x = StudentBLL.FindAboutId(getId());
                setStudent(x);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
        private void setStudent(Student a)
        {

            Xuehao.Text = a.Id.ToString();
            Xingming.Text = a.Name;
            //Xingbie.Text = a.Sex;
            Shenfenzhenghao.Text = a.Pincodes;
            //Shengri.Text = a.DayChusheng;
            Zhengzhi.Text = a.Political;
            //Dizhi.Text = a.Address;
            //Youbian.Text = a.Postcodes;
            Ruxueriqi.Text = a.DayRuxue;
            Xueyuan.Text = a.College;
            Zhuanye.Text = a.Major;
            //Fangxiang.Text = a.Direction;
            GradeNew.Text = a.Grade.ToString();
            Banji.Text = a.Classes;
            //毕业情况.Text = a.Biye;
            //IDbiyezhengshu.Text = a.IDbiye;
            //Daybiye.Text = a.DayBiye;
        }
        private object getId()
        {
            try
            {
                int id = int.Parse(Request.QueryString["id"].ToString());
                return id;
            }
            catch { return 10001; }

        }

        protected void Zhuce_Click(object sender, EventArgs e)
        {
            x.Id = getId();
            x.Name = Xingming.Text;
            x.Grade = GradeNew.Text;
            x.Major = Zhuanye.Text;
            x.Classes = Banji.Text;
            x.College = Xueyuan.Text;
            x.Political = Zhengzhi.Text;
            x.DayRuxue = Ruxueriqi.Text;
            x.Text = Beizhu.Text;
            if (Picture.HasFile)
            {
                Picture.SaveAs(Server.MapPath("~/images/") + Picture.FileName);
                x.Imgurl = Picture.FileName;
            }
            bool a = StudentBLL.Revise(x);
            SystemLog sl = new SystemLog(System.Environment.UserName, "UpdateStudent", "successed", Page.Request.UserHostAddress);
            BLLSaveLog.AddSL(sl);
            Yichang.Text = x.Id.ToString();
        }



        protected void GradeNew_TextChanged(object sender, EventArgs e)
        {

        }
    }
}