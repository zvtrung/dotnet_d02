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
    public partial class FormDemo2 : Form
    {
        public FormDemo2()
        {
            InitializeComponent();

            // Nạp danh sách các nxb
            BizNhaXuatBan bizNXB = new BizNhaXuatBan();
            List<NhaXuatBan> lstNXB = bizNXB.GetAll();
            bsNhaXuatBan.DataSource = lstNXB;

            cbxNhaXuatBan.DataSource = bsNhaXuatBan;
            cbxNhaXuatBan.DisplayMember = "TenNhaXuatBan";
        }

        private void bsNhaXuatBan_CurrentChanged(object sender, EventArgs e)
        {
            // Lấy nxb đang chọn...
            NhaXuatBan nxb = (NhaXuatBan)bsNhaXuatBan.Current;

            // Hiển thị ra lbl
            lblNhaXuatBan.Text = $"Danh sách ấn phẩm của {nxb.TenNhaXuatBan}";
            //lblNhaXuatBan.Text = "Danh sách ấn phẩm của " + nxb.TenNhaXuatBan;

            // Hiển thị danh sách sách của nxb
            BizSach bizSach = new BizSach();
            List<Sach> lstSach = bizSach.GetSachOfNhaXuatBan(nxb.MaNhaXuatBan);
            bsSach.DataSource = lstSach;

            gridSach.AutoGenerateColumns = false;
            gridSach.DataSource = bsSach;
        }
    }
}
