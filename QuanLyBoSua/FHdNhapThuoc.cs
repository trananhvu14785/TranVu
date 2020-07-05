using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QuanLyBoSua
{
    public partial class FHdNhapThuoc : Form
    {
        private string maNv;
        public FHdNhapThuoc(string maNv = null)
        {
            this.maNv = maNv;
            InitializeComponent();
            Bunifu.Framework.UI.BunifuDragControl a = new Bunifu.Framework.UI.BunifuDragControl();
            a.TargetControl = this.panel1;
            a.Vertical = true;
            loadNhaCungCap();
            loadNhanVien();
            LoadHoaDon();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void loadNhaCungCap()
        {
            try
            {
                string query = "select * from nhaCungCap";
                DataTable Data = KetNoi.Istance.ExcuteQuerry(query);
                cbNcc.DataSource = Data;
                cbNcc.DisplayMember = "tenNCC";
                cbNcc.ValueMember = "maNCC";
                cbNcc.Text = "";
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        void loadNhanVien()
        {
            try
            {
                string query = "select * from NhanVien";
                DataTable Data = KetNoi.Istance.ExcuteQuerry(query);
                cbMaNv.DataSource = Data;
                cbMaNv.DisplayMember = "maNv";
                cbMaNv.ValueMember = "maNv";
                cbMaNv.Text = "";
                if (MaNv != "")
                {
                    cbMaNv.Text = MaNv;
                    cbMaNv.Enabled = false;
                }
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        void LoadHoaDon()
        {
            try
            {
                string query = "select H.maHD,N.tenNCC,H.maNv,convert(nvarchar(30), H.ngayLap, 20)as ngayLap,H.tongTien from HoaDonNhapThuoc H,NhaCungCap N where H.maNCC=N.maNCC";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvHD.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        void getMaHd()
        {
            try
            {
                string query = "Select * from HoaDonNhapThuoc";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                cbmaHD.DataSource = data;
                cbmaHD.DisplayMember = "maHd";
                cbmaHD.ValueMember = "maHd";
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        void update()
        {
            panelInforHD.Enabled = false;
            dtpkNgayLap.Enabled = false;


            dem = 0;
            bien = 0;
            txTongTien.ResetText();
            dtgvHD.ClearSelection();
            dtgvCTHD.ClearSelection();



            txGiaNhap.ResetText();
            txTongTien.Text = "0";

            numericUpDown1.Value = 0;
            txGiaNhap.ResetText();
            panelCTHD.Enabled = false;
        }
        int dem = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
        }
        private int rowIndex;
        private void dtgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                lbMaHd.Text = dtgvHD.Rows[numrow].Cells[0].Value.ToString();
                rowIndex = numrow;
                lbMaHd.Visible = true;
                label13.Visible = true;
                cbNcc.Text = dtgvHD.Rows[numrow].Cells[1].Value.ToString();
                cbMaNv.Text = dtgvHD.Rows[numrow].Cells[2].Value.ToString();
                DateTime dt = Convert.ToDateTime(dtgvHD.Rows[numrow].Cells[3].Value.ToString());
                dtpkNgayLap.Value = dt;
                txTongTien.Text = dtgvHD.Rows[numrow].Cells[4].Value.ToString();
                getMaHd();
                cbmaHD.Text = lbMaHd.Text;
                LoadCTHD(lbMaHd.Text);
                LoadThuoc();
                LoadDVT();

            }
        }
        void LoadCTHD(string maHd)
        {
            try
            {
                string query = "Select T.TenThuoc,C.slNhap,C.donViTinh,C.donGiaNhap from HoaDonNhapThuoc H,CTHDNhapThuoc C,ThuocVacXin T where H.maHd=C.maHd and C.maThuoc=T.MaThuoc and H.maHd='" + maHd + "'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvCTHD.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        void LoadThuoc()
        {
            try
            {
                string querry = "Select * from ThuocVacXin";
                DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                cbTenThuoc.DataSource = data;
                cbTenThuoc.DisplayMember = "tenThuoc";
                cbTenThuoc.ValueMember = "maThuoc";
            } catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        void LoadDVT()
        {
            try
            {
                string[] DVT = { "Hộp", "Vỉ", "Chai", "Thùng", "Ống" };
                cbDonViTinh.DataSource = DVT;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }
        private int bien = 0;

        public string MaNv { get => maNv; set => maNv = value; }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
           

        }
        void loadUpdate()
        {
            int numrow = rowIndex;
            txTongTien.Text = dtgvHD.Rows[numrow].Cells[4].Value.ToString();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
           
        }

        private void dtgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                cbTenThuoc.Text = dtgvCTHD.Rows[numrow].Cells[0].Value.ToString();
                numericUpDown1.Value = decimal.Parse(dtgvCTHD.Rows[numrow].Cells[1].Value.ToString());
                cbDonViTinh.Text = dtgvCTHD.Rows[numrow].Cells[2].Value.ToString();
                txGiaNhap.Text = dtgvCTHD.Rows[numrow].Cells[3].Value.ToString();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
          

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            
        }
        void exFile(DataGridView data)
        {
            bool fileError = true;
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XLSX(*.xlsx)|*.xlsx";
                saveFileDialog.FileName = "HoaDonNhapThuoc.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileError = false;
                    if (File.Exists(saveFileDialog.FileName))
                    {
                        try
                        {
                            fileError = false;
                            File.Delete(saveFileDialog.FileName);
                        }
                        catch
                        {
                            fileError = true;
                        }
                    }
                }
                if (!fileError)
                {
                    app obj = new app();
                    obj.Application.Workbooks.Add(Type.Missing);
                    obj.Columns.ColumnWidth = 25;
                    obj.StandardFontSize = 13;
                    obj.Cells[1].Font.Bold = true;
                    obj.Rows[2].Font.Bold = true;

                    obj.Rows[1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    obj.Rows[2].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    obj.Rows[3].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    obj.Rows[4].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    obj.Rows[3].Font.Bold = true;
                    obj.Rows[4].Font.Bold = true;
                    int dem = 4;
                    obj.Cells[1, 1] = "         Hóa Đơn Nhập Thuốc     ";
                    obj.Cells[2, 1] = "Mã Hóa Đơn: " + lbMaHd.Text;
                    obj.Cells[2, 2] = "Ngày Lập: " + dtpkNgayLap.Value.ToString();
                    obj.Cells[3, 1] = "Mã Nhân Viên: " + cbMaNv.Text;

                    if (dtgvCTHD.RowCount > 0)
                    {

                        for (int i = 1; i < data.Columns.Count + 1; i++)
                        {

                            obj.Cells[4, i] = data.Columns[i - 1].HeaderText;
                        }
                        for (int i = 0; i < data.Rows.Count; i++)
                        {
                            dem += 1;
                            obj.Rows[dem].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            for (int j = 0; j < data.Columns.Count; j++)
                            {
                                if (data.Rows[i].Cells[j].Value != null)
                                {
                                    obj.Cells[i + 5, j + 1] = data.Rows[i].Cells[j].Value.ToString();
                                }
                                else
                                {
                                    obj.Cells[i + 5, j + 1] = "";
                                }
                            }
                        }
                    }

                    obj.Cells[dem + 1, 1] = "Tổng Tiền " + txTongTien.Text;
                    obj.Rows[dem + 1].Font.Color = Color.Red;
                    obj.Rows[dem + 1].Font.Bold = true;
                    obj.Rows[dem + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    obj.ActiveWorkbook.SaveCopyAs(saveFileDialog.FileName);
                    obj.ActiveWorkbook.Saved = true;
                    Alert a = new Alert("In thành công", AlertType.success);
                    a.ShowDialog();
                }
            }
            catch {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
           
        }

        private void txTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "select H.maHD,N.tenNCC,H.maNv,convert(nvarchar(30), H.ngayLap, 20)as ngayLap,H.tongTien from HoaDonNhapThuoc H,NhaCungCap N where H.maNCC=N.maNCC and maHd like N'%" + txTimKiem.Text + "%'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvHD.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void txGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            dem = 1;
            panelInforHD.Enabled = true;
            txTongTien.Text = "0";
            lbMaHd.Text = "0";
            lbMaHd.Visible = false;
            label13.Visible = false;
            cbmaHD.DataSource = null;
            if (dtgvCTHD.RowCount > 0)
                ((DataTable)dtgvCTHD.DataSource).Rows.Clear();
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            if (MaNv != "")
            {
                cbMaNv.Text = MaNv;
                cbMaNv.Enabled = false;
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (lbMaHd.Text == "0")
            {
                Alert a = new Alert("Vui Lòng chọn hóa đơn cần sửa.", AlertType.error);

                a.ShowDialog();
                dem = 0;
                panelInforHD.Enabled = false;
            }
            else
            {
                dem = 2;
                panelInforHD.Enabled = true;
                dtpkNgayLap.Enabled = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (lbMaHd.Text == "0")
                {
                    Alert a = new Alert("Vui Lòng chọn hóa đơn cần Xóa.", AlertType.error);

                    a.ShowDialog();

                }
                else
                {
                    string query = "Delete HoaDonNhapThuoc where maHd='" + lbMaHd.Text + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                    Alert a = new Alert("Xóa thành công.", AlertType.success);

                    a.ShowDialog();
                    LoadHoaDon();

                    panelInforHD.Enabled = false;
                    dtpkNgayLap.Enabled = false;
                    label13.Visible = false;
                    lbMaHd.Text = "0";
                    lbMaHd.Visible = false;
                    dem = 0;
                    if (dtgvCTHD.RowCount > 0)
                        ((DataTable)dtgvCTHD.DataSource).Rows.Clear();
                    cbmaHD.DataSource = null;
                    update();
                }
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dem == 1)
                {
                    string querry = "Insert into HoaDonNhapThuoc(maNcc,maNv,ngayLap,TongTien) Values('" + cbNcc.SelectedValue + "','" + cbMaNv.SelectedValue + "',convert(nvarchar(30), getDate(), 20),'0')";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                    Alert a = new Alert("Thêm thành công.", AlertType.success);
                    a.ShowDialog();
                    LoadHoaDon();
                    panelInforHD.Enabled = false;
                    update();
                    lbMaHd.Text = "0";
                    lbMaHd.Visible = false;
                    label13.Visible = false;
                    if (dtgvCTHD.RowCount > 0)
                        ((DataTable)dtgvCTHD.DataSource).Rows.Clear();
                    cbmaHD.DataSource = null;
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;

                }
                else if (dem == 2)
                {
                    string query = "update HoaDonNhapThuoc set maNCC='" + cbNcc.SelectedValue + "',maNv='" + cbMaNv.SelectedValue + "',ngayLap=N'" + dtpkNgayLap.Value + "' where maHd='" + lbMaHd.Text + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                    Alert a = new Alert("Sửa thành công.", AlertType.success);
                    a.ShowDialog();
                    LoadHoaDon();
                    panelInforHD.Enabled = false;
                    dtpkNgayLap.Enabled = false;
                    label13.Visible = false;
                    lbMaHd.Text = "0";
                    txTongTien.ResetText();
                    lbMaHd.Visible = false;
                    dem = 0;
                    if (dtgvCTHD.RowCount > 0)
                        ((DataTable)dtgvCTHD.DataSource).Rows.Clear();
                    cbmaHD.DataSource = null;
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                }
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            update();
            lbMaHd.Text = "0";
            lbMaHd.Visible = false;
            label13.Visible = false;
            if (dtgvCTHD.RowCount > 0)
                ((DataTable)dtgvCTHD.DataSource).Rows.Clear();
            cbmaHD.DataSource = null;
            dtgvHD.ClearSelection();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (lbMaHd.Text == "0")
            {
                Alert a = new Alert("Vui Lòng Chọn Hóa Đơn", AlertType.error);
                a.ShowDialog();
            }
            else
            {
                exFile(dtgvCTHD);
            }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            if (lbMaHd.Text == "0")
            {
                Alert a = new Alert("Hãy chọn hóa đơn cần thêm", AlertType.error);
                a.ShowDialog();
            }
            else
            {
                bien = 1;
                txGiaNhap.ResetText();
                numericUpDown1.Value = 0;
                panelCTHD.Enabled = true;
                btnThemCT.Enabled = false;
                btnSuaCT.Enabled = false;
                btnXoaCT.Enabled = false;
            }
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            if (txGiaNhap.Text == "")
            {
                Alert a = new Alert("Hãy Chọn Chi tiết hóa đơn cần sửa", AlertType.error);
                a.ShowDialog();
            }
            else
            {
                bien = 2;
                panelCTHD.Enabled = true;
                btnThemCT.Enabled = false;
                btnSuaCT.Enabled = false;
                btnXoaCT.Enabled = false;
            }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            try
            {
                if (txGiaNhap.Text == "")
                {
                    Alert a = new Alert("Hãy Chọn Chi tiết hóa đơn cần Xóa", AlertType.error);
                    a.ShowDialog();
                }
                else
                {
                    string querry = "Delete CTHDNhapThuoc where maHd='" + cbmaHD.Text + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                    Alert a = new Alert("Xóa Thành Công", AlertType.success);
                    a.ShowDialog();
                    update();
                    LoadCTHD(cbmaHD.SelectedValue.ToString());
                    LoadHoaDon();
                    loadUpdate();
                }
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (bien == 1)
                {
                    if (numericUpDown1.Value == 0 || txGiaNhap.Text == "")
                    {
                        Alert a = new Alert("Bạn hãy nhập đủ thông tin", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {
                        string querry = "insert into CTHDNhapThuoc values('" + cbmaHD.SelectedValue + "','" + cbTenThuoc.SelectedValue + "',N'" + cbDonViTinh.Text + "','" + numericUpDown1.Value + "','" + txGiaNhap.Text + "')";
                        DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                        Alert a = new Alert("Thêm thành công", AlertType.success);
                        a.ShowDialog();
                        LoadCTHD(cbmaHD.SelectedValue.ToString());
                        LoadHoaDon();
                        update();
                        loadUpdate();
                        btnThemCT.Enabled = true;
                        btnSuaCT.Enabled = true;
                        btnXoaCT.Enabled = true;
                    }
                }
                if (bien == 2)
                {

                    if (numericUpDown1.Value == 0 || txGiaNhap.Text == "")
                    {
                        Alert a = new Alert("Bạn hãy nhập đủ thông tin", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {
                        string querry = "Update CTHDNhapThuoc set maThuoc='" + cbTenThuoc.SelectedValue + "',slNhap='" + numericUpDown1.Value + "',donViTinh=N'" + cbDonViTinh.Text + "',donGiaNhap='" + txGiaNhap.Text + "' where maHd='" + cbmaHD.Text + "'";
                        DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                        Alert a = new Alert("Sửa thành công", AlertType.error);
                        a.ShowDialog();
                        LoadCTHD(cbmaHD.Text);
                        LoadHoaDon();
                        update();
                        loadUpdate();
                        btnThemCT.Enabled = true;
                        btnSuaCT.Enabled = true;
                        btnXoaCT.Enabled = true;
                    }
                }
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối", AlertType.error);
                a.ShowDialog();
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            txGiaNhap.ResetText();
            numericUpDown1.Value = 0;
            panelCTHD.Enabled = false;
            bien = 0;
            dtgvCTHD.ClearSelection();
            btnThemCT.Enabled = true;
            btnSuaCT.Enabled = true;
            btnXoaCT.Enabled = true;

        }
    }
}
