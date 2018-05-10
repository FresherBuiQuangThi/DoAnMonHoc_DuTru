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
    public partial class frm_CauHinh : DevExpress.XtraEditors.XtraForm
    {
        public frm_CauHinh()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frm_CauHinh_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pn_KetNoiCSDL.Controls.Clear();
            UC_CauHinh uc_KetNoiCSDL = new UC_CauHinh();
            uc_KetNoiCSDL.Dock = DockStyle.Fill;
            pn_KetNoiCSDL.Controls.Add(uc_KetNoiCSDL);
            this.Visible = false;
        }
    }
}