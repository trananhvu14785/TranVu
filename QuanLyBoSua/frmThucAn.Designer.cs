namespace QuanLyBoSua
{
    partial class frmThucAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThucAn));
            this.lbThucAn = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvThucAn = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.mathucan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenthucan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTenThucAn = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbMaThucAn = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMaThucAn = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbTenThucAn = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbTimKiem = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnThem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnXoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSua = new Bunifu.Framework.UI.BunifuThinButton2();
            this.quanLyBoSuaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLuu = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnHuy = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucAn)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBoSuaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbThucAn
            // 
            this.lbThucAn.AutoSize = true;
            this.lbThucAn.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold);
            this.lbThucAn.Location = new System.Drawing.Point(194, 18);
            this.lbThucAn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbThucAn.Name = "lbThucAn";
            this.lbThucAn.Size = new System.Drawing.Size(127, 35);
            this.lbThucAn.TabIndex = 21;
            this.lbThucAn.Text = "Thức Ăn";
            // 
            // dgvThucAn
            // 
            this.dgvThucAn.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvThucAn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThucAn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvThucAn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThucAn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThucAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThucAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mathucan,
            this.tenthucan});
            this.dgvThucAn.DoubleBuffered = true;
            this.dgvThucAn.EnableHeadersVisualStyles = false;
            this.dgvThucAn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvThucAn.HeaderBgColor = System.Drawing.Color.Cyan;
            this.dgvThucAn.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvThucAn.Location = new System.Drawing.Point(71, 237);
            this.dgvThucAn.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThucAn.Name = "dgvThucAn";
            this.dgvThucAn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThucAn.RowHeadersWidth = 51;
            this.dgvThucAn.RowTemplate.Height = 24;
            this.dgvThucAn.Size = new System.Drawing.Size(363, 180);
            this.dgvThucAn.TabIndex = 28;
            this.dgvThucAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThucAn_CellClick);
            // 
            // mathucan
            // 
            this.mathucan.DataPropertyName = "mathucan";
            this.mathucan.HeaderText = "Mã thức ăn";
            this.mathucan.MinimumWidth = 6;
            this.mathucan.Name = "mathucan";
            this.mathucan.Width = 125;
            // 
            // tenthucan
            // 
            this.tenthucan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenthucan.DataPropertyName = "tenthucan";
            this.tenthucan.HeaderText = "Tên thức ăn";
            this.tenthucan.MinimumWidth = 6;
            this.tenthucan.Name = "tenthucan";
            // 
            // lbTenThucAn
            // 
            this.lbTenThucAn.AutoSize = true;
            this.lbTenThucAn.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.lbTenThucAn.ForeColor = System.Drawing.Color.Black;
            this.lbTenThucAn.Location = new System.Drawing.Point(48, 68);
            this.lbTenThucAn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenThucAn.Name = "lbTenThucAn";
            this.lbTenThucAn.Size = new System.Drawing.Size(103, 21);
            this.lbTenThucAn.TabIndex = 0;
            this.lbTenThucAn.Text = "Tên thức ăn:";
            // 
            // lbMaThucAn
            // 
            this.lbMaThucAn.AutoSize = true;
            this.lbMaThucAn.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.lbMaThucAn.ForeColor = System.Drawing.Color.Black;
            this.lbMaThucAn.Location = new System.Drawing.Point(50, 36);
            this.lbMaThucAn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaThucAn.Name = "lbMaThucAn";
            this.lbMaThucAn.Size = new System.Drawing.Size(98, 21);
            this.lbMaThucAn.TabIndex = 0;
            this.lbMaThucAn.Text = "Mã thức ăn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMaThucAn);
            this.groupBox1.Controls.Add(this.tbTenThucAn);
            this.groupBox1.Controls.Add(this.lbMaThucAn);
            this.groupBox1.Controls.Add(this.lbTenThucAn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 118);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(471, 104);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thức ăn";
            // 
            // tbMaThucAn
            // 
            this.tbMaThucAn.BackColor = System.Drawing.Color.White;
            this.tbMaThucAn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbMaThucAn.BackgroundImage")));
            this.tbMaThucAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbMaThucAn.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaThucAn.ForeColor = System.Drawing.Color.Black;
            this.tbMaThucAn.Icon = ((System.Drawing.Image)(resources.GetObject("tbMaThucAn.Icon")));
            this.tbMaThucAn.Location = new System.Drawing.Point(153, 33);
            this.tbMaThucAn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbMaThucAn.Name = "tbMaThucAn";
            this.tbMaThucAn.Size = new System.Drawing.Size(272, 24);
            this.tbMaThucAn.TabIndex = 2;
            this.tbMaThucAn.text = "";
            // 
            // tbTenThucAn
            // 
            this.tbTenThucAn.BackColor = System.Drawing.Color.White;
            this.tbTenThucAn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTenThucAn.BackgroundImage")));
            this.tbTenThucAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTenThucAn.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenThucAn.ForeColor = System.Drawing.Color.Black;
            this.tbTenThucAn.Icon = ((System.Drawing.Image)(resources.GetObject("tbTenThucAn.Icon")));
            this.tbTenThucAn.Location = new System.Drawing.Point(153, 65);
            this.tbTenThucAn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbTenThucAn.Name = "tbTenThucAn";
            this.tbTenThucAn.Size = new System.Drawing.Size(272, 24);
            this.tbTenThucAn.TabIndex = 3;
            this.tbTenThucAn.text = "";
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.BackColor = System.Drawing.Color.Teal;
            this.tbTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTimKiem.BackgroundImage")));
            this.tbTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTimKiem.ForeColor = System.Drawing.Color.Cyan;
            this.tbTimKiem.Icon = ((System.Drawing.Image)(resources.GetObject("tbTimKiem.Icon")));
            this.tbTimKiem.Location = new System.Drawing.Point(127, 76);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(264, 37);
            this.tbTimKiem.TabIndex = 22;
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
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnThem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.IdleBorderThickness = 1;
            this.btnThem.IdleCornerRadius = 20;
            this.btnThem.IdleFillColor = System.Drawing.Color.Cyan;
            this.btnThem.IdleForecolor = System.Drawing.Color.Black;
            this.btnThem.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.Location = new System.Drawing.Point(8, 419);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 46);
            this.btnThem.TabIndex = 25;
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
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnXoa.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.IdleBorderThickness = 1;
            this.btnXoa.IdleCornerRadius = 20;
            this.btnXoa.IdleFillColor = System.Drawing.Color.Cyan;
            this.btnXoa.IdleForecolor = System.Drawing.Color.Black;
            this.btnXoa.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.Location = new System.Drawing.Point(102, 420);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 46);
            this.btnXoa.TabIndex = 26;
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
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnSua.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.IdleBorderThickness = 1;
            this.btnSua.IdleCornerRadius = 20;
            this.btnSua.IdleFillColor = System.Drawing.Color.Cyan;
            this.btnSua.IdleForecolor = System.Drawing.Color.Black;
            this.btnSua.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.Location = new System.Drawing.Point(200, 420);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 46);
            this.btnSua.TabIndex = 24;
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
            this.btnLuu.Location = new System.Drawing.Point(302, 423);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 44);
            this.btnLuu.TabIndex = 30;
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
            this.btnHuy.Location = new System.Drawing.Point(398, 423);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(89, 44);
            this.btnHuy.TabIndex = 32;
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmThucAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(491, 479);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbThucAn);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvThucAn);
            this.Controls.Add(this.btnSua);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThucAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thức Ăn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucAn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBoSuaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTextbox tbTenThucAn;
        private Bunifu.Framework.UI.BunifuTextbox tbMaThucAn;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTenThucAn;
        private Bunifu.Framework.UI.BunifuCustomLabel lbMaThucAn;
        private Bunifu.Framework.UI.BunifuCustomLabel lbThucAn;
        private Bunifu.Framework.UI.BunifuTextbox tbTimKiem;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThem;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXoa;
        private System.Windows.Forms.BindingSource quanLyBoSuaDataSetBindingSource;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvThucAn;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathucan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthucan;
        private Bunifu.Framework.UI.BunifuThinButton2 btnHuy;
    }
}