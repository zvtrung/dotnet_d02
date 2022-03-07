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
        /// <summary>
        /// Thực thế sách vừa mới chèn thành công
        /// </summary>
        /// <value>
        /// The inserted sach.
        /// </value>
        public Sach InsertedSach { get; private set; }

        public FormSachNew()
        {
            InitializeComponent();

            // Nạp danh sách các nhà xuất bản vào cbxNhaXuatBan để người dùng có thể chọn
            BizNhaXuatBan bizNXB = new BizNhaXuatBan();

            List<NhaXuatBan> lst = bizNXB.GetAll();
            cbxNhaXuatBan.DataSource = lst;
            cbxNhaXuatBan.DisplayMember = "TenNhaXuatBan";
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
            Sach x = new Sach();
            x.MaSach = maSach;
            x.TieuDe = tieuDe;
            x.DanhSachTacGia = danhSachTacGia;
            x.MaNhaXuatBan = maNhaXuatBan;
            x.NamXuatBan = namXuatBan;

            // 3. Thực hiện lưu lên csdl
            BizSach bizSach = new BizSach();
            bizSach.Insert(x);

            this.InsertedSach = x;

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
