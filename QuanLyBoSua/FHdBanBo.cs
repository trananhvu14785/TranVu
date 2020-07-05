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
    public partial class FHdBanBo : Form
    {
        private string maNv;
        public FHdBanBo(string maNv=null)
        {
            this.maNv = maNv;
            InitializeComponent();
            LoadTenKh();
            loadNhanVien();
            LoadHd();
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
        void LoadHd()
        {
            try
            {
                string query = "select H.maHD,K.tenKH,H.maNv,convert(nvarchar(30), H.ngayMua, 20)as ngayMua,H.thanhTien from HDBanBo H,KhachHang k where H.maKH=K.maKH";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvHD.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        private int row;
        private void dtgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                lbMaHd.Text = dtgvHD.Rows[numrow].Cells[0].Value.ToString();
                row = numrow;
                lbMaHd.Visible = true;
                label13.Visible = true;
                cbTenKh.Text= dtgvHD.Rows[numrow].Cells[1].Value.ToString();
                cbMaNv.Text= dtgvHD.Rows[numrow].Cells[2].Value.ToString();
                DateTime dt = Convert.ToDateTime(dtgvHD.Rows[numrow].Cells[3].Value.ToString());
                dtpkNgayLap.Value = dt;
                txTongTien.Text= dtgvHD.Rows[numrow].Cells[4].Value.ToString();
                getMaHd();
                cbmaHD.Text = lbMaHd.Text;
                LoadCTHD(lbMaHd.Text);
                loadBo();
            }
        }
        void loadBo()
        {
            try
            {
                string query = "Select * from danBo where ngayXuatChuong is null";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                cbMaBo.DataSource = data;
                cbMaBo.DisplayMember = "maBo";
                cbMaBo.ValueMember = "maBo";
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        void LoadCTHD(string maHd)
        {
            try
            {
                string query = "Select * from CTHDBanBo where maHd='" + maHd + "'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvCTHD.DataSource = data;
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
                string query = "Select * from HDBanBo";
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
        
        int dem = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
           
        }
        void update()
        {
            panelInforHD.Enabled = false;
            dtpkNgayLap.Enabled = false;


            dem = 0;
         
            txTongTien.ResetText();
            dtgvHD.ClearSelection();
            dtgvCTHD.ClearSelection();



            txGiaNhap.ResetText();
            txTongTien.Text = "0";

         
            txGiaNhap.ResetText();
            panelCTHD.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
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
        int bien = 0;

        public string MaNv { get => maNv; set => maNv = value; }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
          
        }
        void loadUpdate()
        {
            int numrow = row;
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
                cbMaBo.Text = dtgvCTHD.Rows[numrow].Cells[1].Value.ToString();
                txGiaNhap.Text = dtgvCTHD.Rows[numrow].Cells[2].Value.ToString();
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void txTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "select H.maHD,K.tenKH,H.maNv,convert(nvarchar(30), H.ngayMua, 20)as ngayMua,H.thanhTien from HDBanBo H,KhachHang k where H.maKH=K.maKH and maHd like N'%" + txTimKiem.Text + "%'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvHD.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        void exFile(DataGridView data)
        {
            bool fileError = true;
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XLSX(*.xlsx)|*.xlsx";
                saveFileDialog.FileName = "HoaDonBanBo.xlsx";
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
                    obj.Columns.ColumnWidth = 35;
                    obj.StandardFontSize = 13;
                    obj.Cells[1].Font.Bold = true;
                    obj.Rows[2].Font.Bold = true;

                    obj.Rows[1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    obj.Rows[2].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    obj.Rows[3].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    obj.Rows[4].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    obj.Rows[3].Font.Bold = true;
                    obj.Rows[4].Font.Bold = true;
                    int dem1 = 4;
                    obj.Cells[1, 1] = "         Hóa Đơn Bán Bò     ";
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
                            dem1 += 1;
                            obj.Rows[dem1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
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

                    obj.Cells[dem1 + 1, 1] = "Tổng Tiền " + txTongTien.Text;
                    obj.Rows[dem1 + 1].Font.Color = Color.Red;
                    obj.Rows[dem1 + 1].Font.Bold = true;
                    obj.Rows[dem1 + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    obj.ActiveWorkbook.SaveCopyAs(saveFileDialog.FileName);
                    obj.ActiveWorkbook.Saved = true;
                    Alert a = new Alert("In thành công", AlertType.success);
                    a.ShowDialog();
                    //try
                    //{
                    //    string dcmail = "";
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

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
           
        }

        private void txGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && txGiaNhap.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            panelInforHD.Enabled = true;
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
            if (lbMaHd.Text == "0")
            {
                Alert a = new Alert("Vui Lòng chọn hóa đơn cần Xóa.", AlertType.error);

                a.ShowDialog();

            }
            else
            {
                try
                {
                    string query = "Delete HDBanBo where maHd='" + lbMaHd.Text + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                    Alert a = new Alert("Xóa thành công.", AlertType.success);

                    a.ShowDialog();
                    LoadHd();
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
                    string querry = "Insert into HDBanBo(ngayMua,maNv,maKh,thanhTien) Values(  convert(nvarchar(30), getDate(), 20) ,'" + cbMaNv.SelectedValue + "','" + cbTenKh.SelectedValue + "','0')";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                    Alert a = new Alert("Thêm thành công.", AlertType.success);
                    a.ShowDialog();
                    LoadHd();
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
                if (dem == 2)
                {
                    string querry = "Update HDBanBo set maKh='" + cbTenKh.SelectedValue + "',ngayMua=N'" + dtpkNgayLap.Value + "',maNv='" + cbMaNv.SelectedValue + "' where maHd='" + lbMaHd.Text + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                    Alert a = new Alert("Sửa thành công.", AlertType.success);
                    a.ShowDialog();
                    LoadHd();
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
            if (txGiaNhap.Text == "")
            {
                Alert a = new Alert("Hãy Chọn Chi tiết hóa đơn cần Xóa", AlertType.error);
                a.ShowDialog();
            }
            else
            {
                try
                {
                    string query = "Delete CTHDBanBo where maHd='" + cbmaHD.SelectedValue + "' and maBo='" + cbMaBo.Text + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                    Alert a = new Alert("Xóa thành công", AlertType.success);
                    a.ShowDialog();
                    LoadCTHD(cbmaHD.Text);
                    LoadHd();
                    update();
                    loadUpdate();
                }
                catch
                {
                    Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                    a.ShowDialog();
                }
            }
        }

        private void btnLuuCT_Click(object sender, EventArgs e)
        {
            try
            {
                if (bien == 1)
                {
                    if (txGiaNhap.Text == "")
                    {
                        Alert a = new Alert("Bạn hãy nhập đủ thông tin", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {
                        string query = "Insert into CTHDBanBo values('" + cbmaHD.Text + "','" + cbMaBo.Text + "','" + txGiaNhap.Text + "')";
                        DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                        Alert a = new Alert("Thêm thành công", AlertType.success);
                        a.ShowDialog();
                        LoadCTHD(cbmaHD.Text);
                        loadBo();
                        LoadHd();
                        update();
                        loadUpdate();
                        btnThemCT.Enabled = true;
                        btnSuaCT.Enabled = true;
                        btnXoaCT.Enabled = true;
                    }
                }
                if (bien == 2)
                {
                    if (txGiaNhap.Text == "")
                    {
                        Alert a = new Alert("Bạn hãy nhập đủ thông tin", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {
                        string query = "Update CTHDBanBo set maBo='" + cbMaBo.SelectedValue + "',giaBan='" + txGiaNhap.Text + "' where maHd='" + cbmaHD.SelectedValue + "'";
                        DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                        Alert a = new Alert("Sửa thành công", AlertType.success);
                        a.ShowDialog();
                        LoadCTHD(cbmaHD.Text);
                        LoadHd();
                        loadBo();
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
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void btnHuyCT_Click(object sender, EventArgs e)
        {
            txGiaNhap.ResetText();

            panelCTHD.Enabled = false;
            bien = 0;
            dtgvCTHD.ClearSelection();
        }

        private void bunifuThinButton26_Click_1(object sender, EventArgs e)
        {

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
    }
}
