using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using QuanLySach.Model;
using System.Data.Common;

namespace HelloADOdotNET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NhaXuatBan GetSelectedNXB()
        {
            NhaXuatBan x = null;
            if (bsNhaXuatBan.Current != null)
                x = (NhaXuatBan)bsNhaXuatBan.Current;
            return x;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            List<NhaXuatBan> lst = new List<NhaXuatBan>();

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

            #region 2. Đọc dữ liệu
            cnn.Open();

            // a. Tạo command
            DbCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "SELECT MaNhaXuatBan, TenNhaXuatBan FROM NhaXuatBan";
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "spGetNhaXuatBanList";
            //cmd.CommandType = CommandType.StoredProcedure;

            // b. Thực thi command
            DbDataReader dr = cmd.ExecuteReader();

            // c. Khai thác dữ liệu trên command
            while (dr.Read())
            {
                // Xử lý record hiện tại của dr
                int maNXB = dr.GetInt32(0);
                string tenNXB = dr.GetString(1);
                NhaXuatBan x = new NhaXuatBan();
                x.MaNhaXuatBan = maNXB;
                x.TenNhaXuatBan = tenNXB;

                lst.Add(x);
            }
            #endregion

            #region 3. Giải phóng tài nguyên
            cnn.Close();
            //MessageBox.Show("Đã đóng kết nối");
            #endregion

            bsNhaXuatBan.DataSource = lst;
            gridNhaXuatBan.DataSource = bsNhaXuatBan;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            #region NhaXuatBan x = NXB đang được chọn trên giao diện
            NhaXuatBan x = GetSelectedNXB();

            if (x == null)
            {
                MessageBox.Show("Vui lòng chọn 1 nxb để xoá");
                return;
            }
            #endregion

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
            //cmd.CommandText = $"DELETE NhaXuatBan WHERE MaNhaXuatBan = {x.MaNhaXuatBan}";
            //cmd.CommandType = CommandType.Text;

            //// SQL Injection
            //string sql = $"DELETE NhaXuatBan WHERE TenNhaXuatBan = N'{x.TenNhaXuatBan}'";
            //cmd.CommandText = sql;
            //cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE NhaXuatBan WHERE TenNhaXuatBan = @TenNhaXuatBan AND MaNhaXuatBan = @MaNXB";

            //SqlParameter pTenNhaXuatBan = new SqlParameter("@TenNhaXuatBan", SqlDbType.NVarChar);
            //pTenNhaXuatBan.Value = x.TenNhaXuatBan;
            //cmd.Parameters.Add(pTenNhaXuatBan);

            //SqlParameter pMaNhaXuatBan = new SqlParameter("@MaNXB", SqlDbType.Int);
            //pMaNhaXuatBan.Value = x.MaNhaXuatBan;
            //cmd.Parameters.Add(pMaNhaXuatBan);

            DbUtils.CreateAndAddParam(cmd, "@TenNhaXuatBan", DbType.String, x.TenNhaXuatBan);
            DbUtils.CreateAndAddParam(cmd, "@MaNXB", DbType.Int32, x.MaNhaXuatBan);
            
            // b. Thực thi command dạng ACTION
            int nRowsEffected = cmd.ExecuteNonQuery();

            #region 3. Giải phóng tài nguyên
            cnn.Close();
            //MessageBox.Show("Đã đóng kết nối");
            #endregion

            // c. Khai thác dữ liệu trên command
            if (nRowsEffected == 0)
                MessageBox.Show("Không xoá được NXB tương ứng");
            else
            {
                MessageBox.Show($"Đã xoá {nRowsEffected} NXB");
                btnSelect.PerformClick();
                //btnSelect_Click(null, null);
            }
            #endregion

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Lấy NXB đang chọn trên GUI
            NhaXuatBan x = this.GetSelectedNXB();

            // Hiển thị form chỉnh sửa theo đối tượng này
            if (x == null)
            {
                MessageBox.Show("Vui lòng chọn 1 nxb để chỉnh sửa");
                return;
            }
            else
            {
                FormNhaXuatBan_Sua frm = new FormNhaXuatBan_Sua();
                frm.setNXB(x);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    btnSelect.PerformClick();
                }
            }
        }
    }
}
