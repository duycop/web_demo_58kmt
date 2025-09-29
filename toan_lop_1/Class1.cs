using System;
using System.Collections.Generic;
using System.Text;

namespace toan_lop_1
{
    public class dien_tich_tam_giac
    {
        /// <summary>
        /// độ dài 3 cạnh tam giác
        /// </summary>
        public double a, b, c;

        /// <summary>
        /// đầu ra diện tích tam giác
        /// </summary>
        public double dientich
        {
            get;
            private set; //trong class này mới set đc
        }

        public bool isTamGiac()
        {
            return (a > 0) && (b > 0) && (c > 0) && (a + b > c) && (b + c > a) && (c + a > b);
        }

        /// <summary>
        /// tính diện tích tam giác với độ dài 3 cạnh là a,b,c
        /// </summary>
        public void tinh_dien_tich()
        {
            if ((isTamGiac()))
            {
                //tính diện tích tam giác với độ dài 3 cạnh là a,b,c theo công thức herong
                double p = (a + b + c) / 2;
                dientich = System.Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }
    }
}
