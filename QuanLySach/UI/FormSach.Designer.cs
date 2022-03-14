
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
            this.components = new System.ComponentModel.Container();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bsSach = new System.Windows.Forms.BindingSource(this.components);
            this.grid2 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSach)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(705, 25);
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
            this.btnSach_Sua.Click += new System.EventHandler(this.btnSach_Sua_Click);
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
            this.statusStrip1.Size = new System.Drawing.Size(705, 22);
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
            this.gridSach.BackgroundColor = System.Drawing.Color.White;
            this.gridSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSach,
            this.colTieuDe,
            this.colTacGia});
            this.gridSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSach.Location = new System.Drawing.Point(0, 25);
            this.gridSach.Name = "gridSach";
            this.gridSach.Size = new System.Drawing.Size(418, 264);
            this.gridSach.TabIndex = 2;
            // 
            // colMaSach
            // 
            this.colMaSach.DataPropertyName = "MaSach";
            this.colMaSach.HeaderText = "Mã sách";
            this.colMaSach.Name = "colMaSach";
            // 
            // colTieuDe
            // 
            this.colTieuDe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTieuDe.HeaderText = "Tiêu đề";
            this.colTieuDe.MinimumWidth = 150;
            this.colTieuDe.Name = "colTieuDe";
            // 
            // colTacGia
            // 
            this.colTacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTacGia.DataPropertyName = "DanhSachTacGia222";
            this.colTacGia.HeaderText = "Tác giả";
            this.colTacGia.MinimumWidth = 120;
            this.colTacGia.Name = "colTacGia";
            this.colTacGia.Width = 120;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTacGia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(418, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 264);
            this.panel1.TabIndex = 3;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(6, 26);
            this.txtTacGia.Multiline = true;
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(269, 225);
            this.txtTacGia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tác giả";
            // 
            // bsSach
            // 
            this.bsSach.CurrentChanged += new System.EventHandler(this.bsSach_CurrentChanged);
            // 
            // grid2
            // 
            this.grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid2.Location = new System.Drawing.Point(283, 145);
            this.grid2.Name = "grid2";
            this.grid2.Size = new System.Drawing.Size(227, 107);
            this.grid2.TabIndex = 4;
            // 
            // FormSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 311);
            this.Controls.Add(this.grid2);
            this.Controls.Add(this.gridSach);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormSach";
            this.Text = "Quản lý sách";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.BindingSource bsSach;
        private System.Windows.Forms.DataGridView grid2;
    }
}

