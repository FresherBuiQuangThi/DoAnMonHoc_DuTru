using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QL_DocGiaThuVien
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public static String name;
        private void btn_add_card_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_ThemTheDocGia frm = new frm_ThemTheDocGia();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btn_contol_staff_ItemClick(object sender, ItemClickEventArgs e)
        {
            ControlStaff controlstaff = new ControlStaff();
            controlstaff.Show();
        }

        private void btn_findCard_ItemClick(object sender, ItemClickEventArgs e)
        {
            FindReaderCard find = new FindReaderCard();
            find.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            BorrowBook borow = new BorrowBook();
            borow.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReturnBook returnbook = new ReturnBook();
            returnbook.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddStaffToGroup addstafftogroup = new AddStaffToGroup();
            addstafftogroup.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_DocGia_KhoaHocTongHopTPHCMDataSet.TAIKHOANNHANVIEN' table. You can move, or remove it, as needed.
            this.tAIKHOANNHANVIENTableAdapter.Fill(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.TAIKHOANNHANVIEN);

        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            BorrowBook borow = new BorrowBook();
            borow.Show();
        }

        private void btn_PhanNhomNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_PhanNhomNhanVien frm = new frm_PhanNhomNhanVien();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_PhanQuyenNhanVien frm = new frm_PhanQuyenNhanVien();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_DoiMatKhau frm = new frm_DoiMatKhau();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_ResetMatKhau frm = new frm_ResetMatKhau();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            tAIKHOANNHANVIENTableAdapter.UpdateHoatDong(false, name);
            FormLogin frm = new FormLogin();       
            frm.Show();
            this.Visible = false;
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_ThemNhanVien frm = new frm_ThemNhanVien();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_QuanLyNhanVien frm = new frm_QuanLyNhanVien();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_QuanLyTheDocGia frm = new frm_QuanLyTheDocGia();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}