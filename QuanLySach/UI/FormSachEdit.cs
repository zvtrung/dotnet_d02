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
    public partial class FormSachEdit : Form
    {
        private Sach _sach;

        public FormSachEdit(Sach sach)
        {
            InitializeComponent();

            _sach = sach;

            // Hiển thị thông tin _sach lên GUI
            txtMaSach.Text = _sach.MaSach.ToString();
            txtTieuDe.Text = _sach.TieuDe;
            txtDanhSachTacGia.Text = _sach.DanhSachTacGia;
            txtNamXuatBan.Text = _sach.NamXuatBan.ToString();

            // Nạp danh sách toàn bộ nxb
            BizNhaXuatBan bizNXB = new BizNhaXuatBan();

            List<NhaXuatBan> lst = bizNXB.GetAll();
            cbxNhaXuatBan.DataSource = lst;
            cbxNhaXuatBan.DisplayMember = "TenNhaXuatBan";

            // cho highlight tại nhà xuất bản tương ứng của _sach
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i].MaNhaXuatBan == _sach.MaNhaXuatBan)
                {
                    cbxNhaXuatBan.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            // 1. Thu thập dữ liệu trên GUI
            int maSach = int.Parse(txtMaSach.Text);
            string tieuDe = txtTieuDe.Text;
            string danhSachTacGia = txtDanhSachTacGia.Text;

            NhaXuatBan selectedNXB = (NhaXuatBan)cbxNhaXuatBan.SelectedItem;
            int maNhaXuatBan = selectedNXB.MaNhaXuatBan;
            int namXuatBan = int.Parse(txtNamXuatBan.Text);

            // 2. Thành lập đối tượng sach
            _sach.MaSach = maSach;
            _sach.TieuDe = tieuDe;
            _sach.DanhSachTacGia = danhSachTacGia;
            _sach.MaNhaXuatBan = maNhaXuatBan;
            _sach.NamXuatBan = namXuatBan;

            // 3. Thực hiện lưu lên csdl
            BizSach bizSach = new BizSach();
            bizSach.Update(_sach);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
