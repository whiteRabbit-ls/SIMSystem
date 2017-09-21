using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using BLL;
using DAL;
using Model;

namespace SIMSystem
{
    public partial class addgrade : System.Web.UI.Page
    {
        int cid;
        int scores;
        String stuid ;
        ArrayList a = new ArrayList();
        Dictionary<int, String> dic = ScoreBLL.getCourse();
       
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                foreach(int key in dic.Keys)
                {
                    a.Add(key);
                }
                DropDownList1.DataSource = a;
                DropDownList1.DataBind();
                

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cid = int.Parse(DropDownList1.SelectedItem.Text);
            stuid = TextBox2.Text;
            scores = int.Parse(TextBox1.Text);
            Score s = new Score();
            s.Cid = cid;
            s.Stuid = stuid;
            s.Scores = scores;
            if (ScoreBLL.Add(s))
            {
                SystemLog sl = new SystemLog(System.Environment.UserName, "AddScore", "success", Page.Request.UserHostAddress);
                BLLSaveLog.AddSL(sl);
                Response.Redirect("GradeList.aspx");
            }
            else
            {
                SystemLog sl = new SystemLog(System.Environment.UserName, "AddScore", "failed", Page.Request.UserHostAddress);
                BLLSaveLog.AddSL(sl);
                Response.Write("<script>alert('添加失败');history.back();</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            cid = int.Parse(DropDownList1.SelectedItem.Text);
            Label3.Text = dic[cid];
        }
    }
}