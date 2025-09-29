using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace app_win_form_test_DLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = (double)(numericUpDown1.Value);
            b = (double)(numericUpDown2.Value);
            c = (double)(numericUpDown3.Value);
            //gọi DLL để giải quyết
            toan_lop_1.dien_tich_tam_giac bt = new toan_lop_1.dien_tich_tam_giac();
            bt.a = a;
            bt.b = b;
            bt.c = c;
            if (bt.isTamGiac())
            {
                bt.tinh_dien_tich();
                labelKQ.Text = $"3 số tạo thành tam giác với diện tích là {bt.dientich}";
            }
            else
            {
                labelKQ.Text = "3 số ko tạo thành tam giác";
            }
        }
    }
}
