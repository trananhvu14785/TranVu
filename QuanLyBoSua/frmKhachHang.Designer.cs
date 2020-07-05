namespace QuanLyBoSua
{
    partial class frmKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.dgvKhachHang = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.maKh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbSdt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbTenKH = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSdt = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbEmail = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbTenKH = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnThem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSua = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnXoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tbTimKiem = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnLuu = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnHuy = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbMaKH = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbMaKH = new Bunifu.Framework.UI.BunifuTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKh,
            this.tenKh,
            this.email,
            this.sdt});
            this.dgvKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvKhachHang.DoubleBuffered = true;
            this.dgvKhachHang.EnableHeadersVisualStyles = false;
            this.dgvKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvKhachHang.HeaderBgColor = System.Drawing.Color.Cyan;
            this.dgvKhachHang.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvKhachHang.Location = new System.Drawing.Point(12, 287);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(556, 190);
            this.dgvKhachHang.TabIndex = 20;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // maKh
            // 
            this.maKh.DataPropertyName = "makh";
            this.maKh.HeaderText = "Mã Khách hàng";
            this.maKh.MinimumWidth = 6;
            this.maKh.Name = "maKh";
            this.maKh.Width = 125;
            // 
            // tenKh
            // 
            this.tenKh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenKh.DataPropertyName = "tenkh";
            this.tenKh.HeaderText = "Tên khách hàng";
            this.tenKh.MinimumWidth = 6;
            this.tenKh.Name = "tenKh";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sodt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.Width = 125;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(160, 7);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(176, 35);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "Khách Hàng";
            // 
            // lbSdt
            // 
            this.lbSdt.AutoSize = true;
            this.lbSdt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSdt.ForeColor = System.Drawing.Color.Black;
            this.lbSdt.Location = new System.Drawing.Point(61, 133);
            this.lbSdt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(112, 21);
            this.lbSdt.TabIndex = 0;
            this.lbSdt.Text = "Số điện thoại:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.Black;
            this.lbEmail.Location = new System.Drawing.Point(112, 102);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(55, 21);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email:";
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKH.ForeColor = System.Drawing.Color.Black;
            this.lbTenKH.Location = new System.Drawing.Point(40, 65);
            this.lbTenKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(132, 21);
            this.lbTenKH.TabIndex = 0;
            this.lbTenKH.Text = "Tên khách hàng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMaKH);
            this.groupBox1.Controls.Add(this.tbSdt);
            this.groupBox1.Controls.Add(this.lbMaKH);
            this.groupBox1.Controls.Add(this.lbTenKH);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Controls.Add(this.tbTenKH);
            this.groupBox1.Controls.Add(this.lbSdt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(467, 166);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // tbSdt
            // 
            this.tbSdt.BackColor = System.Drawing.Color.White;
            this.tbSdt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbSdt.BackgroundImage")));
            this.tbSdt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbSdt.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSdt.ForeColor = System.Drawing.Color.Black;
            this.tbSdt.Icon = ((System.Drawing.Image)(resources.GetObject("tbSdt.Icon")));
            this.tbSdt.Location = new System.Drawing.Point(178, 133);
            this.tbSdt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Size = new System.Drawing.Size(272, 24);
            this.tbSdt.TabIndex = 5;
            this.tbSdt.text = "";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.White;
            this.tbEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbEmail.BackgroundImage")));
            this.tbEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbEmail.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.Black;
            this.tbEmail.Icon = ((System.Drawing.Image)(resources.GetObject("tbEmail.Icon")));
            this.tbEmail.Location = new System.Drawing.Point(178, 102);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(272, 24);
            this.tbEmail.TabIndex = 4;
            this.tbEmail.text = "";
            // 
            // tbTenKH
            // 
            this.tbTenKH.BackColor = System.Drawing.Color.White;
            this.tbTenKH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTenKH.BackgroundImage")));
            this.tbTenKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTenKH.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenKH.ForeColor = System.Drawing.Color.Black;
            this.tbTenKH.Icon = ((System.Drawing.Image)(resources.GetObject("tbTenKH.Icon")));
            this.tbTenKH.Location = new System.Drawing.Point(178, 65);
            this.tbTenKH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(272, 24);
            this.tbTenKH.TabIndex = 3;
            this.tbTenKH.text = "";
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
            this.btnThem.Location = new System.Drawing.Point(48, 484);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 46);
            this.btnThem.TabIndex = 16;
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnSua.Location = new System.Drawing.Point(265, 484);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 46);
            this.btnSua.TabIndex = 17;
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(158, 484);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 46);
            this.btnXoa.TabIndex = 18;
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
            this.tbTimKiem.Location = new System.Drawing.Point(143, 71);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(309, 28);
            this.tbTimKiem.TabIndex = 14;
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
            this.btnLuu.Location = new System.Drawing.Point(373, 484);
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
            this.btnHuy.Location = new System.Drawing.Point(469, 484);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(89, 44);
            this.btnHuy.TabIndex = 32;
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKH.ForeColor = System.Drawing.Color.Black;
            this.lbMaKH.Location = new System.Drawing.Point(44, 24);
            this.lbMaKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(127, 21);
            this.lbMaKH.TabIndex = 0;
            this.lbMaKH.Text = "Mã khách hàng:";
            // 
            // tbMaKH
            // 
            this.tbMaKH.BackColor = System.Drawing.Color.White;
            this.tbMaKH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbMaKH.BackgroundImage")));
            this.tbMaKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbMaKH.Enabled = false;
            this.tbMaKH.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaKH.ForeColor = System.Drawing.Color.Black;
            this.tbMaKH.Icon = ((System.Drawing.Image)(resources.GetObject("tbMaKH.Icon")));
            this.tbMaKH.Location = new System.Drawing.Point(178, 24);
            this.tbMaKH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(272, 24);
            this.tbMaKH.TabIndex = 2;
            this.tbMaKH.text = "";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(577, 533);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.tbTimKiem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHÁCH HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvKhachHang;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuTextbox tbSdt;
        private Bunifu.Framework.UI.BunifuTextbox tbEmail;
        private Bunifu.Framework.UI.BunifuTextbox tbTenKH;
        private Bunifu.Framework.UI.BunifuCustomLabel lbSdt;
        private Bunifu.Framework.UI.BunifuCustomLabel lbEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTenKH;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThem;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSua;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXoa;
        private Bunifu.Framework.UI.BunifuTextbox tbTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKh;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private Bunifu.Framework.UI.BunifuThinButton2 btnHuy;
        private Bunifu.Framework.UI.BunifuTextbox tbMaKH;
        private Bunifu.Framework.UI.BunifuCustomLabel lbMaKH;
    }
}