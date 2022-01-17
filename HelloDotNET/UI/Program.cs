using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelloDotNET.Model;
using HelloDotNET.BLL;

namespace HelloDotNET.UI
{
    class Program
    {
        static void test()
        {
            // Ví dụ getter/setter cổ điển
            HinhTron x;
            x = new HinhTron();
            x.setBanKinh(15.2f);

            // In thông tin của hình tròn ra màn hình
            System.Console.WriteLine("Bán kính hình tròn là " + x.getBanKinh());


            // Ví dụ getter/setter kiểu mới của C#
            // Định nghĩa dài dòng, nhưng khi sử dụng thì tự nhiên
            HinhChuNhat hcn = new HinhChuNhat();
            hcn.ChieuDai = 10.4f;
            hcn.ChieuRong = 2.0f;

            hcn = new HinhChuNhat(10.4f, 2.0f);
            hcn = new HinhChuNhat() { ChieuRong = 2.0f, ChieuDai = 10.4f };

            Console.WriteLine("Chiều dài = " + hcn.ChieuDai + " Chiều rộng = " + hcn.ChieuRong);
            Console.WriteLine($"Chiều dài = {hcn.ChieuDai}, Chiều rộng = {hcn.ChieuRong}. Chu vi = {2 * (hcn.ChieuRong + hcn.ChieuRong)}");

            string st = $"Chiều dài = {hcn.ChieuDai}, Chiều rộng = {hcn.ChieuRong}. Chu vi = {2 * (hcn.ChieuRong + hcn.ChieuRong)}";
            Console.WriteLine(st);


            Console.WriteLine("Diện tích = " + hcn.DienTich);
            //hcn.DienTich = 1000;
        }

        static void testBizHinhTron()
        {
            //BizHinhTron bizHinhTron = new BizHinhTron("D:\\T2MProjects\\dnet-workspace\\Day02\\HelloDotNET\\bin\\Debug\\hinhtron.txt");
            BizHinhTron bizHinhTron = new BizHinhTron("D:/T2MProjects/dnet-workspace/Day02/HelloDotNET/bin/Debug/hinhtron.txt");
            List<HinhTron> lst = bizHinhTron.ReadAll();
            //foreach(HinhTron x in lst)
            //{

            //}

            Console.WriteLine("Danh sách toàn bộ hình tròn");
            for (int i = 0; i < lst.Count; i++)
            {
                HinhTron x = lst[i];
                Console.WriteLine($"Hinh tron thu {i} -- Ban kinh = {x.getBanKinh()}");
            }

            float bkMin = 2.0f;
            float bkMax = 60.0f;
            lst = bizHinhTron.ReadWithCondition(bkMin, bkMax);
            Console.WriteLine($"Danh sách các hình tròn có bk nằm trong [{bkMin}, {bkMax}]");
            for (int i = 0; i < lst.Count; i++)
            {
                HinhTron x = lst[i];
                Console.WriteLine($"Hinh tron thu {i} -- Ban kinh = {x.getBanKinh()}");
            }
        }

        static void Main(string[] args)
        {
            //test();           
            testBizHinhTron();
        }
    }
}
