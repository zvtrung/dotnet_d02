using HelloDotNET.Model;
using System;
using System.Collections.Generic;
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

            lst.Add(new HinhTron(1.0f));
            lst.Add(new HinhTron("4.5"));
            lst.Add(new HinhTron(15.2f));

            return lst;
        }
    }
}
