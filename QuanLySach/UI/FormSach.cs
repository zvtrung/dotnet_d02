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
        }

        private void btnSach_ThemMoi_Click(object sender, EventArgs e)
        {
            // Mở form FormSachNew

            // Nếu chèn thành công thì nạp lại danh sách
        }

        private void btnSach_Xoa_Click(object sender, EventArgs e)
        {
            // Xoá quyển sách đang được chọn trên grid
            // 1. Xác định sach đang được chọn
            Sach sach = null; // quyển sách đang chọn

            // 2. Thực hiện xoá bizSach.Xoa(sach)
            BizSach bizSach = new BizSach();
            bizSach.Xoa(sach);
        }
    }
}
