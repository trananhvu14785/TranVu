namespace QuanLyBoSua
{
    partial class frmNhaCungCap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaCungCap));
            this.dgvNhaCungCap = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.maNcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbSdt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbDiaChi = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbTenNcc = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbMaNCc = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMaNcc = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbSdt = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbDiaChi = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbTenNcc = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnSua = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnThem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnXoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tbTimKiem = new Bunifu.Framework.UI.BunifuTextbox();
            this.quanLyBoSuaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLuu = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnHuy = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBoSuaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhaCungCap
            // 
            this.dgvNhaCungCap.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvNhaCungCap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhaCungCap.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvNhaCungCap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhaCungCap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhaCungCap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNcc,
            this.tenNcc,
            this.diaChi,
            this.sdt});
            this.dgvNhaCungCap.DoubleBuffered = true;
            this.dgvNhaCungCap.EnableHeadersVisualStyles = false;
            this.dgvNhaCungCap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvNhaCungCap.HeaderBgColor = System.Drawing.Color.Cyan;
            this.dgvNhaCungCap.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvNhaCungCap.Location = new System.Drawing.Point(6, 307);
            this.dgvNhaCungCap.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNhaCungCap.Name = "dgvNhaCungCap";
            this.dgvNhaCungCap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNhaCungCap.RowHeadersWidth = 51;
            this.dgvNhaCungCap.RowTemplate.Height = 24;
            this.dgvNhaCungCap.Size = new System.Drawing.Size(572, 176);
            this.dgvNhaCungCap.TabIndex = 12;
            this.dgvNhaCungCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhaCungCap_CellClick);
            // 
            // maNcc
            // 
            this.maNcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maNcc.DataPropertyName = "maNcc";
            this.maNcc.HeaderText = "Mã NCC";
            this.maNcc.MinimumWidth = 6;
            this.maNcc.Name = "maNcc";
            this.maNcc.ReadOnly = true;
            // 
            // tenNcc
            // 
            this.tenNcc.DataPropertyName = "tenNcc";
            this.tenNcc.HeaderText = "Tên nhà cung cấp";
            this.tenNcc.MinimumWidth = 6;
            this.tenNcc.Name = "tenNcc";
            this.tenNcc.ReadOnly = true;
            this.tenNcc.Width = 150;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "diachi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.MinimumWidth = 6;
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            this.diaChi.Width = 150;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sodt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            this.sdt.Width = 125;
            // 
            // lbSdt
            // 
            this.lbSdt.AutoSize = true;
            this.lbSdt.BackColor = System.Drawing.Color.Teal;
            this.lbSdt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSdt.ForeColor = System.Drawing.Color.Black;
            this.lbSdt.Location = new System.Drawing.Point(56, 139);
            this.lbSdt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(112, 21);
            this.lbSdt.TabIndex = 0;
            this.lbSdt.Text = "Số điện thoại:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.BackColor = System.Drawing.Color.Teal;
            this.lbDiaChi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.ForeColor = System.Drawing.Color.Black;
            this.lbDiaChi.Location = new System.Drawing.Point(98, 107);
            this.lbDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(67, 21);
            this.lbDiaChi.TabIndex = 0;
            this.lbDiaChi.Text = "Địa chi:";
            // 
            // lbTenNcc
            // 
            this.lbTenNcc.AutoSize = true;
            this.lbTenNcc.BackColor = System.Drawing.Color.Teal;
            this.lbTenNcc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNcc.ForeColor = System.Drawing.Color.Black;
            this.lbTenNcc.Location = new System.Drawing.Point(22, 71);
            this.lbTenNcc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenNcc.Name = "lbTenNcc";
            this.lbTenNcc.Size = new System.Drawing.Size(147, 21);
            this.lbTenNcc.TabIndex = 0;
            this.lbTenNcc.Text = "Tên nhà cung cấp:";
            // 
            // lbMaNCc
            // 
            this.lbMaNCc.AutoSize = true;
            this.lbMaNCc.BackColor = System.Drawing.Color.Teal;
            this.lbMaNCc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNCc.ForeColor = System.Drawing.Color.Black;
            this.lbMaNCc.Location = new System.Drawing.Point(26, 30);
            this.lbMaNCc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaNCc.Name = "lbMaNCc";
            this.lbMaNCc.Size = new System.Drawing.Size(142, 21);
            this.lbMaNCc.TabIndex = 0;
            this.lbMaNCc.Text = "Mã nhà cung cấp:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(222, 9);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(188, 35);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Nhà cung cấp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMaNcc);
            this.groupBox1.Controls.Add(this.tbSdt);
            this.groupBox1.Controls.Add(this.lbMaNCc);
            this.groupBox1.Controls.Add(this.lbTenNcc);
            this.groupBox1.Controls.Add(this.tbDiaChi);
            this.groupBox1.Controls.Add(this.lbDiaChi);
            this.groupBox1.Controls.Add(this.lbSdt);
            this.groupBox1.Controls.Add(this.tbTenNcc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(60, 125);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(462, 178);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbMaNcc
            // 
            this.tbMaNcc.BackColor = System.Drawing.Color.White;
            this.tbMaNcc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbMaNcc.BackgroundImage")));
            this.tbMaNcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbMaNcc.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaNcc.ForeColor = System.Drawing.Color.Black;
            this.tbMaNcc.Icon = ((System.Drawing.Image)(resources.GetObject("tbMaNcc.Icon")));
            this.tbMaNcc.Location = new System.Drawing.Point(182, 30);
            this.tbMaNcc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbMaNcc.Name = "tbMaNcc";
            this.tbMaNcc.Size = new System.Drawing.Size(272, 24);
            this.tbMaNcc.TabIndex = 2;
            this.tbMaNcc.text = "";
            // 
            // tbSdt
            // 
            this.tbSdt.BackColor = System.Drawing.Color.White;
            this.tbSdt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbSdt.BackgroundImage")));
            this.tbSdt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbSdt.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSdt.ForeColor = System.Drawing.Color.Black;
            this.tbSdt.Icon = ((System.Drawing.Image)(resources.GetObject("tbSdt.Icon")));
            this.tbSdt.Location = new System.Drawing.Point(182, 139);
            this.tbSdt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Size = new System.Drawing.Size(272, 24);
            this.tbSdt.TabIndex = 5;
            this.tbSdt.text = "";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.BackColor = System.Drawing.Color.White;
            this.tbDiaChi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbDiaChi.BackgroundImage")));
            this.tbDiaChi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbDiaChi.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiaChi.ForeColor = System.Drawing.Color.Black;
            this.tbDiaChi.Icon = ((System.Drawing.Image)(resources.GetObject("tbDiaChi.Icon")));
            this.tbDiaChi.Location = new System.Drawing.Point(182, 107);
            this.tbDiaChi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(272, 24);
            this.tbDiaChi.TabIndex = 4;
            this.tbDiaChi.text = "";
            // 
            // tbTenNcc
            // 
            this.tbTenNcc.BackColor = System.Drawing.Color.White;
            this.tbTenNcc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTenNcc.BackgroundImage")));
            this.tbTenNcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTenNcc.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenNcc.ForeColor = System.Drawing.Color.Black;
            this.tbTenNcc.Icon = ((System.Drawing.Image)(resources.GetObject("tbTenNcc.Icon")));
            this.tbTenNcc.Location = new System.Drawing.Point(182, 71);
            this.tbTenNcc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbTenNcc.Name = "tbTenNcc";
            this.tbTenNcc.Size = new System.Drawing.Size(272, 24);
            this.tbTenNcc.TabIndex = 3;
            this.tbTenNcc.text = "";
            // 
            // btnSua
            // 
            this.btnSua.ActiveBorderThickness = 1;
            this.btnSua.ActiveCornerRadius = 20;
            this.btnSua.ActiveFillColor = System.Drawing.Color.Blue;
            this.btnSua.ActiveForecolor = System.Drawing.Color.Yellow;
            this.btnSua.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSua.BackColor = System.Drawing.Color.Teal;
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.ButtonText = "Sửa";
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.IdleBorderThickness = 1;
            this.btnSua.IdleCornerRadius = 20;
            this.btnSua.IdleFillColor = System.Drawing.Color.Cyan;
            this.btnSua.IdleForecolor = System.Drawing.Color.Black;
            this.btnSua.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.Location = new System.Drawing.Point(255, 493);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 46);
            this.btnSua.TabIndex = 8;
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.ActiveBorderThickness = 1;
            this.btnThem.ActiveCornerRadius = 20;
            this.btnThem.ActiveFillColor = System.Drawing.Color.Blue;
            this.btnThem.ActiveForecolor = System.Drawing.Color.Yellow;
            this.btnThem.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnThem.BackColor = System.Drawing.Color.Teal;
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.ButtonText = "Thêm";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.IdleBorderThickness = 1;
            this.btnThem.IdleCornerRadius = 20;
            this.btnThem.IdleFillColor = System.Drawing.Color.Cyan;
            this.btnThem.IdleForecolor = System.Drawing.Color.Black;
            this.btnThem.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.Location = new System.Drawing.Point(38, 493);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 46);
            this.btnThem.TabIndex = 9;
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ActiveBorderThickness = 1;
            this.btnXoa.ActiveCornerRadius = 20;
            this.btnXoa.ActiveFillColor = System.Drawing.Color.Blue;
            this.btnXoa.ActiveForecolor = System.Drawing.Color.Yellow;
            this.btnXoa.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnXoa.BackColor = System.Drawing.Color.Teal;
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.ButtonText = "Xóa";
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.IdleBorderThickness = 1;
            this.btnXoa.IdleCornerRadius = 20;
            this.btnXoa.IdleFillColor = System.Drawing.Color.Cyan;
            this.btnXoa.IdleForecolor = System.Drawing.Color.Black;
            this.btnXoa.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.Location = new System.Drawing.Point(148, 492);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 46);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.BackColor = System.Drawing.Color.Teal;
            this.tbTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTimKiem.BackgroundImage")));
            this.tbTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTimKiem.ForeColor = System.Drawing.Color.Cyan;
            this.tbTimKiem.Icon = ((System.Drawing.Image)(resources.GetObject("tbTimKiem.Icon")));
            this.tbTimKiem.Location = new System.Drawing.Point(162, 72);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(309, 28);
            this.tbTimKiem.TabIndex = 6;
            this.tbTimKiem.text = "";
            this.tbTimKiem.OnTextChange += new System.EventHandler(this.tbTimKiem_OnTextChange);
            // 
            // btnLuu
            // 
            this.btnLuu.ActiveBorderThickness = 1;
            this.btnLuu.ActiveCornerRadius = 20;
            this.btnLuu.ActiveFillColor = System.Drawing.Color.Blue;
            this.btnLuu.ActiveForecolor = System.Drawing.Color.Yellow;
            this.btnLuu.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLuu.BackColor = System.Drawing.Color.Teal;
            this.btnLuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.BackgroundImage")));
            this.btnLuu.ButtonText = "Lưu";
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.IdleBorderThickness = 1;
            this.btnLuu.IdleCornerRadius = 20;
            this.btnLuu.IdleFillColor = System.Drawing.Color.Cyan;
            this.btnLuu.IdleForecolor = System.Drawing.Color.Black;
            this.btnLuu.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.Location = new System.Drawing.Point(365, 496);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 44);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ActiveBorderThickness = 1;
            this.btnHuy.ActiveCornerRadius = 20;
            this.btnHuy.ActiveFillColor = System.Drawing.Color.Blue;
            this.btnHuy.ActiveForecolor = System.Drawing.Color.Yellow;
            this.btnHuy.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnHuy.BackColor = System.Drawing.Color.Teal;
            this.btnHuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.BackgroundImage")));
            this.btnHuy.ButtonText = "Hủy";
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.IdleBorderThickness = 1;
            this.btnHuy.IdleCornerRadius = 20;
            this.btnHuy.IdleFillColor = System.Drawing.Color.Cyan;
            this.btnHuy.IdleForecolor = System.Drawing.Color.Black;
            this.btnHuy.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btnHuy.Location = new System.Drawing.Point(470, 496);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(89, 44);
            this.btnHuy.TabIndex = 32;
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(589, 554);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgvNhaCungCap);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHÀ CUNG CẤP";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBoSuaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnSua;
        private System.Windows.Forms.BindingSource quanLyBoSuaDataSetBindingSource;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvNhaCungCap;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThem;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXoa;
        private Bunifu.Framework.UI.BunifuTextbox tbTimKiem;
        private Bunifu.Framework.UI.BunifuTextbox tbSdt;
        private Bunifu.Framework.UI.BunifuTextbox tbDiaChi;
        private Bunifu.Framework.UI.BunifuTextbox tbTenNcc;
        private Bunifu.Framework.UI.BunifuTextbox tbMaNcc;
        private Bunifu.Framework.UI.BunifuCustomLabel lbSdt;
        private Bunifu.Framework.UI.BunifuCustomLabel lbDiaChi;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTenNcc;
        private Bunifu.Framework.UI.BunifuCustomLabel lbMaNCc;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private Bunifu.Framework.UI.BunifuThinButton2 btnHuy;
    }
}