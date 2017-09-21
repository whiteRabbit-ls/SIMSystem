using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using BLL;
using Model;

namespace SIMSystem
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string content = Type.SelectedItem.ToString();
            string uid = TID.Text;
            string pwd = TPwd.Text;
            Admin a = new Admin();
            if (content == "管理员")
            {
                a.Id = uid;
                a.Password = pwd;
                a.Privilege = 1;
            }
            else if (content == "学生")
            {
                a.Id = uid;
                a.Password = pwd;
                a.Privilege = 0;
            }
            if (AdminBLL.checkAdmin(a))
            {
                Session["stuid"] = uid;
                if (a.Privilege == 0)
                {
                    Response.Redirect("Index.aspx");
                }
                else
                {
                    Response.Redirect("Index.aspx");
                }
            }
            else
            {
                Response.Write("<script>alert('用户名或密码或权限选择错误');history.back();</script>");
            }
        }
    }
}