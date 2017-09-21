using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using Model;

namespace SIMSystem.WebPro
{
    public partial class GradeList_guest : System.Web.UI.Page
    {
        String stuid = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["stuid"] == null)
            {
                Response.Write("<script>alert('参数错误');history.back();</script>");
            }
            stuid = Session["stuid"].ToString().Trim();
            if (!IsPostBack)
            {
                ShowList();
            }
        }
        void ShowList()
        {
            try
            {
                Repeater_StuScore.DataSource = ScoreBLL.getList(stuid);
                Repeater_StuScore.DataBind();
            }
            catch
            {
                Response.Write("<script>alert('参数错误');history.back();</script>");
            }
        }
    }
}