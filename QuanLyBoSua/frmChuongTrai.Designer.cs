namespace QuanLyBoSua
{
    partial class frmChuongTrai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChuongTrai));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMaNv = new Bunifu.Framework.UI.BunifuTextbox();
            this.lbTenKH = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbTongCho = new Bunifu.Framework.UI.BunifuTextbox();
            this.lbEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbTenChuong = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvChuongTrai = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnLuu = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnThem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSua = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnXoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tbTimKiem = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnHuy = new Bunifu.Framework.UI.BunifuThinButton2();
            this.machuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenchuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongsocho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sochocontrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txmachuong = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuongTrai)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMaNv);
            this.groupBox1.Controls.Add(this.lbTenKH);
            this.groupBox1.Controls.Add(this.tbTongCho);
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Controls.Add(this.tbTenChuong);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(499, 153);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chuồng trại";
            // 
            // tbMaNv
            // 
            this.tbMaNv.BackColor = System.Drawing.Color.White;
            this.tbMaNv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbMaNv.BackgroundImage")));
            this.tbMaNv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbMaNv.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaNv.ForeColor = System.Drawing.Color.Black;
            this.tbMaNv.Icon = ((System.Drawing.Image)(resources.GetObject("tbMaNv.Icon")));
            this.tbMaNv.Location = new System.Drawing.Point(178, 112);
            this.tbMaNv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbMaNv.Name = "tbMaNv";
            this.tbMaNv.Size = new System.Drawing.Size(272, 24);
            this.tbMaNv.TabIndex = 5;
            this.tbMaNv.text = "";
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKH.ForeColor = System.Drawing.Color.Black;
            this.lbTenKH.Location = new System.Drawing.Point(58, 34);
            this.lbTenKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(103, 21);
            this.lbTenKH.TabIndex = 0;
            this.lbTenKH.Text = "Tên chuồng:";
            // 
            // tbTongCho
            // 
            this.tbTongCho.BackColor = System.Drawing.Color.White;
            this.tbTongCho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTongCho.BackgroundImage")));
            this.tbTongCho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTongCho.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTongCho.ForeColor = System.Drawing.Color.Black;
            this.tbTongCho.Icon = ((System.Drawing.Image)(resources.GetObject("tbTongCho.Icon")));
            this.tbTongCho.Location = new System.Drawing.Point(178, 71);
            this.tbTongCho.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbTongCho.Name = "tbTongCho";
            this.tbTongCho.Size = new System.Drawing.Size(272, 24);
            this.tbTongCho.TabIndex = 4;
            this.tbTongCho.text = "";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.Black;
            this.lbEmail.Location = new System.Drawing.Point(55, 71);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(110, 21);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Tổng số chỗ:";
            // 
            // tbTenChuong
            // 
            this.tbTenChuong.BackColor = System.Drawing.Color.White;
            this.tbTenChuong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTenChuong.BackgroundImage")));
            this.tbTenChuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTenChuong.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenChuong.ForeColor = System.Drawing.Color.Black;
            this.tbTenChuong.Icon = ((System.Drawing.Image)(resources.GetObject("tbTenChuong.Icon")));
            this.tbTenChuong.Location = new System.Drawing.Point(178, 34);
            this.tbTenChuong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbTenChuong.Name = "tbTenChuong";
            this.tbTenChuong.Size = new System.Drawing.Size(272, 24);
            this.tbTenChuong.TabIndex = 3;
            this.tbTenChuong.text = "";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(44, 112);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(113, 21);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "Mã nhân viên:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(200, 9);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(167, 35);
            this.bunifuCustomLabel1.TabIndex = 22;
            this.bunifuCustomLabel1.Text = "Chuồng trại";
            // 
            // dgvChuongTrai
            // 
            this.dgvChuongTrai.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvChuongTrai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChuongTrai.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvChuongTrai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChuongTrai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChuongTrai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChuongTrai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuongTrai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.machuong,
            this.tenchuong,
            this.tongsocho,
            this.sochocontrong});
            this.dgvChuongTrai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvChuongTrai.DoubleBuffered = true;
            this.dgvChuongTrai.EnableHeadersVisualStyles = false;
            this.dgvChuongTrai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvChuongTrai.HeaderBgColor = System.Drawing.Color.Cyan;
            this.dgvChuongTrai.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvChuongTrai.Location = new System.Drawing.Point(14, 275);
            this.dgvChuongTrai.Name = "dgvChuongTrai";
            this.dgvChuongTrai.ReadOnly = true;
            this.dgvChuongTrai.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvChuongTrai.RowHeadersWidth = 51;
            this.dgvChuongTrai.RowTemplate.Height = 24;
            this.dgvChuongTrai.Size = new System.Drawing.Size(553, 219);
            this.dgvChuongTrai.TabIndex = 28;
            this.dgvChuongTrai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuongTrai_CellClick);
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
            this.btnLuu.Location = new System.Drawing.Point(349, 503);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 44);
            this.btnLuu.TabIndex = 30;
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            this.btnThem.Location = new System.Drawing.Point(26, 503);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 46);
            this.btnThem.TabIndex = 24;
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
            this.btnSua.Location = new System.Drawing.Point(241, 503);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 46);
            this.btnSua.TabIndex = 25;
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
            this.btnXoa.Location = new System.Drawing.Point(133, 503);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 46);
            this.btnXoa.TabIndex = 26;
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
            this.tbTimKiem.Location = new System.Drawing.Point(155, 72);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(309, 28);
            this.tbTimKiem.TabIndex = 23;
            this.tbTimKiem.text = "";
            this.tbTimKiem.OnTextChange += new System.EventHandler(this.tbTimKiem_OnTextChange);
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
            this.btnHuy.Location = new System.Drawing.Point(454, 502);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(89, 44);
            this.btnHuy.TabIndex = 31;
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // machuong
            // 
            this.machuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.machuong.DataPropertyName = "machuong";
            this.machuong.HeaderText = "Mã chuồng";
            this.machuong.MinimumWidth = 6;
            this.machuong.Name = "machuong";
            this.machuong.ReadOnly = true;
            // 
            // tenchuong
            // 
            this.tenchuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenchuong.DataPropertyName = "tenchuong";
            this.tenchuong.HeaderText = "Tên chuồng";
            this.tenchuong.MinimumWidth = 6;
            this.tenchuong.Name = "tenchuong";
            this.tenchuong.ReadOnly = true;
            // 
            // tongsocho
            // 
            this.tongsocho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tongsocho.DataPropertyName = "tongsocho";
            this.tongsocho.HeaderText = "Tổng số chỗ";
            this.tongsocho.MinimumWidth = 6;
            this.tongsocho.Name = "tongsocho";
            this.tongsocho.ReadOnly = true;
            // 
            // sochocontrong
            // 
            this.sochocontrong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sochocontrong.DataPropertyName = "sochocontrong";
            this.sochocontrong.HeaderText = "Chỗ còn trống";
            this.sochocontrong.MinimumWidth = 6;
            this.sochocontrong.Name = "sochocontrong";
            this.sochocontrong.ReadOnly = true;
            // 
            // txmachuong
            // 
            this.txmachuong.Location = new System.Drawing.Point(1, 221);
            this.txmachuong.Name = "txmachuong";
            this.txmachuong.Size = new System.Drawing.Size(38, 20);
            this.txmachuong.TabIndex = 32;
            this.txmachuong.Visible = false;
            // 
            // frmChuongTrai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(597, 558);
            this.Controls.Add(this.txmachuong);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dgvChuongTrai);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChuongTrai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuồng Trại";
            this.Load += new System.EventHandler(this.frmChuongTrai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuongTrai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnThem;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSua;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXoa;
        private Bunifu.Framework.UI.BunifuTextbox tbTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTenKH;
        private Bunifu.Framework.UI.BunifuTextbox tbTongCho;
        private Bunifu.Framework.UI.BunifuCustomLabel lbEmail;
        private Bunifu.Framework.UI.BunifuTextbox tbTenChuong;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvChuongTrai;
        private Bunifu.Framework.UI.BunifuTextbox tbMaNv;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLuu;
        private Bunifu.Framework.UI.BunifuThinButton2 btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn machuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenchuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongsocho;
        private System.Windows.Forms.DataGridViewTextBoxColumn sochocontrong;
        private System.Windows.Forms.TextBox txmachuong;
    }
}