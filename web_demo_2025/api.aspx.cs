using Newtonsoft.Json;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_demo_2025
{
    public partial class api : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //nhận dữ liệu gửi lên từ client
            //GỬI LÊN POST
            TraVe kq = new TraVe();
            double a = 0, b = 0, c = 0;
            try
            {
                if (!IsPostBack)
                {
                    a = double.Parse(this.Request.Form["a"]);
                    b = double.Parse(this.Request.Form["b"]);
                    c = double.Parse(this.Request.Form["c"]);
                    //sử dụng 1 DLL giải quyết đc bài toán (demo: chọn bài toán đơn giản)
                    toan_lop_1.dien_tich_tam_giac bt = new toan_lop_1.dien_tich_tam_giac();
                    bt.a = a;
                    bt.b = b;
                    bt.c = c;
                    //thu đc kết quả (số)

                    if (bt.isTamGiac())
                    {
                        bt.tinh_dien_tich(); //tính đt
                        kq.oktg = true;
                        kq.dt = bt.dientich; //lấy output của class 
                    }
                    else
                    {
                        kq.oktg = false;
                        kq.dt = 0;
                    }
                }
            }catch(Exception ex)
            {
                kq.oktg = false;
                kq.dt = 0;
                kq.msg= ex.Message;
            }

            //chuyển kq thành json -> gửi về client
            string json = JsonConvert.SerializeObject(kq);
            this.Response.Cookies["input"].Value = $"{a},{b},{c}";
            this.Response.Cookies["input"].Expires = DateTime.Now.AddMinutes(1);
            this.Response.Write(json);
        }

        class TraVe
        {
            public bool oktg;
            public double dt;
            public string msg;
        }
    }
}