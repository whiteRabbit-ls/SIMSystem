using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using Model;

namespace SIMSystem
{
    public partial class Update_Grade : System.Web.UI.Page
    {
        int sid;
        protected void Page_Load(object sender, EventArgs e)
        {
            sid = int.Parse(Request.QueryString["sid"].Trim());
            Score s = ScoreBLL.getRow(sid);
            if (s != null)
            {
                Label5.Text = s.Cid.ToString();
                Label6.Text = s.Cname;
            }
            else {
                Response.Write("<script>alert('信息加载失败');history.back();</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Score s = new Score();
            s.Sid = sid;
            s.Scores = int.Parse(TextBox1.Text);
            if (ScoreBLL.Update(s))
            {
                SystemLog sl = new SystemLog(System.Environment.UserName, "UpdateScore", "successed", Page.Request.UserHostAddress);
                BLLSaveLog.AddSL(sl);
                Response.Redirect("GradeList.aspx");
            }
            else
            {
                SystemLog sl = new SystemLog(System.Environment.UserName, "UpdateScore", "failed", Page.Request.UserHostAddress);
                BLLSaveLog.AddSL(sl);
                Response.Write("<script>alert('修改失败');history.back();</script>");
            }
        }
    }
}