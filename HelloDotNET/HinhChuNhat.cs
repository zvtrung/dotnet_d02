using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNET
{
    /// <summary>
    /// Cách thứ hai để định nghĩa thuộc tính trong C#
    /// </summary>
    class HinhChuNhat
    {
        // Khai báo biến thành phần (field)
        private float chieuDai;

        // Định nghĩa thuộc tính (property) dựa vào biến thành phần (back-field)
        public float ChieuDai
        {
            get
            {
                return this.chieuDai;
            }

            set
            {
                if (value < 0)
                    value = 0;

                this.chieuDai = value;
            }
        }

        //private float chieuRong;
        //public float ChieuRong
        //{
        //    get
        //    {
        //      return chieuRong;
        //    }

        //    set
        //    {
        //        chieuRong = value;
        //    }
        //}

        public float ChieuRong { get; set; }

        public HinhChuNhat(float chieuDai, float chieuRong)
        {
            this.ChieuDai = chieuDai;
            this.ChieuRong = chieuRong;
        }

        public HinhChuNhat()
        {

        }

        public HinhChuNhat(string stChieuDai, string stChieuRong)
        {
            // đổi stChieuDai từ string thành float
            try
            {
                float value = float.Parse(stChieuDai);
                this.ChieuDai = value;
            }
            catch (Exception exc)
            {
                this.ChieuDai = 0;
            }


            try
            {
                float value = float.Parse(stChieuRong);
                this.ChieuRong = value;
            }
            catch (Exception exc)
            {
                this.ChieuRong = 0;
            }
        }

        //public float DienTich
        //{
        //    get
        //    {
        //        return this.chieuDai * this.ChieuRong;
        //    }
        //}

        // LAZY LOADING
        private float dt = -1;

        public float DienTich
        {
            get
            {
                if (dt == -1)
                    dt = this.chieuDai * this.ChieuRong;

                return dt;
            }
        }
    }
}
