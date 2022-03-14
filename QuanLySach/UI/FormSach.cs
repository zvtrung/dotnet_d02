using QuanLySach.BLL;
using QuanLySach.Model;
using QuanLySach.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach
{
    public partial class FormSach : Form
    {
        public FormSach()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnNapLai_Click(object sender, EventArgs e)
        {
            // Nạp danh sách các quyển sách và hiển thị lên grid
            BizSach bizSach = new BizSach();

            List<Sach> lst = bizSach.ReadAll();

            // Hiển thị lên GUI / grid
            colMaSach.DataPropertyName = "MaSach";
            colTacGia.DataPropertyName = "DanhSachTacGia";
            colTieuDe.DataPropertyName = "TieuDe";

            gridSach.AutoGenerateColumns = false;
            gridSach.DataSource = lst;
        }

        private void btnSach_ThemMoi_Click(object sender, EventArgs e)
        {
            // Mở form FormSachNew
            FormSachNew frm = new FormSachNew();
            
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                // Nếu chèn thành công thì nạp lại danh sách
                Sach x = frm.InsertedSach;

                // thêm vào grid
                List<Sach> lst = (List<Sach>)(gridSach.DataSource);
                lst.Add(x);
                gridSach.DataSource = null;
                gridSach.DataSource = lst;
            }
            else
            {
                // Do nothing!
            }
        }

        private void btnSach_Xoa_Click(object sender, EventArgs e)
        {
            // Xoá quyển sách đang được chọn trên grid
            // 1. Xác định sach đang được chọn
            DataGridViewRow selectedRow = gridSach.CurrentRow;
            Sach sach = (Sach)selectedRow.DataBoundItem;

            // 2. Thực hiện xoá bizSach.Xoa(sach)
            BizSach bizSach = new BizSach();
            if (bizSach.Xoa(sach) == true)
            {
                // Xoá đối tượng Sach khỏi grid

                // thêm vào grid
                List<Sach> lst = (List<Sach>)(gridSach.DataSource);
                lst.Remove(sach);
                gridSach.DataSource = null;
                gridSach.DataSource = lst;
            }
        }

        private void btnSach_Sua_Click(object sender, EventArgs e)
        {
            // Xác định đối tượng đang chọn
            DataGridViewRow selectedRow = gridSach.CurrentRow;
            Sach sach = (Sach)selectedRow.DataBoundItem;

            // Tạo form chỉnh sửa cho đối tượng đang chọn
            FormSachEdit frm = new FormSachEdit(sach);

            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                // Cập nhật danh sách cho đối tượng vừa sửa xong
                //gridSach.
            }
        }
    }
}
