
namespace HelloWinForms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnDongLai = new System.Windows.Forms.Button();
            this.lbxHinhTron = new System.Windows.Forms.ListBox();
            this.btnNapTuFile = new System.Windows.Forms.Button();
            this.txtFileHinhTron = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDongLai
            // 
            this.btnDongLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDongLai.Location = new System.Drawing.Point(396, 407);
            this.btnDongLai.Name = "btnDongLai";
            this.btnDongLai.Size = new System.Drawing.Size(83, 31);
            this.btnDongLai.TabIndex = 0;
            this.btnDongLai.Text = "Đóng lại";
            this.btnDongLai.UseVisualStyleBackColor = true;
            this.btnDongLai.Click += new System.EventHandler(this.btnDongLai_Click);
            // 
            // lbxHinhTron
            // 
            this.lbxHinhTron.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxHinhTron.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxHinhTron.FormattingEnabled = true;
            this.lbxHinhTron.IntegralHeight = false;
            this.lbxHinhTron.ItemHeight = 25;
            this.lbxHinhTron.Items.AddRange(new object[] {
            "Hình tròn 3.5",
            "Hình chữ nhật 4 x 5.3",
            "Hinh chữ nhật 5 x 5"});
            this.lbxHinhTron.Location = new System.Drawing.Point(12, 38);
            this.lbxHinhTron.Name = "lbxHinhTron";
            this.lbxHinhTron.Size = new System.Drawing.Size(467, 363);
            this.lbxHinhTron.TabIndex = 2;
            // 
            // btnNapTuFile
            // 
            this.btnNapTuFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNapTuFile.Location = new System.Drawing.Point(12, 407);
            this.btnNapTuFile.Name = "btnNapTuFile";
            this.btnNapTuFile.Size = new System.Drawing.Size(83, 31);
            this.btnNapTuFile.TabIndex = 0;
            this.btnNapTuFile.Text = "Nạp từ file";
            this.btnNapTuFile.UseVisualStyleBackColor = true;
            this.btnNapTuFile.Click += new System.EventHandler(this.btnNapTuFile_Click);
            // 
            // txtFileHinhTron
            // 
            this.txtFileHinhTron.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileHinhTron.Location = new System.Drawing.Point(79, 12);
            this.txtFileHinhTron.Name = "txtFileHinhTron";
            this.txtFileHinhTron.Size = new System.Drawing.Size(400, 20);
            this.txtFileHinhTron.TabIndex = 3;
            this.txtFileHinhTron.Text = "D:\\T2MProjects\\dnet-workspace\\Day02\\HelloDotNET\\bin\\Debug\\hinhtron.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "File dữ liệu:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileHinhTron);
            this.Controls.Add(this.lbxHinhTron);
            this.Controls.Add(this.btnNapTuFile);
            this.Controls.Add(this.btnDongLai);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Hello WinForms";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDongLai;
        private System.Windows.Forms.ListBox lbxHinhTron;
        private System.Windows.Forms.Button btnNapTuFile;
        private System.Windows.Forms.TextBox txtFileHinhTron;
        private System.Windows.Forms.Label label1;
    }
}

