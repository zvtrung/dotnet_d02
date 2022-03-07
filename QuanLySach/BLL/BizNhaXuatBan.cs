using QuanLySach.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.BLL
{
    class BizNhaXuatBan
    {
        public void Insert(NhaXuatBan x)
        {

        }

        /// <summary>
        /// Lấy danh sách các NXB.
        /// </summary>
        /// <returns></returns>
        public List<NhaXuatBan> GetAll()
        {
            List<NhaXuatBan> lst = new List<NhaXuatBan>();
            lst.Add(new NhaXuatBan() { MaNhaXuatBan = 1, TenNhaXuatBan = "Nhà xuất bản Trẻ" });
            lst.Add(new NhaXuatBan() { MaNhaXuatBan = 2, TenNhaXuatBan = "Nhà xuất bản Lao động" });
            lst.Add(new NhaXuatBan() { MaNhaXuatBan = 3, TenNhaXuatBan = "Nhà xuất bản Giáo dục" });
            lst.Add(new NhaXuatBan() { MaNhaXuatBan = 4, TenNhaXuatBan = "Nhà xuất bản Thuận Hoá" });

            return lst;
        }
    }
}
