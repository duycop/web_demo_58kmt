using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_demo_2025
{
    public partial class noidung : System.Web.UI.Page
    {

        public string user_id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int ok = int.Parse(Session["ok"].ToString());
                if (ok == 1)
                {
                    user_id = Session["uid"].ToString();
                }
                else
                {
                    Response.Redirect("/login.aspx");
                }
            }
            catch//(Exception ex)
            {
                Response.Redirect("/login.aspx");
            }
        }
    }
}