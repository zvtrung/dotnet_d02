using QuanLySach.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.BLL
{
    /// <summary>
    /// Lớp xử lý nghiệp vụ liên quan đến Sach
    /// </summary>
    public class BizSach
    {
        /// <summary>
        /// Lấy danh sách các quyển sách
        /// </summary>
        /// <returns></returns>
        internal List<Sach> ReadAll()
        {
            List<Sach> lst = new List<Sach>();

            Sach x = new Sach();
            x.MaSach = 1;
            x.TieuDe = "Lập trình C cơ bản";
            x.DanhSachTacGia = "Trương Công Tuấn, Đoàn Thị Hồng Phước";
            x.MaNhaXuatBan = 1;
            x.NamXuatBan = 2000;

            lst.Add(x);

            x = new Sach()
            {
                MaSach = 2,
                TieuDe = "Lập trình Java nâng cao",
                DanhSachTacGia = "Nguyễn Hoàng Hà, Nguyễn Văn Trung",
                MaNhaXuatBan = 3,
                NamXuatBan = 2002
            };
            lst.Add(x);

            lst.Add(new Sach()
            {
                MaSach = 3,
                TieuDe = "How to programming XYZ",
                DanhSachTacGia = "Trần Nguyên Phong",
                MaNhaXuatBan = 2,
                NamXuatBan = 2022
            });

            lst.Add(new Sach()
            {
                MaSach = 4,
                TieuDe = "Sách 4",
                DanhSachTacGia = "Tác giả 1, Tác giả 2",
                MaNhaXuatBan = 2,
                NamXuatBan = 2022
            });

            lst.Add(new Sach()
            {
                MaSach = 5,
                TieuDe = "Sách 5",
                DanhSachTacGia = "Tác giả 1",
                MaNhaXuatBan = 1,
                NamXuatBan = 2022
            });

            return lst;
        }

        internal List<Sach> GetSachOfNhaXuatBan(int maNhaXuatBan)
        {
            List<Sach> lstAll = this.ReadAll();
            List<Sach> lstResult = new List<Sach>();
            for (int i = 0; i < lstAll.Count; i++)
                if (lstAll[i].MaNhaXuatBan == maNhaXuatBan)
                    lstResult.Add(lstAll[i]);

            return lstResult;
        }

        /// <summary>
        /// Xoá đối tượng sach cụ thể
        /// </summary>
        /// <param name="sach">The sach.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        internal bool Xoa(Sach sach)
        {
            //throw new NotImplementedException();
            return true;
        }

        /// <summary>
        /// Thêm mới quyển sách vào CSDL
        /// </summary>
        /// <param name="x">The x.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        internal void Insert(Sach x)
        {
            // throw new NotImplementedException();
        }

        internal void Update(Sach x)
        {
            //throw new NotImplementedException();
        }
    }
}
