using HelloDotNET.BLL;
using HelloDotNET.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWinForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnDongLai_Click(object sender, EventArgs e)
        {
            // phương thức xử lý sự kiện cho button1
            // wire event Click to event-handler
            //for (int i = 100; i >= 20; i--)
            //{
            //    this.Opacity = (float)i / 100;
            //}

            this.Close();
        }

        private void btnNapTuFile_Click(object sender, EventArgs e)
        {
            try
            {
                // phương thức xử lý sự kiện khi user bấm nút NapTuFile
                // Nạp danh sách hình tròn từ file
                string stFileHinhTron = txtFileHinhTron.Text;
                BizHinhTron bizHinhTron = new BizHinhTron(stFileHinhTron);
                List<HinhTron> lst = bizHinhTron.ReadAll();


                // Hiển thị lên listbox
                // lbxHinhTron.DataSource = lst;
                lbxHinhTron.Items.Clear();
                for (int i = 0; i < lst.Count; i++)
                {
                    HinhTron x = lst[i];
                    lbxHinhTron.Items.Add("Hình tròn bk = " + x.getBanKinh());
                }
            }
            catch (Exception exc)
            {
                /// Thông báo lỗi
                MessageBox.Show("Lỗi trong quá trình đọc file " + exc.Message);
                return;
            }
        }
    }
}
