using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace QL_DocGiaThuVien
{
    public partial class frm_ThemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frm_ThemNhanVien()
        {
            InitializeComponent();
        }
        MD5 md5 = new MD5();

        private void auto_MaNhanVien()
        {
            string tenDN = "";
            try
            {
                DataTable DSNhom = tAIKHOANNHANVIENTableAdapter.GetData();

                DataRow lastRow = DSNhom.Rows[DSNhom.Rows.Count - 1];

                if (DSNhom.Rows.Count <= 0)
                {
                    txt_MaNhanVien.Text = "NV00000001";
                }

                tenDN += lastRow[0].ToString().Trim();

                int s = int.Parse(tenDN.Substring(2)) + 1;

                if (s < 10)
                {
                    txt_MaNhanVien.Text = "NV0000000" + (s).ToString();
                }
                else if (s >= 10)
                {
                    txt_MaNhanVien.Text = "NV000000" + (s).ToString();
                }
                else if (s >= 100)
                {
                    txt_MaNhanVien.Text = "NV00000" + (s).ToString();
                }
                else if (s >= 1000)
                {
                    txt_MaNhanVien.Text = "NV0000" + (s).ToString();
                }
                else if (s >= 10000)
                {
                    txt_MaNhanVien.Text = "NV000" + (s).ToString();
                }
                else if (s >= 100000)
                {
                    txt_MaNhanVien.Text = "NV00" + (s).ToString();
                }
                else if (s >= 1000000)
                {
                    txt_MaNhanVien.Text = "NV0" + (s).ToString();
                }
                else
                {
                    txt_MaNhanVien.Text = "NV" + (s).ToString();
                }



            }
            catch (Exception ex)
            {
                string x = ex.Message.ToString();
            }
        }
        private void frm_ThemNhanVien_Load(object sender, EventArgs e)
        {
            auto_MaNhanVien();
            // TODO: This line of code loads data into the 'qL_DocGia_KhoaHocTongHopTPHCMDataSet.NHOMNHANVIEN' table. You can move, or remove it, as needed.
            this.nHOMNHANVIENTableAdapter.Fill(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.NHOMNHANVIEN);
            // TODO: This line of code loads data into the 'qL_DocGia_KhoaHocTongHopTPHCMDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.NHANVIEN);
            // TODO: This line of code loads data into the 'qL_DocGia_KhoaHocTongHopTPHCMDataSet.TAIKHOANNHANVIEN' table. You can move, or remove it, as needed.
            this.tAIKHOANNHANVIENTableAdapter.Fill(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.TAIKHOANNHANVIEN);
            // TODO: This line of code loads data into the 'qL_DocGia_KhoaHocTongHopTPHCMDataSet.DANTOC' table. You can move, or remove it, as needed.
            this.dANTOCTableAdapter.Fill(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.DANTOC);
            // TODO: This line of code loads data into the 'qL_DocGia_KhoaHocTongHopTPHCMDataSet.TRINHDO' table. You can move, or remove it, as needed.
            this.tRINHDOTableAdapter.Fill(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.TRINHDO);
        }

        private void pictureBox_NhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                string duongdan = null;
                OpenFileDialog d = new OpenFileDialog();
                d.Filter = "Image Files(.jpg) | *.jpg";

                if (d.ShowDialog() == DialogResult.OK)
                {
                    duongdan = d.FileName;
                }
                pictureBox_NhanVien.Image = Image.FromFile(duongdan.ToString());
                pictureBox_NhanVien.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox_NhanVien.BorderStyle = BorderStyle.Fixed3D;
                pictureBox_NhanVien.SizeMode = PictureBoxSizeMode.StretchImage;

                //
                if (File.Exists(duongdan))
                {
                    string duongdantoi_TrongDebub = Application.StartupPath + "\\Resources\\" + txt_MaNhanVien.Text.Trim() + ".jpg";

                    if (File.Exists(duongdantoi_TrongDebub))
                    {
                        File.Delete(duongdantoi_TrongDebub);
                    }
                    File.Copy(duongdan, duongdantoi_TrongDebub);
                }
            }
            catch { }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_MaNhanVien.Text == string.Empty || txt_HoTen.Text == string.Empty || cmb_GioiTinh.Text == string.Empty || txt_CMND.Text == string.Empty || txt_SoDienThoai.Text == string.Empty || txt_DiaChi.Text == string.Empty || dANTOCComboBox.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!!!!");
                txt_HoTen.Focus();
            }
            else
            {
                try
                {
                    nHANVIENTableAdapter.InsertNhanVienMoi(txt_MaNhanVien.Text, txt_HoTen.Text, dANTOCComboBox.SelectedValue.ToString(), tRINHDOComboBox.SelectedValue.ToString(), dateTimePicker2.Value.ToString(), cmb_GioiTinh.Text, txt_SoDienThoai.Text.Trim(), txt_CMND.Text.Trim(), txt_DiaChi.Text.Trim());
                    tAIKHOANNHANVIENTableAdapter.Insert(txt_MaNhanVien.Text, md5.EncryptString(txt_MatKhau.Text, "thikhanh05dhth1"), false);


                    tAIKHOAN_NHOMNHANVIENTableAdapter.Insert(txt_MaNhanVien.Text, nHOMNHANVIENComboBox.SelectedValue.ToString(), null);

                    MessageBox.Show("Thêm thành công!!!");

                    btn_Them.Enabled = true;
                    txt_HoTen.Text = string.Empty;
                    dateTimePicker2.Value = DateTime.Now;
                    cmb_GioiTinh.Text = string.Empty;
                    txt_CMND.Text = string.Empty;
                    dANTOCComboBox.Text = string.Empty;
                    nHOMNHANVIENComboBox.Text = string.Empty;
                    txt_SoDienThoai.Text = string.Empty;
                    tRINHDOComboBox.Text = string.Empty;
                    txt_DiaChi.Text = string.Empty;

                    auto_MaNhanVien();

                    if (pictureBox_NhanVien.Image != null)
                    {
                        pictureBox_NhanVien.Image.Dispose();
                        pictureBox_NhanVien.Image = null;
                    }
                }
                catch { }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = true;
            txt_HoTen.Text = string.Empty;
            dateTimePicker2.Value = DateTime.Now;
            cmb_GioiTinh.Text = string.Empty;
            txt_CMND.Text = string.Empty;
            dANTOCComboBox.Text = string.Empty;
            nHOMNHANVIENComboBox.Text = string.Empty;
            txt_SoDienThoai.Text = string.Empty;
            tRINHDOComboBox.Text = string.Empty;
            txt_DiaChi.Text = string.Empty;
        }
    }
}