using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app = Microsoft.Office.Interop.Excel.Application;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
namespace QuanLyBoSua
{
    public partial class FormHDNhapBo : Form
    {
        private string maNv;
        public FormHDNhapBo(string maNv=null)
        {
            this.maNv = maNv;
            InitializeComponent();
            loadNhaCungCap();
            loadNhanVien();
            LoadHoaDon();
           
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

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

            }
        }
        private int dem = 0;

        private void btnThem_Click(object sender, EventArgs e)
        {
           

          
        }

        void LoadHoaDon()
        {
            try
            {
                string query = "select H.maHD,N.tenNCC,H.maNv,convert(nvarchar(30), H.ngayLap, 20)as ngayLap,H.tongTien from HDNhapBo H,NhaCungCap N where H.maNCC=N.maNCC";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvHD.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
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
                txTongTien.Text= dtgvHD.Rows[numrow].Cells[4].Value.ToString();
                getMaHd();
                cbmaHD.Text = lbMaHd.Text;
                LoadCTHD(lbMaHd.Text);
                loadTrangThai();
                getTenCHuong();

            }
        }
        void LoadCTHD(string maHd)
        {
            string query = "";
            try
            {
                query = "select d.maBo,d.gioiTinh,d.trongLuong, d.idCategory,cth.giaBoNhap,cth.LoaiNhap,d.MaChuong"+
                     " from HdNhapBo H,DanBo d, CTHDNhapBo cth,categoryBo C"+
                   " where H.maHD = cth.maHD and d.maBo = cth.maBo and C.idCategory = d.idCategory and cth.maHd = '"+maHd+"'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
              
                 data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvCTHD.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
          
        }
        void getMaHd()
        {
            try
            {
                string query = "Select * from HdNhapBo";
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

        private int bien=0;

        public string MaNv { get => maNv; set => maNv = value; }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            

        }
        bool KiemTraMabo(string maBo)
        {
            try
            {
                string query = "Select * from danBo where maBo='" + maBo + "'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                if (data.Rows.Count > 0)
                    return false;
                return true;
            }
            catch
            {
                return true;
            }

        }
      
        void getTenCHuong()
        {
            try
            {
                string query = "Select * from ChuongTrai";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                cbTenChuong.DataSource = data;
                cbTenChuong.DisplayMember = "tenChuong";
                cbTenChuong.ValueMember = "maChuong";
              
            }
            catch { }
        }
        void loadTrangThai()
        {
            try
            {
                string query = "Select * from categoryBo";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                cbTrangThai.DataSource = data;
                cbTrangThai.DisplayMember = "categoryName";
                cbTrangThai.ValueMember = "idCategory";
            }
            catch { }
        }
        int getTongSoCHo(string tenChuong)
        {
            try
            {
                int tongcho = 0;
                string query = "Select * from chuongTrai where tenChuong=N'" + tenChuong + "'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                foreach (DataRow item in data.Rows)
                {
                    tongcho = int.Parse(item["tongsoCho"].ToString());
                }
                
                return tongcho;
            }
            catch
            {
                return 0;
            }
        }
        int demBo(string maChuong)
        {
            int sobo = 0;
            string query = "Select * from danBo where maCHuong='" + maChuong + "' and ngayXuatChuong is null";
            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
            foreach (DataRow item in data.Rows)
                sobo++;
            
            return sobo;
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
            
            
            txMaBo.ResetText();
            txGiaNhap.ResetText();
            txTongTien.Text="0";
            txTrongLuong.ResetText();
            rdbCai.Checked = false;
            rdbDuc.Checked = false;
            lbTenChuong.Text = "0";
            panelCTHD.Enabled = false;
        }
        void loadUpdate()
        {
            int numrow = rowIndex;
            txTongTien.Text = dtgvHD.Rows[numrow].Cells[4].Value.ToString();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
           
        }

        private void dtgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
               
                txMaBo.Text = dtgvCTHD.Rows[numrow].Cells[0].Value.ToString();
                string gioitinh = dtgvCTHD.Rows[numrow].Cells[1].Value.ToString();
                if (gioitinh == "Đực")
                    rdbDuc.Checked = true;
                else
                    rdbCai.Checked = true;
                txTrongLuong.Text= dtgvCTHD.Rows[numrow].Cells[2].Value.ToString();
                cbTrangThai.SelectedValue = dtgvCTHD.Rows[numrow].Cells[3].Value.ToString();
                string loaiNhap = dtgvCTHD.Rows[numrow].Cells[5].Value.ToString();
                if (loaiNhap == "Thuê")
                {
                    rdbtThue.Checked = true;
                    labelChuong.Visible = false;
                    cbTenChuong.Visible = false;
                }
                else
                {
                    rdbtMua.Checked = true;
                    labelChuong.Visible = true;
                    cbTenChuong.Visible = true;
                }
                string tenChuong = dtgvCTHD.Rows[numrow].Cells[6].Value.ToString();
                if (tenChuong != "")
                {
                    cbTenChuong.SelectedValue = dtgvCTHD.Rows[numrow].Cells[6].Value.ToString();
                    lbTenChuong.Text = cbTenChuong.Text;
                }



                txGiaNhap.Text= dtgvCTHD.Rows[numrow].Cells[4].Value.ToString();




            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
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
                saveFileDialog.FileName = "HoaDonNhapBo.xlsx";
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
                    obj.Cells[1, 1] = "         Hóa Đơn Nhập Bò     ";
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
            catch
            {
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
                string query = "select H.maHD,N.tenNCC,H.maNv,convert(nvarchar(30), H.ngayLap, 20)as ngayLap,H.tongTien from HDNhapBo H,NhaCungCap N where H.maNCC=N.maNCC and maHd like N'%" + txTimKiem.Text + "%'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvHD.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void dtgvCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void ExportPDF(DataGridView dgt,string fileName)
        {
            try
            {
                BaseFont bf = BaseFont.CreateFont(Environment.GetEnvironmentVariable("windir") + @"\fonts\arialbd.TTF", BaseFont.IDENTITY_H, true);
                PdfPTable pdfPTable = new PdfPTable(dgt.Columns.Count);
                PdfPTable inner = new PdfPTable(1);
                PdfPTable header = new PdfPTable(2);
                PdfPTable footer = new PdfPTable(1);
                pdfPTable.DefaultCell.Padding = 3;
                pdfPTable.WidthPercentage = 100;
                pdfPTable.HorizontalAlignment = Element.ALIGN_MIDDLE;
                pdfPTable.DefaultCell.BorderWidth = 1;
                iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
                // pdfPTable.AddCell(new PdfPCell(new Phrase("Hóa đơn nhập bò")));
                PdfPCell cell_1 = new PdfPCell();
                Paragraph p = new Paragraph("Hóa đơn nhập Bò", text);
                p.Alignment = Element.ALIGN_CENTER;
                cell_1.AddElement(p);
                cell_1.Border = 0;
                inner.AddCell(cell_1);

                PdfPCell cell_2_1 = new PdfPCell();
                Paragraph p1 = new Paragraph("Mã hóa đơn: " + cbmaHD.Text, text);
                p1.Alignment = Element.ALIGN_CENTER;
                cell_2_1.AddElement(p1);
                cell_2_1.Border = 0;
                header.AddCell(cell_2_1);

                PdfPCell cell_2_2 = new PdfPCell();
                Paragraph p2 = new Paragraph("Ngày lập: " + dtpkNgayLap.Value.ToString(), text);
                p2.Alignment = Element.ALIGN_CENTER;
                cell_2_2.AddElement(p2);
                cell_2_2.Border = 0;
                header.AddCell(cell_2_2);

                PdfPCell cell_3_1 = new PdfPCell();
                Paragraph p3_1 = new Paragraph("Nhà Cung Cấp: " + cbNcc.Text, text);
                p3_1.Alignment = Element.ALIGN_CENTER;
                cell_3_1.AddElement(p3_1);
                cell_3_1.Border = 0;
                header.AddCell(cell_3_1);

                PdfPCell cell_3_2 = new PdfPCell();
                Paragraph p3_2 = new Paragraph("Mã nhân viên: " + cbMaNv.Text, text);
                p3_2.Alignment = Element.ALIGN_CENTER;
                cell_3_2.AddElement(p3_2);
                cell_3_2.Border = 0;
                header.AddCell(cell_3_2);

                PdfPCell cell_Footer = new PdfPCell();
                Paragraph p_footer = new Paragraph("Tổng Tiền: " + txTongTien.Text, text);
                p_footer.Alignment = Element.ALIGN_LEFT;
                cell_Footer.AddElement(p_footer);
                cell_Footer.Border = 0;
                footer.AddCell(cell_Footer);


                foreach (DataGridViewColumn column in dgt.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                    cell.BackgroundColor = new BaseColor(240, 240, 240);
                    pdfPTable.AddCell(cell);

                }
                foreach (DataGridViewRow row in dgt.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfPTable.AddCell(new Phrase(cell.Value.ToString(), text));
                    }
                }
                var savefileDialog = new SaveFileDialog();
                savefileDialog.Filter = "PDF (*.pdf)|*.pdf";
                savefileDialog.FileName = fileName;
                //   savefileDialog.DefaultExt = ".pdf";
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                using (FileStream stream = new FileStream(savefileDialog.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(inner);
                    pdfDoc.Add(header);
                    pdfDoc.Add(pdfPTable);
                    pdfDoc.Add(footer);
                    pdfDoc.Close();
                    stream.Close();
                }
                Alert a = new Alert("Xuất thành công", AlertType.success);
                a.ShowDialog();
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }


        }
        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
             ExportPDF(dtgvCTHD, @"E:\API\File\text.pdf");
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txTrongLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && txTrongLuong.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
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
            txTongTien.ResetText();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
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
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = false;
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
                    string query = "Delete HDnhapBo where maHd='" + lbMaHd.Text + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                    Alert a = new Alert("Xóa thành công.", AlertType.success);

                    a.ShowDialog();
                    LoadHoaDon();
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


                    string query = "Insert into HDNhapBo(maNcc,maNv,ngayLap,TongTien) values('" + cbNcc.SelectedValue + "','" + cbMaNv.SelectedValue + "',convert(nvarchar(30), getDate(), 20),'0')";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);
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
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;
                }
                else if (dem == 2)
                {
                    string query = "update HDnhapBo set maNCC='" + cbNcc.SelectedValue + "',maNv='" + cbMaNv.SelectedValue + "',ngayLap=N'" + dtpkNgayLap.Value + "' where maHd='" + lbMaHd.Text + "'";
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
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;
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
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
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
                txMaBo.ResetText();
                txTrongLuong.ResetText();
                txGiaNhap.ResetText();
                txMaBo.Focus();
                panelCTHD.Enabled = true;
                btnThemCT.Enabled = false;
                btnXoaCT.Enabled = false;
                btnSuaCT.Enabled = false;
            }
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            if ((txMaBo.Text != "" && KiemTraMabo(txMaBo.Text) || txMaBo.Text == "") == true)
            {
                Alert a = new Alert("Hãy Chọn bò Cần sửa", AlertType.error);
                a.ShowDialog();
            }
            else
            {
                bien = 2;
                panelCTHD.Enabled = true;
                txMaBo.ReadOnly = true;
                btnThemCT.Enabled = false;
                btnXoaCT.Enabled = false;
                btnSuaCT.Enabled = false;
            }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txMaBo.Text != "" && KiemTraMabo(txMaBo.Text) || txMaBo.Text == "") == true)
                {
                    Alert a = new Alert("Hãy Chọn bò Cần Xóa", AlertType.error);
                    a.ShowDialog();
                }
                else
                {
                    string query = "Delete CTHDNhapBo where maBo='" + txMaBo.Text + "'";
                    string query1 = "Delete DanBo where maBo='" + txMaBo.Text + "'";

                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                    DataTable data1 = KetNoi.Istance.ExcuteQuerry(query1);
                    Alert a = new Alert("Xóa thành công", AlertType.success);
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

        private void btnLuuCT_Click(object sender, EventArgs e)
        {
            try
            {
                string gioitinh = "";
                if (rdbCai.Checked == true)
                    gioitinh = "Cái";
                else if (rdbDuc.Checked == true)
                    gioitinh = "Đực";
                if (bien == 1)
                {
                    if (txMaBo.Text == "" || txTrongLuong.Text == "" || txGiaNhap.Text == "" || (rdbCai.Checked == false && rdbDuc.Checked == false)||(rdbtThue.Checked==false && rdbtMua.Checked==false))
                    {
                        Alert a = new Alert("Bạn hãy nhập đủ thông tin", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {
                        if (KiemTraMabo(txMaBo.Text) == false)
                        {
                            Alert a = new Alert("Mã bò đã tồn tại", AlertType.error);
                            a.ShowDialog();
                        }
                       
                        else if (getTongSoCHo(cbTenChuong.Text) == demBo(cbTenChuong.SelectedValue.ToString()) && rdbtMua.Checked==true)
                        {
                            Alert a = new Alert("Chuồng bạn chọn đã hết chỗ", AlertType.error);
                            a.ShowDialog();
                        }
                        else
                        {
                            string query = "";
                        string loaiNhap = "";
                      
                            if (rdbtThue.Checked == true)
                            {
                            loaiNhap = "Thuê";
                                query = "Insert into DanBo values('" + txMaBo.Text + "',N'" + gioitinh + "','" + txTrongLuong.Text + "','" + cbTrangThai.SelectedValue + "',null,null,null)";
                            }
                            else
                            {
                            loaiNhap = "Mua";
                                query = "Insert into DanBo values('" + txMaBo.Text + "',N'" + gioitinh + "','" + txTrongLuong.Text + "','" + cbTrangThai.SelectedValue + "','" + cbTenChuong.SelectedValue + "',getDate(),null)";
                            }
                            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                            string query1 = "Insert into CTHDNhapBo values('" + cbmaHD.SelectedValue + "','" + txMaBo.Text + "','" + txGiaNhap.Text + "',N'"+loaiNhap+"')";
                            DataTable data1 = KetNoi.Istance.ExcuteQuerry(query1);
                            Alert a = new Alert("Thêm thành công", AlertType.success);
                            a.ShowDialog();
                            LoadCTHD(cbmaHD.SelectedValue.ToString());
                            LoadHoaDon();
                            update();
                            loadUpdate();
                            btnThemCT.Enabled = true;
                            btnXoaCT.Enabled = true;
                            btnSuaCT.Enabled = true;

                        }
                    }

                }
                if (bien == 2)
                {
                    if (txMaBo.Text == "" || txTrongLuong.Text == "" || txGiaNhap.Text == "" || (rdbCai.Checked == false && rdbDuc.Checked == false))
                    {
                        Alert a = new Alert("Bạn hãy nhập đủ thông tin", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {
                        //if (getTongSoCHo(cbTenChuong.Text) == demBo(cbTenChuong.SelectedValue.ToString()))
                        //{
                        //    Alert a = new Alert("Chuồng bạn chọn đã hết chỗ", AlertType.error);
                        //    a.ShowDialog();
                        //}
                        //else 
                        if (cbTenChuong.Text != lbTenChuong.Text && getTongSoCHo(cbTenChuong.Text) == demBo(cbTenChuong.SelectedValue.ToString()) && rdbtMua.Checked==true)
                        {
                            Alert a = new Alert("Chuồng bạn chọn đã hết chỗ", AlertType.error);
                            a.ShowDialog();
                        }
                        
                        else
                        {
                            string query = "";
                        string loaiNhap = "";
                        if (rdbtMua.Checked == true)
                        {
                            loaiNhap = "Mua";
                            query = "Update DanBo set gioiTinh=N'" + gioitinh + "',trongLuong='" + txTrongLuong.Text + "',idcategory='" + cbTrangThai.SelectedValue + "',maChuong='" + cbTenChuong.SelectedValue + "',ngayNhapChuong=getdate() where maBo='" + txMaBo.Text + "'";
                        }
                        else
                        {
                            loaiNhap = "Thuê";
                            query = "Update DanBo set gioiTinh=N'" + gioitinh + "',trongLuong='" + txTrongLuong.Text + "',idcategory='" + cbTrangThai.SelectedValue + "',maChuong=null,ngayNhapChuong=null where maBo='" + txMaBo.Text + "'";
                        }
                            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                            string query1 = "Update CTHDNhapBo set giaBoNhap='" + txGiaNhap.Text + "',loaiNhap=N'"+loaiNhap+"' where maHd='" + cbmaHD.SelectedValue + "' and maBo='" + txMaBo.Text + "'";
                            DataTable data1 = KetNoi.Istance.ExcuteQuerry(query1);
                            Alert a = new Alert("Sửa thành công", AlertType.success);
                            a.ShowDialog();
                            update();
                            LoadCTHD(cbmaHD.SelectedValue.ToString());
                            LoadHoaDon();
                            txMaBo.ReadOnly = false;
                            bien = 0;
                            loadUpdate();
                            btnThemCT.Enabled = true;
                            btnXoaCT.Enabled = true;
                            btnSuaCT.Enabled = true;
                        }
                    }
                }
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void btnHuyCT_Click(object sender, EventArgs e)
        {
            txMaBo.ResetText();
            txTrongLuong.ResetText();
            txGiaNhap.ResetText();
            rdbCai.Checked = false;
            rdbDuc.Checked = false;
            panelCTHD.Enabled = false;
            dtgvCTHD.ClearSelection();
            btnThemCT.Enabled = true;
            btnXoaCT.Enabled = true;
            btnSuaCT.Enabled = true;
            txMaBo.ReadOnly = false;
        }

        private void rdbtMua_CheckedChanged(object sender, EventArgs e)
        {
              if (rdbtThue.Checked == true)
            {
                labelChuong.Visible = false;
                cbTenChuong.Visible = false;
             }
            else
            {
                labelChuong.Visible = true;
                cbTenChuong.Visible = true;
            }
        }

        private void rdbtThue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtThue.Checked == true)
            {
                labelChuong.Visible = false;
                cbTenChuong.Visible = false;
            }
            else
            {
                labelChuong.Visible = true;
                cbTenChuong.Visible = true;
            }
        }
    }
}
