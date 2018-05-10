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
    public partial class frm_PhanNhomNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frm_PhanNhomNhanVien()
        {
            InitializeComponent();
        }

        private void frm_PhanNhomNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_DocGia_KhoaHocTongHopTPHCMDataSet.TAIKHOANNHANVIEN' table. You can move, or remove it, as needed.
            this.tAIKHOANNHANVIENTableAdapter.Fill(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.TAIKHOANNHANVIEN);
            // TODO: This line of code loads data into the 'qL_DocGia_KhoaHocTongHopTPHCMDataSet.NHOMNHANVIEN' table. You can move, or remove it, as needed.
            this.nHOMNHANVIENTableAdapter.Fill(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.NHOMNHANVIEN);
            // TODO: This line of code loads data into the 'qL_DocGia_KhoaHocTongHopTPHCMDataSet.TAIKHOAN_NHOMNHANVIEN' table. You can move, or remove it, as needed.
            this.tAIKHOAN_NHOMNHANVIENTableAdapter.Fill(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.TAIKHOAN_NHOMNHANVIEN, nHOMNHANVIENComboBox.SelectedValue.ToString());

        }

        private void nHOMNHANVIENComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.tAIKHOAN_NHOMNHANVIENTableAdapter.Fill(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.TAIKHOAN_NHOMNHANVIEN, nHOMNHANVIENComboBox.SelectedValue.ToString());
            }
            catch { }
        }

        private void btn_TraiQuaPhai_Click(object sender, EventArgs e)
        {
            try
            {
                this.tAIKHOAN_NHOMNHANVIENTableAdapter.InsertQuery(tAIKHOANNHANVIENDataGridView.CurrentRow.Cells[0].Value.ToString(), nHOMNHANVIENComboBox.SelectedValue.ToString(), "");
                this.tAIKHOAN_NHOMNHANVIENTableAdapter.Fill(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.TAIKHOAN_NHOMNHANVIEN, nHOMNHANVIENComboBox.SelectedValue.ToString());

            }
            catch { }
        }

        private void btn_PhaiQuaTrai_Click(object sender, EventArgs e)
        {
            try
            {
                tAIKHOAN_NHOMNHANVIENTableAdapter.DeleteQuery(tAIKHOAN_NHOMNHANVIENDataGridView.CurrentRow.Cells[0].Value.ToString(), nHOMNHANVIENComboBox.SelectedValue.ToString());
                this.tAIKHOAN_NHOMNHANVIENTableAdapter.Fill(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.TAIKHOAN_NHOMNHANVIEN, nHOMNHANVIENComboBox.SelectedValue.ToString());
            }
            catch { }
        }
    }
}