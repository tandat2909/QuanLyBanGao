
namespace QLCuaHangGao
{
    partial class FormKhoHang
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
            this.label5 = new System.Windows.Forms.Label();
            this.dgvChiTietKhoHang = new System.Windows.Forms.DataGridView();
            this.MaKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTonKho = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtNgayNhap = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grbChiTietSP = new System.Windows.Forms.GroupBox();
            this.txtNV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxSP = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietKhoHang)).BeginInit();
            this.grbChiTietSP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(447, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 53);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quản lý kho hàng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvChiTietKhoHang
            // 
            this.dgvChiTietKhoHang.AllowUserToOrderColumns = true;
            this.dgvChiTietKhoHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietKhoHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvChiTietKhoHang.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvChiTietKhoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietKhoHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKho,
            this.Column2,
            this.NV,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvChiTietKhoHang.Location = new System.Drawing.Point(38, 95);
            this.dgvChiTietKhoHang.Margin = new System.Windows.Forms.Padding(5);
            this.dgvChiTietKhoHang.Name = "dgvChiTietKhoHang";
            this.dgvChiTietKhoHang.RowHeadersWidth = 51;
            this.dgvChiTietKhoHang.RowTemplate.Height = 24;
            this.dgvChiTietKhoHang.Size = new System.Drawing.Size(771, 444);
            this.dgvChiTietKhoHang.TabIndex = 6;
            this.dgvChiTietKhoHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietKhoHang_CellClick);
            // 
            // MaKho
            // 
            this.MaKho.FillWeight = 50F;
            this.MaKho.HeaderText = "Mã Kho";
            this.MaKho.Name = "MaKho";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên SP";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // NV
            // 
            this.NV.HeaderText = "Nhân Viên";
            this.NV.Name = "NV";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày Nhập";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số Lượng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tồn Kho";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(18, 636);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1146, 17);
            this.label3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(1164, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 636);
            this.label4.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 636);
            this.label2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1182, 17);
            this.label1.TabIndex = 11;
            // 
            // txtTonKho
            // 
            this.txtTonKho.Location = new System.Drawing.Point(124, 303);
            this.txtTonKho.Name = "txtTonKho";
            this.txtTonKho.ReadOnly = true;
            this.txtTonKho.Size = new System.Drawing.Size(199, 27);
            this.txtTonKho.TabIndex = 3;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(124, 257);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(199, 27);
            this.txtSoLuong.TabIndex = 3;
            // 
            // txtNgayNhap
            // 
            this.txtNgayNhap.Location = new System.Drawing.Point(124, 207);
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.ReadOnly = true;
            this.txtNgayNhap.Size = new System.Drawing.Size(199, 27);
            this.txtNgayNhap.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 306);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "Tồn kho :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 21);
            this.label12.TabIndex = 2;
            this.label12.Text = "Số lượng :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày nhập :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên SP :";
            // 
            // grbChiTietSP
            // 
            this.grbChiTietSP.Controls.Add(this.txtNV);
            this.grbChiTietSP.Controls.Add(this.label9);
            this.grbChiTietSP.Controls.Add(this.txtMaKho);
            this.grbChiTietSP.Controls.Add(this.label8);
            this.grbChiTietSP.Controls.Add(this.cbxSP);
            this.grbChiTietSP.Controls.Add(this.txtTonKho);
            this.grbChiTietSP.Controls.Add(this.txtSoLuong);
            this.grbChiTietSP.Controls.Add(this.txtNgayNhap);
            this.grbChiTietSP.Controls.Add(this.label13);
            this.grbChiTietSP.Controls.Add(this.label12);
            this.grbChiTietSP.Controls.Add(this.label6);
            this.grbChiTietSP.Controls.Add(this.label7);
            this.grbChiTietSP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChiTietSP.Location = new System.Drawing.Point(789, 18);
            this.grbChiTietSP.Name = "grbChiTietSP";
            this.grbChiTietSP.Size = new System.Drawing.Size(329, 352);
            this.grbChiTietSP.TabIndex = 1;
            this.grbChiTietSP.TabStop = false;
            this.grbChiTietSP.Text = "Thông tin kho hàng";
            // 
            // txtNV
            // 
            this.txtNV.Location = new System.Drawing.Point(124, 160);
            this.txtNV.Name = "txtNV";
            this.txtNV.ReadOnly = true;
            this.txtNV.Size = new System.Drawing.Size(199, 27);
            this.txtNV.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Nhân Viên";
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(124, 60);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.ReadOnly = true;
            this.txtMaKho.Size = new System.Drawing.Size(199, 27);
            this.txtMaKho.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Mã Kho:";
            // 
            // cbxSP
            // 
            this.cbxSP.FormattingEnabled = true;
            this.cbxSP.Location = new System.Drawing.Point(124, 112);
            this.cbxSP.Name = "cbxSP";
            this.cbxSP.Size = new System.Drawing.Size(199, 29);
            this.cbxSP.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grbChiTietSP);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1126, 493);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết kho hàng";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTimKiem.FlatAppearance.BorderSize = 2;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Image = global::QLCuaHangGao.Properties.Resources.icons8_search_more_24px;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(789, 388);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(329, 47);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemSP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThemSP.FlatAppearance.BorderSize = 2;
            this.btnThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSP.Image = global::QLCuaHangGao.Properties.Resources.icons8_add_shopping_cart_24px;
            this.btnThemSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSP.Location = new System.Drawing.Point(169, 559);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(165, 56);
            this.btnThemSP.TabIndex = 15;
            this.btnThemSP.Text = "Thêm Kho";
            this.btnThemSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXoa.FlatAppearance.BorderSize = 2;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Image = global::QLCuaHangGao.Properties.Resources.icons8_recycle_bin_24px;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(342, 559);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(166, 56);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCapNhat.FlatAppearance.BorderSize = 2;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Image = global::QLCuaHangGao.Properties.Resources.icons8_open_end_wrench_24px;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(518, 559);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(5);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(173, 56);
            this.btnCapNhat.TabIndex = 14;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // FormKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvChiTietKhoHang);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormKhoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Kho Hàng";
            this.Load += new System.EventHandler(this.FormKhoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietKhoHang)).EndInit();
            this.grbChiTietSP.ResumeLayout(false);
            this.grbChiTietSP.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvChiTietKhoHang;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTonKho;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtNgayNhap;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbChiTietSP;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtNV;
        private System.Windows.Forms.Label label9;
    }
}