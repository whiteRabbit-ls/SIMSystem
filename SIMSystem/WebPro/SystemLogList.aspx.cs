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
    public partial class SystemLogList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowList();
            }
        }
        void ShowList()
        {
            try
            {
                Repeater_SystemLog.DataSource = BLLSaveLog.getList();
                Repeater_SystemLog.DataBind();
            }
            catch
            {
                Response.Write("<script>alert('参数错误');history.back();</script>");
            }
        }
    }
}
