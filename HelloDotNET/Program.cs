using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNET
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
