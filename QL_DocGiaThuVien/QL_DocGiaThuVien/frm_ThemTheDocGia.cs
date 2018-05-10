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
    public partial class frm_ThemTheDocGia : DevExpress.XtraEditors.XtraForm
    {
        public frm_ThemTheDocGia()
        {
            InitializeComponent();
        }

        private void frm_ThemTheDocGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_DocGia_KhoaHocTongHopTPHCMDataSet.DOCGIA' table. You can move, or remove it, as needed.
            this.dOCGIATableAdapter.Fill(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.DOCGIA);

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dOCGIABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dOCGIABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}