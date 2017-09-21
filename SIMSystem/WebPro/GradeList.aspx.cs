using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;
using DAL;
using Model;


namespace SIMSystem
{
    public partial class WebForm1 : System.Web.UI.Page
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
                Repeater_StuScore.DataSource = ScoreBLL.getAll();
                Repeater_StuScore.DataBind();
            }
            catch
            {
                Response.Write("<script>alert('参数错误');history.back();</script>");
            }
        }
    }
}