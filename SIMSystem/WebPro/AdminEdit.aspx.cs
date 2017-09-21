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
    public partial class AdminEdit : System.Web.UI.Page
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
                    Response.Redirect("AdminList.aspx");
                }
                Admin a = AdminBLL.getRow(name);
                try
                {
                    TextBox2.Text = a.Password;
                    TextBox3.Text = a.Password;
                    for (int i = 0; i < DropDownList1.Items.Count; i++)
                    {
                        if (DropDownList1.Items[i].Value.ToString() == a.Privilege.ToString())
                        {
                            DropDownList1.Items[i].Selected = true;
                        }
                    }
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
            int pri = int.Parse(DropDownList1.SelectedValue);
            Admin a = new Admin();
            a.Id = uid;
            a.Password = pwd;
            a.Privilege = pri;
            if (AdminBLL.Update(a))
            {
                SystemLog sl = new SystemLog(System.Environment.UserName, "EditAdmin", "successed", Page.Request.UserHostAddress);
                BLLSaveLog.AddSL(sl);
                Response.Redirect("AdminList.aspx");
            }
            else
            {
                SystemLog sl = new SystemLog(System.Environment.UserName, "EditAdmin", "failed", Page.Request.UserHostAddress);
                BLLSaveLog.AddSL(sl);
                Response.Write("<script>alert('添加错误');history.back();</script>");
            }
        }
    }
}