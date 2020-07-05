namespace QuanLyBoSua
{
    partial class frmThuocVacXin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThuocVacXin));
            this.dgvThuoc = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.maThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbThuoc = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbDVT = new System.Windows.Forms.ComboBox();
            this.lbSoLuongCon = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbDVT = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbTenNcc = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbMaThuoc = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTenThuoc = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbSoLuongCon = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbMaThuoc = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbTimKiem = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnThem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnXoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSua = new Bunifu.Framework.UI.BunifuThinButton2();
            this.quanLyBoSuaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLuu = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnHuy = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBoSuaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvThuoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThuoc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvThuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThuoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maThuoc,
            this.tenThuoc,
            this.DVT,
            this.SoLuongCon});
            this.dgvThuoc.DoubleBuffered = true;
            this.dgvThuoc.EnableHeadersVisualStyles = false;
            this.dgvThuoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvThuoc.HeaderBgColor = System.Drawing.Color.Cyan;
            this.dgvThuoc.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvThuoc.Location = new System.Drawing.Point(14, 292);
            this.dgvThuoc.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThuoc.RowHeadersWidth = 51;
            this.dgvThuoc.RowTemplate.Height = 24;
            this.dgvThuoc.Size = new System.Drawing.Size(546, 189);
            this.dgvThuoc.TabIndex = 20;
            this.dgvThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuoc_CellClick);
            // 
            // maThuoc
            // 
            this.maThuoc.DataPropertyName = "mathuoc";
            this.maThuoc.HeaderText = "Mã thuốc";
            this.maThuoc.MinimumWidth = 6;
            this.maThuoc.Name = "maThuoc";
            this.maThuoc.Width = 125;
            // 
            // tenThuoc
            // 
            this.tenThuoc.DataPropertyName = "tenthuoc";
            this.tenThuoc.HeaderText = "Tên thuốc";
            this.tenThuoc.MinimumWidth = 6;
            this.tenThuoc.Name = "tenThuoc";
            this.tenThuoc.Width = 125;
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "donvitinh";
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.MinimumWidth = 6;
            this.DVT.Name = "DVT";
            this.DVT.Width = 125;
            // 
            // SoLuongCon
            // 
            this.SoLuongCon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuongCon.DataPropertyName = "slcon";
            this.SoLuongCon.HeaderText = "Số lượng còn";
            this.SoLuongCon.MinimumWidth = 6;
            this.SoLuongCon.Name = "SoLuongCon";
            // 
            // lbThuoc
            // 
            this.lbThuoc.AutoSize = true;
            this.lbThuoc.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThuoc.Location = new System.Drawing.Point(208, 23);
            this.lbThuoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbThuoc.Name = "lbThuoc";
            this.lbThuoc.Size = new System.Drawing.Size(203, 35);
            this.lbThuoc.TabIndex = 13;
            this.lbThuoc.Text = "Thuốc - Vacxin";
            // 
            // cbDVT
            // 
            this.cbDVT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDVT.FormattingEnabled = true;
            this.cbDVT.Location = new System.Drawing.Point(182, 97);
            this.cbDVT.Margin = new System.Windows.Forms.Padding(2);
            this.cbDVT.Name = "cbDVT";
            this.cbDVT.Size = new System.Drawing.Size(272, 28);
            this.cbDVT.TabIndex = 6;
            // 
            // lbSoLuongCon
            // 
            this.lbSoLuongCon.AutoSize = true;
            this.lbSoLuongCon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuongCon.ForeColor = System.Drawing.Color.Black;
            this.lbSoLuongCon.Location = new System.Drawing.Point(63, 135);
            this.lbSoLuongCon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSoLuongCon.Name = "lbSoLuongCon";
            this.lbSoLuongCon.Size = new System.Drawing.Size(115, 21);
            this.lbSoLuongCon.TabIndex = 0;
            this.lbSoLuongCon.Text = "Số lượng còn:";
            // 
            // lbDVT
            // 
            this.lbDVT.AutoSize = true;
            this.lbDVT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDVT.ForeColor = System.Drawing.Color.Black;
            this.lbDVT.Location = new System.Drawing.Point(74, 97);
            this.lbDVT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDVT.Name = "lbDVT";
            this.lbDVT.Size = new System.Drawing.Size(99, 21);
            this.lbDVT.TabIndex = 0;
            this.lbDVT.Text = "Đơn vị tính:";
            // 
            // lbTenNcc
            // 
            this.lbTenNcc.AutoSize = true;
            this.lbTenNcc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNcc.ForeColor = System.Drawing.Color.Black;
            this.lbTenNcc.Location = new System.Drawing.Point(19, 63);
            this.lbTenNcc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenNcc.Name = "lbTenNcc";
            this.lbTenNcc.Size = new System.Drawing.Size(154, 21);
            this.lbTenNcc.TabIndex = 0;
            this.lbTenNcc.Text = "Tên thuốc - vacxin:";
            // 
            // lbMaThuoc
            // 
            this.lbMaThuoc.AutoSize = true;
            this.lbMaThuoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaThuoc.ForeColor = System.Drawing.Color.Black;
            this.lbMaThuoc.Location = new System.Drawing.Point(86, 27);
            this.lbMaThuoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaThuoc.Name = "lbMaThuoc";
            this.lbMaThuoc.Size = new System.Drawing.Size(85, 21);
            this.lbMaThuoc.TabIndex = 0;
            this.lbMaThuoc.Text = "Mã thuốc:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTenThuoc);
            this.groupBox1.Controls.Add(this.cbDVT);
            this.groupBox1.Controls.Add(this.lbMaThuoc);
            this.groupBox1.Controls.Add(this.lbTenNcc);
            this.groupBox1.Controls.Add(this.tbSoLuongCon);
            this.groupBox1.Controls.Add(this.lbDVT);
            this.groupBox1.Controls.Add(this.lbSoLuongCon);
            this.groupBox1.Controls.Add(this.tbMaThuoc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(51, 110);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(478, 164);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Thuốc-Vacxin";
            // 
            // tbTenThuoc
            // 
            this.tbTenThuoc.BackColor = System.Drawing.Color.White;
            this.tbTenThuoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTenThuoc.BackgroundImage")));
            this.tbTenThuoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTenThuoc.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenThuoc.ForeColor = System.Drawing.Color.Black;
            this.tbTenThuoc.Icon = ((System.Drawing.Image)(resources.GetObject("tbTenThuoc.Icon")));
            this.tbTenThuoc.Location = new System.Drawing.Point(182, 63);
            this.tbTenThuoc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbTenThuoc.Name = "tbTenThuoc";
            this.tbTenThuoc.Size = new System.Drawing.Size(272, 24);
            this.tbTenThuoc.TabIndex = 3;
            this.tbTenThuoc.text = "";
            // 
            // tbSoLuongCon
            // 
            this.tbSoLuongCon.BackColor = System.Drawing.Color.White;
            this.tbSoLuongCon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbSoLuongCon.BackgroundImage")));
            this.tbSoLuongCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbSoLuongCon.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoLuongCon.ForeColor = System.Drawing.Color.Black;
            this.tbSoLuongCon.Icon = ((System.Drawing.Image)(resources.GetObject("tbSoLuongCon.Icon")));
            this.tbSoLuongCon.Location = new System.Drawing.Point(182, 135);
            this.tbSoLuongCon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbSoLuongCon.Name = "tbSoLuongCon";
            this.tbSoLuongCon.Size = new System.Drawing.Size(272, 24);
            this.tbSoLuongCon.TabIndex = 5;
            this.tbSoLuongCon.text = "";
            // 
            // tbMaThuoc
            // 
            this.tbMaThuoc.BackColor = System.Drawing.Color.White;
            this.tbMaThuoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbMaThuoc.BackgroundImage")));
            this.tbMaThuoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbMaThuoc.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaThuoc.ForeColor = System.Drawing.Color.Black;
            this.tbMaThuoc.Icon = ((System.Drawing.Image)(resources.GetObject("tbMaThuoc.Icon")));
            this.tbMaThuoc.Location = new System.Drawing.Point(182, 24);
            this.tbMaThuoc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbMaThuoc.Name = "tbMaThuoc";
            this.tbMaThuoc.Size = new System.Drawing.Size(272, 24);
            this.tbMaThuoc.TabIndex = 2;
            this.tbMaThuoc.text = "";
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.BackColor = System.Drawing.Color.Teal;
            this.tbTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTimKiem.BackgroundImage")));
            this.tbTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTimKiem.ForeColor = System.Drawing.Color.Cyan;
            this.tbTimKiem.Icon = ((System.Drawing.Image)(resources.GetObject("tbTimKiem.Icon")));
            this.tbTimKiem.Location = new System.Drawing.Point(168, 77);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(309, 28);
            this.tbTimKiem.TabIndex = 14;
            this.tbTimKiem.text = "";
            this.tbTimKiem.OnTextChange += new System.EventHandler(this.tbTimKiem_OnTextChange);
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
            this.btnThem.Location = new System.Drawing.Point(39, 497);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 46);
            this.btnThem.TabIndex = 17;
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
            this.btnXoa.Location = new System.Drawing.Point(144, 499);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 46);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnSua.Location = new System.Drawing.Point(245, 499);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 46);
            this.btnSua.TabIndex = 16;
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnLuu.Location = new System.Drawing.Point(355, 499);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 44);
            this.btnLuu.TabIndex = 22;
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
            this.btnHuy.Location = new System.Drawing.Point(452, 499);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(89, 44);
            this.btnHuy.TabIndex = 32;
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmThuocVacXin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(571, 557);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvThuoc);
            this.Controls.Add(this.lbThuoc);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThuocVacXin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THUỐC - VACXIN";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBoSuaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvThuoc;
        private Bunifu.Framework.UI.BunifuCustomLabel lbThuoc;
        private System.Windows.Forms.ComboBox cbDVT;
        private Bunifu.Framework.UI.BunifuTextbox tbSoLuongCon;
        private Bunifu.Framework.UI.BunifuTextbox tbTenThuoc;
        private Bunifu.Framework.UI.BunifuTextbox tbMaThuoc;
        private Bunifu.Framework.UI.BunifuCustomLabel lbSoLuongCon;
        private Bunifu.Framework.UI.BunifuCustomLabel lbDVT;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTenNcc;
        private Bunifu.Framework.UI.BunifuCustomLabel lbMaThuoc;
        private Bunifu.Framework.UI.BunifuTextbox tbTimKiem;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThem;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXoa;
        private System.Windows.Forms.BindingSource quanLyBoSuaDataSetBindingSource;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongCon;
        private Bunifu.Framework.UI.BunifuThinButton2 btnHuy;
    }
}