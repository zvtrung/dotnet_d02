using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.Model
{
    public class NhaXuatBan
    {
        public int MaNhaXuatBan { get; set; }

        //private int _MaNhaXuatBan; // back-field

        //public int MaNhaXuatBan  // Khai báo property
        //{
        //    get
        //    {
        //        return this._MaNhaXuatBan;
        //    }

        //    set
        //    {
        //        this._MaNhaXuatBan = value;
        //    }
        //}

        //// getter
        //public int GetMaNhaXuatBan()
        //{
        //    return this._MaNhaXuatBan;
        //}

        //// setter
        //public void SetMaNhaXuatBan(int value)
        //{
        //    // validate dữ liệu (value)..


        //    // .. thực hiện gán
        //    this._MaNhaXuatBan = value;
        //}

        public string TenNhaXuatBan { get; set; }
    }
}
