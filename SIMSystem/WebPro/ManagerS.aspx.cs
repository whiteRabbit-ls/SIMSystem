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
    public partial class ManagerS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Queren_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(GetXuehaoS.Text);
                Response.Redirect("StuInforShow.aspx?id=" + x);
            }
            catch
            {
                //Yichang.Text = ei.ToString();
                return;
            }
        }

        protected void Xiugai_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(GetXuehaoS.Text);
                Response.Redirect("ManagerR.aspx?id=" + x);
            }
            catch
            {

                return;
            }
        }

        protected void Shanchu_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(GetXuehaoS.Text);
                StudentBLL.Delete(x);
                AdminBLL.Delete(x.ToString());
                Shanchujieguo.Text = "删除成功";
                SystemLog sl = new SystemLog(System.Environment.UserName, "DelStudent", "successed", Page.Request.UserHostAddress);
                BLLSaveLog.AddSL(sl);
            }
            catch
            {
                Shanchujieguo.Text = "删除失败";
                SystemLog sl = new SystemLog(System.Environment.UserName, "DelStudent", "failed", Page.Request.UserHostAddress);
                BLLSaveLog.AddSL(sl);
                return;
            }
        }
    }
}