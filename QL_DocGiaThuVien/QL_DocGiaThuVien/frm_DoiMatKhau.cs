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

namespace QL_DocGiaThuVien
{
    public partial class frm_DoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frm_DoiMatKhau()
        {
            InitializeComponent();
        }
        public static String tenDNhap;
        MD5 md5 = new MD5();
        private void btn_DongY_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_MatKhauCu.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu cũ !!!");
                }
                else
                {
                    string matkhaucu = (String)tAIKHOANNHANVIENTableAdapter.GetMatKhau_OLD(txt_TenDN.Text);
                    string matkhaucu1 = md5.EncryptString(txt_MatKhauCu.Text, "thikhanh05dhth1");
                    if (matkhaucu != matkhaucu1)
                    {
                        MessageBox.Show("Bạn nhập sai mật khẩu cũ !!!");
                        txt_MatKhauCu.Focus();
                    }
                    else
                    {
                        if (txt_MatKhauMoi.Text == string.Empty || txt_NhapLaiMK.Text == string.Empty)
                        {
                            MessageBox.Show("Bạn hãy Nhập cả 2 khung nhé !!!");

                        }
                        else
                        {
                            if (this.txt_MatKhauMoi.Text.Trim().Length < 6)
                            {
                                MessageBox.Show("Mật Khẩu phải chứa ít nhất 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txt_MatKhauMoi.Focus();
                            }
                            else
                            {
                                if (txt_MatKhauMoi.Text != txt_NhapLaiMK.Text)
                                {
                                    MessageBox.Show("Mật khẩu mới không khớp !!!");
                                    txt_NhapLaiMK.Focus();
                                }
                                else
                                {
                                    tAIKHOANNHANVIENTableAdapter.Update_MatKhau(md5.EncryptString(txt_MatKhauMoi.Text, "thikhanh05dhth1"), txt_TenDN.Text);
                                    MessageBox.Show("Đổi mật khẩu thành công !!!");
                                    btn_DongY.Enabled = false;
                                }
                            }
                        }
                    }


                }

            }
            catch { MessageBox.Show("Đổi mật khẩu thất bại !!!"); }
        }

        private void frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            txt_TenDN.Text = tenDNhap;
            // TODO: This line of code loads data into the 'qL_DocGia_KhoaHocTongHopTPHCMDataSet.TAIKHOANNHANVIEN' table. You can move, or remove it, as needed.
            this.tAIKHOANNHANVIENTableAdapter.Fill(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.TAIKHOANNHANVIEN);

        }
    }
}