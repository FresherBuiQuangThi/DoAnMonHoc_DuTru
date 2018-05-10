using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QL_DocGiaThuVien
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        MD5 md5 = new MD5();

        public int Check_User(string tenDN, string matkhauDN)
        {
            String username = (String)(tAIKHOANNHANVIENTableAdapter.KT_DangNhap(tenDN, md5.EncryptString(matkhauDN, "thikhanh05dhth1")));
            if (String.IsNullOrEmpty(username))
                return 0;
            return 1;
        }
        private void mButtonLogin_Click(object sender, EventArgs e)
        {
            if (this.txt_TenDangNhap.Text.Trim() == string.Empty || this.txt_MatKhau.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Tên Đăng nhập và Mật khẩu không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_TenDangNhap.Focus();
            }
            else
            {
                if (this.txt_MatKhau.Text.Trim().Length < 6)
                {
                    MessageBox.Show("Mật Khẩu phải chứa ít nhất 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Check_User(txt_TenDangNhap.Text, txt_MatKhau.Text) == 1)
                    {
                        tAIKHOANNHANVIENTableAdapter.UpdateHoatDong(true, txt_TenDangNhap.Text.ToUpper());
                        MessageBox.Show("Đăng nhập thành công");

                        FormMain.name = txt_TenDangNhap.Text.ToUpper().Trim();
                        //frm_Home.name1 = txt_TenDangNhap.Text.ToUpper().Trim();
                        frm_DoiMatKhau.tenDNhap = txt_TenDangNhap.Text.ToUpper().Trim();
                        //frm_QuanLyMuonSach.manhanvien = txt_TenDangNhap.Text.ToUpper().Trim();
                        //frm_QuanLyTraSach.nhanvienNhan = txt_TenDangNhap.Text.ToUpper().Trim();
                        //frmThongKeSach.manhanvienlap = txt_TenDangNhap.Text.ToUpper().Trim();

                        FormMain frm = new FormMain();
                        //frm._TENDANGNHAP = _txtTenDangNhap;
                        frm.Show();
                        this.Visible = false;
                    }

                    else
                    {
                        MessageBox.Show("Tên đăng nhập và tài khoản không chính xác!!!");
                    }
                }

            }            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void tAIKHOANNHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAIKHOANNHANVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet);

        }

        private void FormLogin_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_DocGia_KhoaHocTongHopTPHCMDataSet.TAIKHOANNHANVIEN' table. You can move, or remove it, as needed.
            this.tAIKHOANNHANVIENTableAdapter.Fill(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.TAIKHOANNHANVIEN);

        }
    }
}