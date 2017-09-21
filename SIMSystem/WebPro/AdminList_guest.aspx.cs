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
    public partial class AdminList_guest : System.Web.UI.Page
    {
        string name = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                name = Request.QueryString["id"].ToString();
                Label1.Text = name;
            }
            catch
            {
            }

            if (!IsPostBack)
            {
                if (name == null)
                {
                    Response.Redirect("AdminList_guest.aspx");
                }
                Admin a = AdminBLL.getRow(name);
                try
                {
                    TextBox2.Text = a.Password;
                    TextBox3.Text = a.Password;
                   
                }
                catch
                {
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string uid = name;
            string pwd = TextBox2.Text;
            int pri = 0;
            Admin a = new Admin();
            a.Id = uid;
            a.Password = pwd;
            a.Privilege = pri;
            if (AdminBLL.Update(a))
            {
                Response.Redirect("AdminList.aspx");
            }
            else
            {
                Response.Write("<script>alert('修改错误');history.back();</script>");
            }
        }
    }
}