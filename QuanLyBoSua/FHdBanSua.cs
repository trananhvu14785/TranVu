using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QuanLyBoSua
{
    public partial class FHdBanSua : Form
    {
        private string maNv;
        public FHdBanSua(string maNv=null)
        {
            this.maNv = maNv;
            InitializeComponent();
            LoadTenKh();
            loadNhanVien();
            loadLuongSua();
            loadHD();
        }
        void LoadTenKh()
        {
            try
            {
                string query = "Select * from khachHang";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                cbTenKh.DataSource = data;
                cbTenKh.DisplayMember = "tenKh";
                cbTenKh.ValueMember = "maKh";
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
        void loadLuongSua()
        {
            try
            {
                string query = "Select soLuongSua from khosua";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                foreach (DataRow item in data.Rows)
                {
                    lbLuongSua.Text = item["soluongsua"].ToString();
                }
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
                
        }
        void loadHD()
        {
            try
            {
                string query = "select H.maHD,convert(nvarchar(30), H.ngayMua, 20)as ngayMua,H.maNv,K.tenKH,H.SlSuaBan,H.tienSua1lit,H.thanhTien from HDBanSua H,KhachHang K where H.maKH=K.maKH";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvHd.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }

        }

        private void dtgvHd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                lbMaHd.Text = dtgvHd.Rows[numrow].Cells[0].Value.ToString();
                lbMaHd.Visible = true;
                label13.Visible = true;
                DateTime dt = Convert.ToDateTime(dtgvHd.Rows[numrow].Cells[1].Value.ToString());
                dtpkNgayMua.Value = dt;
                cbMaNv.Text= dtgvHd.Rows[numrow].Cells[2].Value.ToString();
                cbTenKh.Text= dtgvHd.Rows[numrow].Cells[3].Value.ToString();
                numSoLuong.Value= int.Parse(dtgvHd.Rows[numrow].Cells[4].Value.ToString());
                txDonGia.Text= dtgvHd.Rows[numrow].Cells[5].Value.ToString();
                txThanhTien.Text= dtgvHd.Rows[numrow].Cells[6].Value.ToString();
            }
        }
        int dem = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
          
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
        }

        private void txDonGia_TextChanged(object sender, EventArgs e)
        {
            if (numSoLuong.Value != 0)
            {
                if (txDonGia.Text != "")
                {
                    txThanhTien.Text = float.Parse(numSoLuong.Value.ToString()) * float.Parse(txDonGia.Text) + "";
                }
                if (txDonGia.Text == "" )
                {
                    txThanhTien.Text = "0";
                }
            }
            if( numSoLuong.Value == 0)
                txThanhTien.Text = "0";
        }

        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (numSoLuong.Value != 0)
            {
                if (txDonGia.Text != "")
                {
                    txThanhTien.Text = float.Parse(numSoLuong.Value.ToString()) * float.Parse(txDonGia.Text) + "";
                }
                if (txDonGia.Text == "" )
                {
                    txThanhTien.Text = "0";
                }
            }
            if (numSoLuong.Value == 0)
                txThanhTien.Text = "0";
        }
        decimal slCu = 0;

        public string MaNv { get => maNv; set => maNv = value; }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

       
        private void txTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "select H.maHD,convert(nvarchar(30), H.ngayMua, 20)as ngayMua,H.maNv,K.tenKH,H.SlSuaBan,H.tienSua1lit,H.thanhTien from HDBanSua H,KhachHang K where H.maKH=K.maKH and maHd like N'%" + txTimKiem.Text + "%'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvHd.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
           
        }
        void exFile(DataGridView data)
        {
            bool fileError = true;
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XLSX(*.xlsx)|*.xlsx";
                saveFileDialog.FileName = "HoaDonBanSua.xlsx";
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
                    obj.Columns.ColumnWidth = 30;
                    obj.StandardFontSize = 13;
                    obj.Cells[1].Font.Bold = true;
                    obj.Rows[2].Font.Bold = true;

                    obj.Rows[1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    obj.Rows[2].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    obj.Rows[3].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    obj.Rows[4].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    obj.Rows[3].Font.Bold = true;
                    obj.Rows[4].Font.Bold = true;

                    obj.Cells[1, 1] = "         Hóa Đơn Bán Sữa     ";


                    if (dtgvHd.RowCount > 0)
                    {

                        for (int i = 1; i < data.Columns.Count + 1; i++)
                        {

                            obj.Cells[2, i] = data.Columns[i - 1].HeaderText;
                        }
                        for (int i = 0; i < data.Rows.Count; i++)
                        {


                            for (int j = 0; j < data.Columns.Count; j++)
                            {
                                if (data.Rows[i].Cells[j].Value != null)
                                {
                                    obj.Cells[i + 3, j + 1] = data.Rows[i].Cells[j].Value.ToString();
                                }
                                else
                                {
                                    obj.Cells[i + 3, j + 1] = "";
                                }
                            }
                        }
                    }
                    obj.ActiveWorkbook.SaveCopyAs(saveFileDialog.FileName);
                    obj.ActiveWorkbook.Saved = true;
                    Alert a = new Alert("In thành công", AlertType.success);
                    a.ShowDialog();
                    //try
                    //{
                    //    string dcmail="";
                    //    string querry = "select email from khachhang where tenkh = N'" + cbTenKh.Text + "'";
                    //    DataTable DL = KetNoi.Istance.ExcuteQuerry(querry);
                    //    foreach (DataRow row in DL.Rows)
                    //    {
                    //        dcmail = row["email"].ToString();
                    //    }
                    //    SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                    //    mailclient.EnableSsl = true;
                    //    mailclient.Credentials = new NetworkCredential("hoanglaptrinh6399@gmail.com", "dinhhoang0603");

                    //    MailMessage message = new MailMessage("hoanglaptrinh6399@gmail.com", dcmail);
                    //    message.Subject = "THƯ CẢM ƠN KHÁCH HÀNG CỦA BENRI FARM";
                    //    message.Body = "Cảm ơn quý khách hàng " + cbTenKh.Text + " đã tin tưởng Benri Farm! " + "\n" + "Kính mong quý khách sẽ tiếp tục ủng hộ!" + "\n" +
                    //        "Thân ái!";

                    //    mailclient.Send(message);
                    //    message = null;
                    //    Alert b = new Alert("Mail đã được gửi đi!", AlertType.success);
                    //    b.ShowDialog();
                    //}
                    //catch
                    //{
                    //    Alert b = new Alert("Báo cáo chưa được gửi do lỗi mạng!", AlertType.info);
                    //    b.ShowDialog();
                    //}
                }
            
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            panelHDBS.Enabled = true;
            dem = 1;
            numSoLuong.Value = 0;
            txThanhTien.Text = "0";
            txDonGia.Text = "0";
            lbMaHd.Text = "0";
            lbMaHd.Visible = false;
            label13.Visible = false;
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
            }
            else
            {
                dem = 2;
                panelHDBS.Enabled = true;
                dtpkNgayMua.Enabled = true;
                slCu = numSoLuong.Value;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (lbMaHd.Text == "0")
            {

                Alert a = new Alert("Vui Lòng chọn hóa đơn cần Xóa.", AlertType.error);

                a.ShowDialog();
            }
            else
            {
                try
                {
                    string query = "Delete HDBanSua where maHd='" + lbMaHd.Text + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                    Alert a = new Alert("Xóa thành công.", AlertType.success);
                    a.ShowDialog();
                    loadHD();
                    loadLuongSua();
                    panelHDBS.Enabled = false;
                    lbMaHd.Visible = false;
                    label13.Visible = false;
                    txDonGia.Text = "";
                    numSoLuong.Value = 0;
                    txThanhTien.Text = "0";
                    dem = 0;
                }
                catch
                {
                    Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                    a.ShowDialog();
                }

            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dem == 1)
                {
                    if (txDonGia.Text == "" || numSoLuong.Value == 0)
                    {
                        Alert a = new Alert("Vui nhập đủ thông tin.", AlertType.error);

                        a.ShowDialog();
                    }
                    else if (double.Parse(lbLuongSua.Text) < double.Parse(numSoLuong.Value.ToString()))
                    {
                        Alert a = new Alert("Lượng sữa trong kho không đủ.", AlertType.error);

                        a.ShowDialog();
                    }
                    else
                    {
                        string query = "insert into HDBanSua(ngayMua,maNv,maKH,SlSuaBan,tienSua1lit,thanhTien) values(N'" + dtpkNgayMua.Value + "','" + cbMaNv.Text + "','" + cbTenKh.SelectedValue + "','" + numSoLuong.Value + "','" + txDonGia.Text + "','" + txThanhTien.Text + "')";
                        DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                        Alert a = new Alert("Thêm thành công.", AlertType.success);
                        a.ShowDialog();
                        loadHD();
                        loadLuongSua();
                        panelHDBS.Enabled = false;
                        txDonGia.Text = "";
                        numSoLuong.Value = 0;
                        txThanhTien.Text = "0";
                        dem = 0;
                        btnThem.Enabled = true;
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                    }
                }
                if (dem == 2)
                {
                    if (txDonGia.Text == "" || numSoLuong.Value == 0)
                    {
                        Alert a = new Alert("Vui nhập đủ thông tin.", AlertType.error);

                        a.ShowDialog();
                    }
                    else if (slCu < numSoLuong.Value && numSoLuong.Value - slCu > decimal.Parse(lbLuongSua.Text))
                    {
                        Alert a = new Alert("Lượng sữa trong kho không đủ.", AlertType.error);

                        a.ShowDialog();
                    }
                    else
                    {
                        string query = "Update HDBanSua set ngayMua=N'" + dtpkNgayMua.Value + "',maNv='" + cbMaNv.Text + "',maKh='" + cbTenKh.SelectedValue + "',slSuaBan='" + numSoLuong.Value + "',tiensua1lit='" + txDonGia.Text + "',thanhTien='" + txThanhTien.Text + "' where maHd='" + lbMaHd.Text + "'";
                        DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                        Alert a = new Alert("Sửa thành công.", AlertType.success);
                        a.ShowDialog();
                        loadHD();
                        loadLuongSua();
                        panelHDBS.Enabled = false;
                        lbMaHd.Visible = false;
                        label13.Visible = false;
                        txDonGia.Text = "";
                        numSoLuong.Value = 0;
                        txThanhTien.Text = "0";
                        dtpkNgayMua.Enabled = false;
                        dem = 0;
                        btnThem.Enabled = true;
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                    }
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
            panelHDBS.Enabled = false;
            dtgvHd.ClearSelection();
            txDonGia.ResetText();
            loadHD();
            txTimKiem.Text = "";
            numSoLuong.Value = 0;
            lbMaHd.Text = "0";
            lbMaHd.Visible = false;
            label13.Visible = false;
            dtpkNgayMua.Enabled = true;
            dem = 0;
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
                exFile(dtgvHd);
            }
        }
    }
}
