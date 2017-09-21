using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using BLL;
using Model;

namespace SIMSystem.WebPro
{
    public partial class AdminAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string uid = TextBox1.Text;
            string pwd = TextBox2.Text;
            int pri = 0;
            Admin a = new Admin();
            a.Id = uid;
            a.Password = pwd;
            a.Privilege = pri;
            if (AdminBLL.Add(a))
            {
                SystemLog sl = new SystemLog(System.Environment.UserName, "AddAdmin", "successed", Page.Request.UserHostAddress);
                BLLSaveLog.AddSL(sl);
                Response.Redirect("AdminList.aspx");
            }
            else
            {
                SystemLog sl = new SystemLog(System.Environment.UserName, "AddAdmin", "failed", Page.Request.UserHostAddress);
                BLLSaveLog.AddSL(sl);
                Response.Write("<script>alert('添加错误');history.back();</script>");
            }

        }
    }
}