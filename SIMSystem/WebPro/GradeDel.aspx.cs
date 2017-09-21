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
    public partial class GradeDel : System.Web.UI.Page
    {
        int sid;
        protected void Page_Load(object sender, EventArgs e)
        {
            sid = int.Parse(Request.QueryString["sid"].Trim());
            Score s = ScoreBLL.getRow(sid);
            if (s != null)
            {
                Label3.Text = s.Cid.ToString();
                Label4.Text = s.Cname;
                Label5.Text = s.Scores.ToString();
            }
            else
            {
                Response.Write("<script>alert('信息加载失败');history.back();</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ScoreBLL.Delete(sid))
            {
                SystemLog sl = new SystemLog(System.Environment.UserName, "DelScore", "success", Page.Request.UserHostAddress);
                BLLSaveLog.AddSL(sl);
                Response.Redirect("GradeList.aspx");
            }
            else
            {
                SystemLog sl = new SystemLog(System.Environment.UserName, "DelScore", "failed", Page.Request.UserHostAddress);
                BLLSaveLog.AddSL(sl);
                Response.Write("<script>alert('删除失败');history.back();</script>");
            }
        }
    }
}