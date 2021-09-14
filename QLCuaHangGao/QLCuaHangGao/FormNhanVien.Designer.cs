
namespace QLCuaHangGao
{
    partial class FormNhanVien
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
            this.dgvChiTietNhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Họ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quyền = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtNgayBD = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grbChiTietSP = new System.Windows.Forms.GroupBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnChangePW = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhanVien)).BeginInit();
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
            this.label5.Text = "Quản lý nhân viên";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvChiTietNhanVien
            // 
            this.dgvChiTietNhanVien.AllowUserToOrderColumns = true;
            this.dgvChiTietNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietNhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvChiTietNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvChiTietNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.UserName,
            this.Họ,
            this.Column2,
            this.Quyền,
            this.Column4});
            this.dgvChiTietNhanVien.Location = new System.Drawing.Point(38, 95);
            this.dgvChiTietNhanVien.Margin = new System.Windows.Forms.Padding(5);
            this.dgvChiTietNhanVien.Name = "dgvChiTietNhanVien";
            this.dgvChiTietNhanVien.RowHeadersWidth = 51;
            this.dgvChiTietNhanVien.RowTemplate.Height = 24;
            this.dgvChiTietNhanVien.Size = new System.Drawing.Size(757, 444);
            this.dgvChiTietNhanVien.TabIndex = 6;
            this.dgvChiTietNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietNhanVien_CellClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 40F;
            this.Column1.HeaderText = "Mã NV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            // 
            // Họ
            // 
            this.Họ.HeaderText = "Họ";
            this.Họ.Name = "Họ";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Quyền
            // 
            this.Quyền.HeaderText = "Quyền";
            this.Quyền.Name = "Quyền";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày BĐ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
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
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(138, 180);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(199, 27);
            this.txtHo.TabIndex = 3;
            // 
            // txtNgayBD
            // 
            this.txtNgayBD.Location = new System.Drawing.Point(138, 319);
            this.txtNgayBD.Name = "txtNgayBD";
            this.txtNgayBD.ReadOnly = true;
            this.txtNgayBD.Size = new System.Drawing.Size(199, 27);
            this.txtNgayBD.TabIndex = 3;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(138, 226);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(199, 27);
            this.txtTenNV.TabIndex = 3;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(138, 85);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(199, 27);
            this.txtMaNV.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "Họ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày BĐ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên NV :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 21);
            this.label11.TabIndex = 2;
            this.label11.Text = "Mã NV :";
            // 
            // grbChiTietSP
            // 
            this.grbChiTietSP.Controls.Add(this.txtUserName);
            this.grbChiTietSP.Controls.Add(this.label9);
            this.grbChiTietSP.Controls.Add(this.cbxRole);
            this.grbChiTietSP.Controls.Add(this.label8);
            this.grbChiTietSP.Controls.Add(this.txtHo);
            this.grbChiTietSP.Controls.Add(this.txtNgayBD);
            this.grbChiTietSP.Controls.Add(this.txtTenNV);
            this.grbChiTietSP.Controls.Add(this.txtMaNV);
            this.grbChiTietSP.Controls.Add(this.label12);
            this.grbChiTietSP.Controls.Add(this.label6);
            this.grbChiTietSP.Controls.Add(this.label7);
            this.grbChiTietSP.Controls.Add(this.label11);
            this.grbChiTietSP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChiTietSP.Location = new System.Drawing.Point(775, 18);
            this.grbChiTietSP.Name = "grbChiTietSP";
            this.grbChiTietSP.Size = new System.Drawing.Size(343, 367);
            this.grbChiTietSP.TabIndex = 1;
            this.grbChiTietSP.TabStop = false;
            this.grbChiTietSP.Text = "Thông tin nhân viên";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(138, 130);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(199, 27);
            this.txtUserName.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "UserName:";
            // 
            // cbxRole
            // 
            this.cbxRole.Enabled = false;
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(138, 272);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(198, 29);
            this.cbxRole.Sorted = true;
            this.cbxRole.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Quyền:";
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
            this.groupBox1.Text = "Chi tiết nhân viên";
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
            this.btnTimKiem.Location = new System.Drawing.Point(775, 391);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(343, 47);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThem.FlatAppearance.BorderSize = 2;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Image = global::QLCuaHangGao.Properties.Resources.icons8_add_shopping_cart_24px;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(169, 559);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(165, 56);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm NV";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            // btnChangePW
            // 
            this.btnChangePW.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChangePW.FlatAppearance.BorderSize = 2;
            this.btnChangePW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePW.Image = global::QLCuaHangGao.Properties.Resources.icons8_open_end_wrench_24px;
            this.btnChangePW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePW.Location = new System.Drawing.Point(803, 559);
            this.btnChangePW.Margin = new System.Windows.Forms.Padding(5);
            this.btnChangePW.Name = "btnChangePW";
            this.btnChangePW.Size = new System.Drawing.Size(173, 56);
            this.btnChangePW.TabIndex = 16;
            this.btnChangePW.Text = "Đổi Mật Khẩu";
            this.btnChangePW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangePW.UseVisualStyleBackColor = false;
            this.btnChangePW.Click += new System.EventHandler(this.btnChangePW_Click);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.btnChangePW);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvChiTietNhanVien);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhanVien)).EndInit();
            this.grbChiTietSP.ResumeLayout(false);
            this.grbChiTietSP.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvChiTietNhanVien;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtNgayBD;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grbChiTietSP;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Họ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quyền;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnChangePW;
    }
}