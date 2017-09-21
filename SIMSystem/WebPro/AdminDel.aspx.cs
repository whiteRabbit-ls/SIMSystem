using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
using DAL;

namespace SIMSystem.WebPro
{
    public partial class AdminDel : System.Web.UI.Page
    {
        string name = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            name = Request.QueryString["id"].ToString().Trim();
            Label1.Text = name;
            if (!IsPostBack)
            {
                if (name == null)
                {
                    Response.Redirect("AdminList.aspx");
                }
                Admin a = AdminBLL.getRow(name);
                if (a != null)
                {
                    if (a.Privilege == 0)
                    {
                        Label2.Text = "普通管理员";
                    }
                    else
                    {
                        Label2.Text = "超级管理员";
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (AdminBLL.Delete(name)&&StudentBLL.Delete(name))
            {
                SystemLog sl = new SystemLog(System.Environment.UserName, "DelAdmin", "successed", Page.Request.UserHostAddress);
                BLLSaveLog.AddSL(sl);
                Response.Redirect("AdminList.aspx");
            }
            else
            {
                SystemLog sl = new SystemLog(System.Environment.UserName, "DelAdmin", "failed", Page.Request.UserHostAddress);
                BLLSaveLog.AddSL(sl);
                Response.Write("<script>alert('删除失败');history.back();</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminList.aspx");
        }
    }
}