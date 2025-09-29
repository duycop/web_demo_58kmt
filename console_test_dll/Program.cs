using System;
using System.Collections.Generic;
using System.Text;

namespace console_test_dll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                System.Console.WriteLine("TÍNH Dien tich tam giac");
                System.Console.Write("NHập độ dài 3 cạnh: ");
                string s = System.Console.ReadLine();
                char[] arr = { ' ', ',', '\t' };
                string[] items = s.Split(arr);
                if (items.Length == 3)
                {
                    double a, b, c;
                    a = double.Parse(items[0]);
                    b = double.Parse(items[1]);
                    c = double.Parse(items[2]);
                    //gọi DLL để giải quyết
                    toan_lop_1.dien_tich_tam_giac bt = new toan_lop_1.dien_tich_tam_giac();
                    bt.a = a;
                    bt.b = b;
                    bt.c = c;
                    if (bt.isTamGiac())
                    {
                        bt.tinh_dien_tich();
                        System.Console.Write($"3 số tạo thành tam giác với diện tích là {bt.dientich}");
                    }
                    else
                    {
                        System.Console.Write("3 số ko tạo thành tam giác");
                    }

                }
                else
                {
                    System.Console.Write("Hãy nập đủ 3 số");
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }
    }
}
