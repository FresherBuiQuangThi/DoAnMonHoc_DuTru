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
    public partial class frm_PhanQuyenNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frm_PhanQuyenNhanVien()
        {
            InitializeComponent();
        }

        private void frm_PhanQuyenNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_DocGia_KhoaHocTongHopTPHCMDataSet.PHANQUYENNHANVIEN' table. You can move, or remove it, as needed.
            this.pHANQUYENNHANVIENTableAdapter.Fill(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.PHANQUYENNHANVIEN);
            try
            {
                // TODO: This line of code loads data into the 'qL_DocGia_KhoaHocTongHopTPHCMDataSet.NHOMNHANVIEN' table. You can move, or remove it, as needed.
                this.nHOMNHANVIENTableAdapter.Fill(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.NHOMNHANVIEN);

                // TODO: This line of code loads data into the 'qL_DocGia_KhoaHocTongHopTPHCMDataSet.PhanQuyen_ManHinh' table. You can move, or remove it, as needed.
                this.phanQuyen_ManHinhTableAdapter.FillBy(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.PhanQuyen_ManHinh, nHOMNHANVIENDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch { }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string nhomNguoiDung = nHOMNHANVIENDataGridView.CurrentRow.Cells[0].Value.ToString();

            DataTable table = new DataTable("temp");
            table.Columns.Add(new DataColumn("mamanhinh", typeof(string)));
            table.Columns.Add(new DataColumn("tenmanhinh", typeof(string)));
            table.Columns.Add(new DataColumn("coquyen", typeof(bool)));


            foreach (DataGridViewRow item in phanQuyen_ManHinhDataGridView.Rows)
            {
                try
                {
                    table.Rows.Add(item.Cells[0].Value.ToString(), item.Cells[1].Value.ToString(), item.Cells[2].Value);
                }
                catch { }
            }
            foreach (DataRow item in table.Rows)
            {
                try
                {
                    if (phanQuyen_ManHinhTableAdapter.Ktra_PhanQuyen(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.PhanQuyen_ManHinh, nhomNguoiDung, item[0].ToString()) == 0)
                    {
                        try
                        {
                            pHANQUYENNHANVIENTableAdapter.InsertTablePhanQuyenNhanVien(nhomNguoiDung, item[0].ToString(),(bool)(item[2]));
                        }
                        catch { }
                        try
                        {
                            pHANQUYENNHANVIENTableAdapter.InsertTablePhanQuyenNhanVien(nhomNguoiDung, item[0].ToString(), false);
                        }
                        catch { }
                    }
                    else
                    {
                        pHANQUYENNHANVIENTableAdapter.UpdateQuery((item[2] == null) ? false : (bool)(item[2]), nhomNguoiDung, item[0].ToString());
                    }
                }
                catch
                { }
            }
            this.phanQuyen_ManHinhTableAdapter.FillBy(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.PhanQuyen_ManHinh, nHOMNHANVIENDataGridView.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show("Lưu Thành Công!!!");
        }

        private void nHOMNHANVIENDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.phanQuyen_ManHinhTableAdapter.FillBy(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.PhanQuyen_ManHinh, nHOMNHANVIENDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch { }
        }
    }
}