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
    public partial class frm_QuanLyNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frm_QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void nHOMNHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHOMNHANVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet);

        }

        private void frm_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_DocGia_KhoaHocTongHopTPHCMDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.NHANVIEN);
            // TODO: This line of code loads data into the 'qL_DocGia_KhoaHocTongHopTPHCMDataSet.NHOMNHANVIEN' table. You can move, or remove it, as needed.
            this.nHOMNHANVIENTableAdapter.Fill(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.NHOMNHANVIEN);

        }

        private void hinh_NhanVien()
        {
            try
            {
                pictureBox_NhanVien.Image = null;

                string nhanVien = nHANVIENDataGridView.CurrentRow.Cells[0].Value.ToString().Trim();

                string temp = "\\" + nhanVien;

                pictureBox_NhanVien.Image = new Bitmap(Application.StartupPath + "\\Resources" + temp + ".jpg");

                pictureBox_NhanVien.SizeMode = PictureBoxSizeMode.CenterImage;

                pictureBox_NhanVien.BorderStyle = BorderStyle.Fixed3D;

                pictureBox_NhanVien.SizeMode = PictureBoxSizeMode.StretchImage;

                pictureBox_NhanVien.Width = 145; // xét chiều rộng

                pictureBox_NhanVien.Height = 150; // xét chiều dài
            }
            catch
            {

            }
        }
        private void pictureBox_NhanVien_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox_NhanVien.Image != null)
                {
                    pictureBox_NhanVien.Image.Dispose();
                    pictureBox_NhanVien.Image = null;
                }

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
                    string duongdantoi_TrongDebub = Application.StartupPath + "\\Resources\\" + nHANVIENDataGridView.CurrentRow.Cells[0].Value.ToString().Trim() + ".jpg";

                    if (File.Exists(duongdantoi_TrongDebub))
                    {
                        File.Delete(duongdantoi_TrongDebub);
                    }
                    File.Copy(duongdan, duongdantoi_TrongDebub);
                }
                hinh_NhanVien();
            }
            catch { }
        }

        private void nHANVIENDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nHANVIENDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                hinh_NhanVien();
                txt_TenDangNhap.Text = nHANVIENDataGridView.CurrentRow.Cells[0].Value.ToString();
                txt_HoTen.Text = nHANVIENDataGridView.CurrentRow.Cells[1].Value.ToString();
                dANTOCComboBox.SelectedValue = nHANVIENDataGridView.CurrentRow.Cells[2].Value.ToString();
                tRINHDOComboBox.SelectedValue = nHANVIENDataGridView.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker_NgaySinh.Value = (DateTime)nHANVIENDataGridView.CurrentRow.Cells[4].Value;
                cmb_GioiTinh.Text = nHANVIENDataGridView.CurrentRow.Cells[5].Value.ToString();
                txt_SoDT.Text = nHANVIENDataGridView.CurrentRow.Cells[6].Value.ToString();
                txt_SoCMND.Text = nHANVIENDataGridView.CurrentRow.Cells[7].Value.ToString();
                txt_DiaChi.Text = nHANVIENDataGridView.CurrentRow.Cells[8].Value.ToString();  
            }
            catch
            {
                txt_TenDangNhap.Text = string.Empty;
                txt_HoTen.Text = string.Empty;
                cHUCVUComboBox1.SelectedValue = string.Empty;
                dateTimePicker_NgaySinh.Value = DateTime.Now;
                cmb_GioiTinh.Text = string.Empty;
                txt_DiaChi.Text = string.Empty;
                txt_Email.Text = string.Empty;
                dANTOCComboBox.SelectedValue = string.Empty;
                tRINHDOComboBox.SelectedValue = string.Empty;
                dateTimePicker_NVL.Value = DateTime.Now;
                txt_SoCMND.Text = string.Empty;
                tINHTHANHComboBox.SelectedValue = string.Empty;
                txt_SoDT.Text = string.Empty;

                if (pictureBox_NhanVien.Image != null)
                {
                    pictureBox_NhanVien.Image.Dispose();
                    pictureBox_NhanVien.Image = null;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}