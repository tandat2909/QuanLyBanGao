
namespace QLCuaHangGao
{
    partial class FormQLBanHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnKhoHang = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nubSL = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grbChiTietSP = new System.Windows.Forms.GroupBox();
            this.lbPriceSP = new System.Windows.Forms.Label();
            this.lbNameSP = new System.Windows.Forms.Label();
            this.lbMaSP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAddSP = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbTimer = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.colNameSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nubSL)).BeginInit();
            this.grbChiTietSP.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 101);
            this.label1.TabIndex = 1;
            this.label1.Text = "GẠO Store";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.PowderBlue;
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.btnSanPham);
            this.panelLeft.Controls.Add(this.btnKhoHang);
            this.panelLeft.Controls.Add(this.btnNhanVien);
            this.panelLeft.Controls.Add(this.btnHoaDon);
            this.panelLeft.Controls.Add(this.btnThoat);
            this.panelLeft.Controls.Add(this.btnMenu);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(225, 700);
            this.panelLeft.TabIndex = 0;
            // 
            // btnSanPham
            // 
            this.btnSanPham.FlatAppearance.BorderSize = 2;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Image = global::QLCuaHangGao.Properties.Resources.icons8_flour_40px;
            this.btnSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.Location = new System.Drawing.Point(3, 269);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(219, 58);
            this.btnSanPham.TabIndex = 1;
            this.btnSanPham.Text = "Sản Phẩm";
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnKhoHang
            // 
            this.btnKhoHang.FlatAppearance.BorderSize = 2;
            this.btnKhoHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoHang.Image = global::QLCuaHangGao.Properties.Resources.icons8_hangar_30px;
            this.btnKhoHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoHang.Location = new System.Drawing.Point(3, 333);
            this.btnKhoHang.Name = "btnKhoHang";
            this.btnKhoHang.Size = new System.Drawing.Size(219, 58);
            this.btnKhoHang.TabIndex = 1;
            this.btnKhoHang.Text = "Kho Hàng";
            this.btnKhoHang.UseVisualStyleBackColor = true;
            this.btnKhoHang.Click += new System.EventHandler(this.btnKhoHang_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.FlatAppearance.BorderSize = 2;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Image = global::QLCuaHangGao.Properties.Resources.icons8_profiles_30px;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(3, 397);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(219, 58);
            this.btnNhanVien.TabIndex = 1;
            this.btnNhanVien.Text = "  Nhân Viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.FlatAppearance.BorderSize = 2;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Image = global::QLCuaHangGao.Properties.Resources.icons8_invoice_paid_32px;
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(3, 461);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(219, 58);
            this.btnHoaDon.TabIndex = 1;
            this.btnHoaDon.Text = "Hóa Đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.FlatAppearance.BorderSize = 2;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Image = global::QLCuaHangGao.Properties.Resources.icons8_logout_rounded_left_30px;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(3, 525);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(219, 58);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.PowderBlue;
            this.btnMenu.BackgroundImage = global::QLCuaHangGao.Properties.Resources.menu;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.FlatAppearance.BorderSize = 2;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(170, 1);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(52, 46);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.nubSL);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtSearchSP);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.grbChiTietSP);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btnAddSP);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1279, 202);
            this.panel2.TabIndex = 1;
            // 
            // nubSL
            // 
            this.nubSL.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nubSL.Location = new System.Drawing.Point(689, 51);
            this.nubSL.Name = "nubSL";
            this.nubSL.Size = new System.Drawing.Size(57, 40);
            this.nubSL.TabIndex = 3;
            this.nubSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nubSL.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.PowderBlue;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(572, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 48);
            this.label7.TabIndex = 2;
            this.label7.Text = "Số Lượng :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearchSP
            // 
            this.txtSearchSP.CausesValidation = false;
            this.txtSearchSP.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSP.Location = new System.Drawing.Point(240, 50);
            this.txtSearchSP.Name = "txtSearchSP";
            this.txtSearchSP.Size = new System.Drawing.Size(268, 40);
            this.txtSearchSP.TabIndex = 2;
            this.txtSearchSP.TextChanged += new System.EventHandler(this.txtSearchSP_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(264, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 21);
            this.label6.TabIndex = 2;
            // 
            // grbChiTietSP
            // 
            this.grbChiTietSP.Controls.Add(this.lbPriceSP);
            this.grbChiTietSP.Controls.Add(this.lbNameSP);
            this.grbChiTietSP.Controls.Add(this.lbMaSP);
            this.grbChiTietSP.Controls.Add(this.label4);
            this.grbChiTietSP.Controls.Add(this.label3);
            this.grbChiTietSP.Controls.Add(this.label2);
            this.grbChiTietSP.Location = new System.Drawing.Point(761, 3);
            this.grbChiTietSP.Name = "grbChiTietSP";
            this.grbChiTietSP.Size = new System.Drawing.Size(513, 194);
            this.grbChiTietSP.TabIndex = 0;
            this.grbChiTietSP.TabStop = false;
            this.grbChiTietSP.Text = "Thông tin sản phẩm";
            // 
            // lbPriceSP
            // 
            this.lbPriceSP.BackColor = System.Drawing.Color.White;
            this.lbPriceSP.Location = new System.Drawing.Point(157, 131);
            this.lbPriceSP.Name = "lbPriceSP";
            this.lbPriceSP.Size = new System.Drawing.Size(310, 35);
            this.lbPriceSP.TabIndex = 3;
            this.lbPriceSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNameSP
            // 
            this.lbNameSP.BackColor = System.Drawing.Color.White;
            this.lbNameSP.Location = new System.Drawing.Point(157, 83);
            this.lbNameSP.Name = "lbNameSP";
            this.lbNameSP.Size = new System.Drawing.Size(310, 35);
            this.lbNameSP.TabIndex = 3;
            this.lbNameSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMaSP
            // 
            this.lbMaSP.BackColor = System.Drawing.Color.White;
            this.lbMaSP.Location = new System.Drawing.Point(157, 35);
            this.lbMaSP.Name = "lbMaSP";
            this.lbMaSP.Size = new System.Drawing.Size(310, 35);
            this.lbMaSP.TabIndex = 3;
            this.lbMaSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đơn Giá :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên SP :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã SP :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(236, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 21);
            this.label12.TabIndex = 2;
            this.label12.Text = "Mã SP :";
            // 
            // btnAddSP
            // 
            this.btnAddSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddSP.Enabled = false;
            this.btnAddSP.FlatAppearance.BorderSize = 2;
            this.btnAddSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSP.Image = global::QLCuaHangGao.Properties.Resources.icons8_add_shopping_cart_24px;
            this.btnAddSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSP.Location = new System.Drawing.Point(420, 134);
            this.btnAddSP.Name = "btnAddSP";
            this.btnAddSP.Size = new System.Drawing.Size(164, 60);
            this.btnAddSP.TabIndex = 1;
            this.btnAddSP.Text = "Thêm SP";
            this.btnAddSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSP.UseVisualStyleBackColor = false;
            this.btnAddSP.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::QLCuaHangGao.Properties.Resources.icons8_search_more_24px;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(240, 134);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(165, 60);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbTimer
            // 
            this.lbTimer.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(229, 11);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(208, 46);
            this.lbTimer.TabIndex = 2;
            this.lbTimer.Text = "HH:MM:SS";
            this.lbTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbTongTien);
            this.groupBox3.Location = new System.Drawing.Point(843, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 291);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thành Tiền";
            // 
            // lbTongTien
            // 
            this.lbTongTien.BackColor = System.Drawing.Color.White;
            this.lbTongTien.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(6, 58);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(419, 173);
            this.lbTongTien.TabIndex = 3;
            this.lbTongTien.Text = "0";
            this.lbTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOrder);
            this.groupBox1.Location = new System.Drawing.Point(229, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 424);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết đơn hàng";
            // 
            // dgvOrder
            // 
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrder.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNameSP,
            this.colMaSP,
            this.colSLSP,
            this.colPrice});
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrder.Location = new System.Drawing.Point(3, 26);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(602, 395);
            this.dgvOrder.TabIndex = 0;
            this.dgvOrder.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellEnter);
            // 
            // colNameSP
            // 
            this.colNameSP.HeaderText = "Tên";
            this.colNameSP.MinimumWidth = 6;
            this.colNameSP.Name = "colNameSP";
            this.colNameSP.ReadOnly = true;
            // 
            // colMaSP
            // 
            this.colMaSP.HeaderText = "Mã";
            this.colMaSP.MinimumWidth = 6;
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.ReadOnly = true;
            // 
            // colSLSP
            // 
            this.colSLSP.HeaderText = "SL";
            this.colSLSP.MinimumWidth = 6;
            this.colSLSP.Name = "colSLSP";
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Đơn Giá";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(27, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(458, 58);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quản lý cửa hàng Gạo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(484, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 66);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLCuaHangGao.Properties.Resources.icons8_wheat_48px;
            this.pictureBox1.Location = new System.Drawing.Point(468, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QLCuaHangGao.Properties.Resources.icons8_wheat_48px;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveOrder.FlatAppearance.BorderSize = 2;
            this.btnSaveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOrder.Image = global::QLCuaHangGao.Properties.Resources.icons8_data_recovery_26px;
            this.btnSaveOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveOrder.Location = new System.Drawing.Point(1066, 602);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(189, 58);
            this.btnSaveOrder.TabIndex = 1;
            this.btnSaveOrder.Text = "Lưu";
            this.btnSaveOrder.UseVisualStyleBackColor = false;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::QLCuaHangGao.Properties.Resources.icons8_recycle_bin_24px;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(853, 602);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(185, 58);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormQLBanHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 700);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormQLBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Cửa Hàng Gạo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormQLBanHang_FormClosed);
            this.Load += new System.EventHandler(this.FormQLBanHang_Load);
            this.panelLeft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nubSL)).EndInit();
            this.grbChiTietSP.ResumeLayout(false);
            this.grbChiTietSP.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnKhoHang;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbChiTietSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnAddSP;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbPriceSP;
        private System.Windows.Forms.Label lbNameSP;
        private System.Windows.Forms.Label lbMaSP;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nubSL;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
    }
}

