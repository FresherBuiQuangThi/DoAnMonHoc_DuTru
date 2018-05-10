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
    public partial class frm_ResetMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frm_ResetMatKhau()
        {
            InitializeComponent();
        }
        MD5 md5 = new MD5();
        private void tAIKHOANNHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAIKHOANNHANVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet);

        }

        private void ResetMatKhau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_DocGia_KhoaHocTongHopTPHCMDataSet.TAIKHOANNHANVIEN' table. You can move, or remove it, as needed.
            this.tAIKHOANNHANVIENTableAdapter.Fill(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.TAIKHOANNHANVIEN);

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                string tendangnhap = tAIKHOANNHANVIENDataGridView.CurrentRow.Cells[0].Value.ToString();
                string matkhau = tAIKHOANNHANVIENDataGridView.CurrentRow.Cells[1].Value.ToString();

                tAIKHOANNHANVIENTableAdapter.Update_MatKhau(md5.EncryptString("123456", "thikhanh05dhth1"), tendangnhap);

                MessageBox.Show("Reset mật khẩu thành công!!!!");

                this.tAIKHOANNHANVIENTableAdapter.Fill(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.TAIKHOANNHANVIEN);
            }
            catch { MessageBox.Show("Reset mật khẩu thất bại!!!!"); }
        }
    }
}