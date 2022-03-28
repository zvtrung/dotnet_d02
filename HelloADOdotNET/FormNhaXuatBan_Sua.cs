using QuanLySach.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloADOdotNET
{
    public partial class FormNhaXuatBan_Sua : Form
    {
        private NhaXuatBan _nxb;

        public FormNhaXuatBan_Sua()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        internal void setNXB(NhaXuatBan x)
        {
            this._nxb = x;

            // hiển thị thông tin nxb lên GUI
            txtMaNXB.Text = _nxb.MaNhaXuatBan.ToString();
            txtTenNXB.Text = _nxb.TenNhaXuatBan;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            #region 1. cnn = tạo kết nối or NULL on error;
            DbConnection cnn = null;
            try
            {
                cnn = DbUtils.GetConnection();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi kết nối " + exc.Message);
                return;
            }
            #endregion

            #region 2. Thao với nguồn dữ liệu
            cnn.Open();

            // a. Tạo command
            DbCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE NhaXuatBan SET TenNhaXuatBan = @TenNhaXuatBan WHERE MaNhaXuatBan = @MaNXB";

            //SqlParameter pTenNhaXuatBan = new SqlParameter("@TenNhaXuatBan", SqlDbType.NVarChar);
            //pTenNhaXuatBan.Value = txtTenNXB.Text.Trim();
            //cmd.Parameters.Add(pTenNhaXuatBan);

            //SqlParameter pMaNhaXuatBan = new SqlParameter("@MaNXB", SqlDbType.Int);
            //pMaNhaXuatBan.Value = _nxb.MaNhaXuatBan;
            //cmd.Parameters.Add(pMaNhaXuatBan);

            DbUtils.CreateAndAddParam(cmd, "@TenNhaXuatBan", DbType.String, txtTenNXB.Text.Trim());
            DbUtils.CreateAndAddParam(cmd, "@MaNXB", DbType.Int32, _nxb.MaNhaXuatBan);

            // b. Thực thi command dạng ACTION
            int nRowsEffected = cmd.ExecuteNonQuery();

            #region 3. Giải phóng tài nguyên
            cnn.Close();
            #endregion

            // c. Khai thác dữ liệu trên command
            if (nRowsEffected > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show($"Không cập nhật được dữ liệu");
            }
            #endregion
        }
    }
}
