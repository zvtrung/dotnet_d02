using HelloDotNET.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNET.BLL
{
    class BizHinhTron
    {
        private string tenFile;

        public BizHinhTron(string tenFile)
        {
            this.tenFile = tenFile;
        }

        /// <summary>
        /// Lấy tất cả hình tròn từ nguồn dữ liệu
        /// </summary>
        /// <returns></returns>
        public List<HinhTron> ReadAll()
        {
            List<HinhTron> lst = new List<HinhTron>();

            //lst.Add(new HinhTron(1.0f));
            //lst.Add(new HinhTron("4.5"));
            //lst.Add(new HinhTron(15.2f));
            // Đọc file văn bản tenFile
            // Tạo list gồm các hình tròn từ file này
            StreamReader sr = new StreamReader(this.tenFile);
            while (true)
            {
                String line = sr.ReadLine();
                if (line == null)
                    break;

                line = line.Trim(); // xoá các ký tự trắng thừa trong chuỗi

                // convert line --> float và tạo HinhTron
                HinhTron x = new HinhTron(line);

                // Bổ sung hình tròn x vào lst
                lst.Add(x);
            }
            sr.Close();

            return lst;
        }

        /// <summary>
        /// Lấy danh sách các hình tròn có bán kính nằm trong khoảng cho trước
        /// </summary>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        /// <returns></returns>
        public List<HinhTron> ReadWithCondition(float from, float to)
        {
            List<HinhTron> lst = new List<HinhTron>();

            //lst.Add(new HinhTron(1.0f));
            //lst.Add(new HinhTron("4.5"));
            //lst.Add(new HinhTron(15.2f));
            // Đọc file văn bản tenFile
            // Tạo list gồm các hình tròn từ file này
            StreamReader sr = new StreamReader(this.tenFile);
            while (true)
            {
                String line = sr.ReadLine();
                if (line == null)
                    break;

                line = line.Trim(); // xoá các ký tự trắng thừa trong chuỗi

                // convert line --> float và tạo HinhTron
                HinhTron x = new HinhTron(line);

                // Bổ sung hình tròn x vào lst
                if (x.getBanKinh() >= from && x.getBanKinh() <= to)
                    lst.Add(x);
            }
            sr.Close();

            return lst;
        }
    }
}
