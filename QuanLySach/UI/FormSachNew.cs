using QuanLySach.BLL;
using QuanLySach.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach.UI
{
    public partial class FormSachNew : Form
    {
        public FormSachNew()
        {
            InitializeComponent();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            // 1. Thu thập dữ liệu trên GUI
            int maSach = int.Parse(txtMaSach.Text);
            string tieuDe = txtTieuDe.Text;
            string danhSachTacGia = txtDanhSachTacGia.Text;
            int maNhaXuatBan = -1; // TODO
            int namXuatBan = int.Parse(txtNamXuatBan.Text);

            // 2. Thành lập đối tượng sach
            Sach x = new Sach();
            x.MaSach = maSach;
            x.TieuDe = tieuDe;
            x.DanhSachTacGia = danhSachTacGia;
            x.MaNhaXuatBan = maNhaXuatBan;
            x.NamXuatBan = namXuatBan;

            // 3. Thực hiện lưu lên csdl
            BizSach bizSach = new BizSach();
            bizSach.Insert(x);
        }
    }
}
