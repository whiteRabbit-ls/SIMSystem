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
    public partial class ManagerNEW : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Time temp = new Time();
                Nian1.DataSource = temp.YEAR;
                Yue1.DataSource = temp.MONTH;
                Nian1.DataBind();
                Yue1.DataBind();
                //setStudent();
            }
        }
        protected void Ruxueriqi_TextChanged(object sender, EventArgs e)
        {

        }
        protected void Nian1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Time temp = new Time();
            int year = 2000;
            int month = 1;
            foreach (ListItem li in Nian1.Items)
                if (li.Selected)
                    try
                    {
                        year = int.Parse(li.Value);
                    }
                    catch { }
            foreach (ListItem li in Yue1.Items)
                if (li.Selected)
                    try
                    {
                        month = int.Parse(li.Value);
                    }
                    catch { }
            Ri1.DataSource = temp.getDay(year, month);
            Ri1.DataBind();
        }
        protected void Yue1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Time temp = new Time();
            int year = 2000;
            int month = 1;
            foreach (ListItem li in Nian1.Items)
                if (li.Selected)
                    try
                    {
                        year = int.Parse(li.Value);
                    }
                    catch { }
            foreach (ListItem li in Yue1.Items)
                if (li.Selected)
                    try
                    {
                        month = int.Parse(li.Value);
                    }
                    catch { }
            Ri1.DataSource = temp.getDay(year, month);
            Ri1.DataBind();
        }

        protected void Zhuce_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            if (!HeFaXingJianCe())
            {
                HeFa.Text = "该ID非法";
                return;
            }

            setInFor(stu);
            Admin a = new Admin();
            a.Id = Xuehao.Text;
            a.Password = "000000";
            a.Privilege = 0;
            AdminBLL.Add(a);
            bool bo = StudentBLL.Add(stu);
            SystemLog sl = new SystemLog(System.Environment.UserName, "AddStudent", "successed", Page.Request.UserHostAddress);
            BLLSaveLog.AddSL(sl);
            if (stu.Main)
            {
                YiChang.Text = "赋值成功";
            }
            else
                YiChang.Text = bo.ToString();
            //YiChang.Text = bo.ToString();
            Response.Redirect("StuInforShow.aspx?id=" + stu.Id);
        }
        private void setInFor(Student a)
        {
            a.Id = int.Parse(Xuehao.Text);
            a.Grade = grade.Text;
            if (Picture.HasFile)
            {
                a.Imgurl = Picture.FileName;
                Picture.SaveAs(Server.MapPath("~/images/") + Picture.FileName);
            }
            a.Name = Xingming.Text;
            a.Pincodes = Shenfenzhenghao.Text;
            a.College = Xueyuan.Text;
            a.Classes = Banji.Text;
            a.Major = Zhuanye.Text;
            a.Political = Zhengzhi.Text;
            a.Sex = Xingbie.Text;
            a.Text = Beizhu.Text;
            a.Address = Dizhi.Text;
            a.Postcodes = YouBian.Text;
            a.DayRuxue = Nian1.Text + Yue1.Text + Ri1.Text;
            a.Main = true;
        }

        protected void NewXuehao_Click(object sender, EventArgs e)
        {
            if (HeFaXingJianCe())
            {
                HeFa.Text = "该ID合法";
            }
            else
            {
                HeFa.Text = "该ID非法";
            }
        }
        private bool TuPianJianCe()
        {
            if (!Picture.HasFile)
                return true;
            bool fileIsValid = false;
            string fileExtension =
            System.IO.Path.GetExtension(this.Picture.FileName).ToLower();
            string[] restrictExtension = { ".gif", ".jpg", ".bmp", ".png" };
            for (int i = 0; i < restrictExtension.Length; i++)
            {
                if (fileExtension == restrictExtension[i])
                { fileIsValid = true; }
            }
            return fileIsValid;
        }
        private bool HeFaXingJianCe()
        {

            try
            {
                object x = int.Parse(Xuehao.Text);
                if (StudentBLL.FindAboutId(x).Main) { return false; }
                else if (!StudentBLL.FindAboutId(x).Main) { return true; }
                else { return false; }
            }
            catch { return false; }
        }

    }
}