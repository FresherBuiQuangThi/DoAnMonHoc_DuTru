namespace QL_DocGiaThuVien
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.txt_MatKhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.mButtonLogin = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.qL_DocGia_KhoaHocTongHopTPHCMDataSet = new QL_DocGiaThuVien.QL_DocGia_KhoaHocTongHopTPHCMDataSet();
            this.tAIKHOANNHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAIKHOANNHANVIENTableAdapter = new QL_DocGiaThuVien.QL_DocGia_KhoaHocTongHopTPHCMDataSetTableAdapters.TAIKHOANNHANVIENTableAdapter();
            this.tableAdapterManager = new QL_DocGiaThuVien.QL_DocGia_KhoaHocTongHopTPHCMDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANNHANVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(161, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên đăng nhập";
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Location = new System.Drawing.Point(253, 22);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(154, 20);
            this.txt_TenDangNhap.TabIndex = 1;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(253, 60);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Properties.UseSystemPasswordChar = true;
            this.txt_MatKhau.Size = new System.Drawing.Size(154, 20);
            this.txt_MatKhau.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(161, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // mButtonLogin
            // 
            this.mButtonLogin.Location = new System.Drawing.Point(219, 118);
            this.mButtonLogin.Name = "mButtonLogin";
            this.mButtonLogin.Size = new System.Drawing.Size(75, 23);
            this.mButtonLogin.TabIndex = 4;
            this.mButtonLogin.Text = "Đăng nhập";
            this.mButtonLogin.Click += new System.EventHandler(this.mButtonLogin_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(310, 86);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(97, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Quên mật khẩu ?";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(332, 118);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Thoát";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // qL_DocGia_KhoaHocTongHopTPHCMDataSet
            // 
            this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.DataSetName = "QL_DocGia_KhoaHocTongHopTPHCMDataSet";
            this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAIKHOANNHANVIENBindingSource
            // 
            this.tAIKHOANNHANVIENBindingSource.DataMember = "TAIKHOANNHANVIEN";
            this.tAIKHOANNHANVIENBindingSource.DataSource = this.qL_DocGia_KhoaHocTongHopTPHCMDataSet;
            // 
            // tAIKHOANNHANVIENTableAdapter
            // 
            this.tAIKHOANNHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_PHIEUMUONTableAdapter = null;
            this.tableAdapterManager.CT_PHIEUTRATableAdapter = null;
            this.tableAdapterManager.CT_XULYVIPHAMTableAdapter = null;
            this.tableAdapterManager.DANTOCTableAdapter = null;
            this.tableAdapterManager.DOCGIATableAdapter = null;
            this.tableAdapterManager.HANHVIVIPHAMTableAdapter = null;
            this.tableAdapterManager.LOAISACHTableAdapter = null;
            this.tableAdapterManager.LOAITHETableAdapter = null;
            this.tableAdapterManager.MANHINHTableAdapter = null;
            this.tableAdapterManager.NGONNGUSACHTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHAXUATBANTableAdapter = null;
            this.tableAdapterManager.NHOMNGANHTableAdapter = null;
            this.tableAdapterManager.NHOMNHANVIENTableAdapter = null;
            this.tableAdapterManager.PHANQUYENNHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUMUONTableAdapter = null;
            this.tableAdapterManager.PHIEUTRATableAdapter = null;
            this.tableAdapterManager.QUOCTICHTableAdapter = null;
            this.tableAdapterManager.TACGIASACHTableAdapter = null;
            this.tableAdapterManager.TAIKHOAN_NHOMNHANVIENTableAdapter = null;
            this.tableAdapterManager.TAIKHOANNHANVIENTableAdapter = this.tAIKHOANNHANVIENTableAdapter;
            this.tableAdapterManager.THETHUVIENTableAdapter = null;
            this.tableAdapterManager.THONGTINSACHTableAdapter = null;
            this.tableAdapterManager.TRINHDOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QL_DocGiaThuVien.QL_DocGia_KhoaHocTongHopTPHCMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XULYVIPHAMTableAdapter = null;
            // 
            // FormLogin
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 162);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.mButtonLogin);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_TenDangNhap);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLogin";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.FormLogin_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANNHANVIENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_TenDangNhap;
        private DevExpress.XtraEditors.TextEdit txt_MatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton mButtonLogin;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private QL_DocGia_KhoaHocTongHopTPHCMDataSet qL_DocGia_KhoaHocTongHopTPHCMDataSet;
        private System.Windows.Forms.BindingSource tAIKHOANNHANVIENBindingSource;
        private QL_DocGia_KhoaHocTongHopTPHCMDataSetTableAdapters.TAIKHOANNHANVIENTableAdapter tAIKHOANNHANVIENTableAdapter;
        private QL_DocGia_KhoaHocTongHopTPHCMDataSetTableAdapters.TableAdapterManager tableAdapterManager;


    }
}