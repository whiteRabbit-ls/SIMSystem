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
    public partial class AdminList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    Repeater_AdmInfo.DataSource = AdminBLL.adminList();
                    Repeater_AdmInfo.DataBind();
                }
                catch
                {
                    Response.Write("<script>alert('参数错误');history.back();</script>");
                }
            }
        }



        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdmAdd.aspx");
        }
    }
}