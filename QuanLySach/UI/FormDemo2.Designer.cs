
namespace QuanLySach.UI
{
    partial class FormDemo2
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
            this.gridSach = new System.Windows.Forms.DataGridView();
            this.lblNhaXuatBan = new System.Windows.Forms.Label();
            this.bsNhaXuatBan = new System.Windows.Forms.BindingSource(this.components);
            this.bsSach = new System.Windows.Forms.BindingSource(this.components);
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxNhaXuatBan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNhaXuatBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSach)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSach
            // 
            this.gridSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSach.BackgroundColor = System.Drawing.Color.White;
            this.gridSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSach,
            this.colTieuDe,
            this.colTacGia});
            this.gridSach.Location = new System.Drawing.Point(12, 137);
            this.gridSach.Name = "gridSach";
            this.gridSach.Size = new System.Drawing.Size(759, 378);
            this.gridSach.TabIndex = 3;
            // 
            // lblNhaXuatBan
            // 
            this.lblNhaXuatBan.AutoSize = true;
            this.lblNhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaXuatBan.Location = new System.Drawing.Point(12, 112);
            this.lblNhaXuatBan.Name = "lblNhaXuatBan";
            this.lblNhaXuatBan.Size = new System.Drawing.Size(329, 20);
            this.lblNhaXuatBan.TabIndex = 4;
            this.lblNhaXuatBan.Text = "Danh sách ấn phẩm của nhà xuất bản {}";
            // 
            // bsNhaXuatBan
            // 
            this.bsNhaXuatBan.CurrentChanged += new System.EventHandler(this.bsNhaXuatBan_CurrentChanged);
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
            this.colTieuDe.DataPropertyName = "TieuDe";
            this.colTieuDe.HeaderText = "Tiêu đề";
            this.colTieuDe.MinimumWidth = 150;
            this.colTieuDe.Name = "colTieuDe";
            // 
            // colTacGia
            // 
            this.colTacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTacGia.DataPropertyName = "DanhSachTacGia";
            this.colTacGia.HeaderText = "Tác giả";
            this.colTacGia.MinimumWidth = 120;
            this.colTacGia.Name = "colTacGia";
            this.colTacGia.Width = 120;
            // 
            // cbxNhaXuatBan
            // 
            this.cbxNhaXuatBan.FormattingEnabled = true;
            this.cbxNhaXuatBan.Location = new System.Drawing.Point(12, 23);
            this.cbxNhaXuatBan.Name = "cbxNhaXuatBan";
            this.cbxNhaXuatBan.Size = new System.Drawing.Size(449, 21);
            this.cbxNhaXuatBan.TabIndex = 5;
            // 
            // FormDemo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 527);
            this.Controls.Add(this.cbxNhaXuatBan);
            this.Controls.Add(this.lblNhaXuatBan);
            this.Controls.Add(this.gridSach);
            this.Name = "FormDemo2";
            this.Text = "FormDemo2";
            ((System.ComponentModel.ISupportInitialize)(this.gridSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNhaXuatBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridSach;
        private System.Windows.Forms.Label lblNhaXuatBan;
        private System.Windows.Forms.BindingSource bsNhaXuatBan;
        private System.Windows.Forms.BindingSource bsSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTacGia;
        private System.Windows.Forms.ComboBox cbxNhaXuatBan;
    }
}