using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_demo_2025
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //lấy dữ liệu từ form
            string uid= txt_uid.Text;
            string pwd= txt_pwd.Text;
            //so sánh (NHANH) với dữ liệu chuẩn
            //thực tế cần csdl, dùng sql để truy vấn xem uid+pwd có đúng ko
            if (uid=="admin" && pwd=="123456")
            {
                //đăng nhập thành công
                Session["uid"] = uid;
                Session["ok"] = 1;
                Response.Redirect("/noidung.aspx"); //trang home: index.html
            }
            else
            {
                //đăng nhập thất bại
                lblMsg.Text = "Sai thông tin đăng nhập";
            }
        }
    }
}