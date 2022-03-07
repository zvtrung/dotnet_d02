
namespace QuanLySach
{
    partial class FormSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSach));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNapLai = new System.Windows.Forms.ToolStripButton();
            this.btnSach_ThemMoi = new System.Windows.Forms.ToolStripButton();
            this.btnSach_Sua = new System.Windows.Forms.ToolStripButton();
            this.btnSach_Xoa = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblThongKe = new System.Windows.Forms.ToolStripStatusLabel();
            this.gridSach = new System.Windows.Forms.DataGridView();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSach)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNapLai,
            this.btnSach_ThemMoi,
            this.btnSach_Sua,
            this.btnSach_Xoa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(619, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNapLai
            // 
            this.btnNapLai.Image = ((System.Drawing.Image)(resources.GetObject("btnNapLai.Image")));
            this.btnNapLai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNapLai.Name = "btnNapLai";
            this.btnNapLai.Size = new System.Drawing.Size(64, 22);
            this.btnNapLai.Text = "Nạp lại";
            this.btnNapLai.Click += new System.EventHandler(this.btnNapLai_Click);
            // 
            // btnSach_ThemMoi
            // 
            this.btnSach_ThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnSach_ThemMoi.Image")));
            this.btnSach_ThemMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSach_ThemMoi.Name = "btnSach_ThemMoi";
            this.btnSach_ThemMoi.Size = new System.Drawing.Size(81, 22);
            this.btnSach_ThemMoi.Text = "Thêm mới";
            this.btnSach_ThemMoi.Click += new System.EventHandler(this.btnSach_ThemMoi_Click);
            // 
            // btnSach_Sua
            // 
            this.btnSach_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btnSach_Sua.Image")));
            this.btnSach_Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSach_Sua.Name = "btnSach_Sua";
            this.btnSach_Sua.Size = new System.Drawing.Size(80, 22);
            this.btnSach_Sua.Text = "Chỉnh sửa";
            // 
            // btnSach_Xoa
            // 
            this.btnSach_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btnSach_Xoa.Image")));
            this.btnSach_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSach_Xoa.Name = "btnSach_Xoa";
            this.btnSach_Xoa.Size = new System.Drawing.Size(47, 22);
            this.btnSach_Xoa.Text = "Xoá";
            this.btnSach_Xoa.Click += new System.EventHandler(this.btnSach_Xoa_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblThongKe});
            this.statusStrip1.Location = new System.Drawing.Point(0, 289);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(619, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblThongKe
            // 
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(102, 17);
            this.lblThongKe.Text = "Có {0} quyển sách";
            this.lblThongKe.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // gridSach
            // 
            this.gridSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSach,
            this.colTieuDe,
            this.colTacGia});
            this.gridSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSach.Location = new System.Drawing.Point(0, 25);
            this.gridSach.Name = "gridSach";
            this.gridSach.Size = new System.Drawing.Size(619, 264);
            this.gridSach.TabIndex = 2;
            // 
            // colMaSach
            // 
            this.colMaSach.HeaderText = "Mã sách";
            this.colMaSach.Name = "colMaSach";
            // 
            // colTieuDe
            // 
            this.colTieuDe.HeaderText = "Tiêu đề";
            this.colTieuDe.MinimumWidth = 150;
            this.colTieuDe.Name = "colTieuDe";
            this.colTieuDe.Width = 200;
            // 
            // colTacGia
            // 
            this.colTacGia.HeaderText = "Tác giả";
            this.colTacGia.MinimumWidth = 120;
            this.colTacGia.Name = "colTacGia";
            this.colTacGia.Width = 150;
            // 
            // FormSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 311);
            this.Controls.Add(this.gridSach);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormSach";
            this.Text = "Quản lý sách";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNapLai;
        private System.Windows.Forms.ToolStripButton btnSach_ThemMoi;
        private System.Windows.Forms.ToolStripButton btnSach_Sua;
        private System.Windows.Forms.ToolStripButton btnSach_Xoa;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblThongKe;
        private System.Windows.Forms.DataGridView gridSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTacGia;
    }
}

