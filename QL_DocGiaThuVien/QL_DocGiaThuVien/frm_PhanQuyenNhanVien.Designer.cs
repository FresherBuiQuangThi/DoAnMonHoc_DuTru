namespace QL_DocGiaThuVien
{
    partial class frm_PhanQuyenNhanVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nHOMNHANVIENDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.phanQuyen_ManHinhDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHOMNHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_DocGia_KhoaHocTongHopTPHCMDataSet = new QL_DocGiaThuVien.QL_DocGia_KhoaHocTongHopTPHCMDataSet();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.phanQuyen_ManHinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHOMNHANVIENTableAdapter = new QL_DocGiaThuVien.QL_DocGia_KhoaHocTongHopTPHCMDataSetTableAdapters.NHOMNHANVIENTableAdapter();
            this.tableAdapterManager = new QL_DocGiaThuVien.QL_DocGia_KhoaHocTongHopTPHCMDataSetTableAdapters.TableAdapterManager();
            this.mANHINHTableAdapter = new QL_DocGiaThuVien.QL_DocGia_KhoaHocTongHopTPHCMDataSetTableAdapters.MANHINHTableAdapter();
            this.pHANQUYENNHANVIENTableAdapter = new QL_DocGiaThuVien.QL_DocGia_KhoaHocTongHopTPHCMDataSetTableAdapters.PHANQUYENNHANVIENTableAdapter();
            this.mANHINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHANQUYENNHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phanQuyen_ManHinhTableAdapter = new QL_DocGiaThuVien.QL_DocGia_KhoaHocTongHopTPHCMDataSetTableAdapters.PhanQuyen_ManHinhTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNHANVIENDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyen_ManHinhDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyen_ManHinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANHINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHANQUYENNHANVIENBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1299, 673);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Colonna MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(424, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Phân Quyền Màn Hình Chức Năng";
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackgroundImage = global::QL_DocGiaThuVien.Properties.Resources.saa;
            this.btn_Luu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Luu.Image = global::QL_DocGiaThuVien.Properties.Resources.saa;
            this.btn_Luu.Location = new System.Drawing.Point(16, 3);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 69);
            this.btn_Luu.TabIndex = 15;
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nHOMNHANVIENDataGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 595);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhóm Nhân Viên:";
            // 
            // nHOMNHANVIENDataGridView
            // 
            this.nHOMNHANVIENDataGridView.AllowUserToAddRows = false;
            this.nHOMNHANVIENDataGridView.AutoGenerateColumns = false;
            this.nHOMNHANVIENDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nHOMNHANVIENDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.nHOMNHANVIENDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nHOMNHANVIENDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.nHOMNHANVIENDataGridView.DataSource = this.nHOMNHANVIENBindingSource;
            this.nHOMNHANVIENDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nHOMNHANVIENDataGridView.Location = new System.Drawing.Point(3, 17);
            this.nHOMNHANVIENDataGridView.Name = "nHOMNHANVIENDataGridView";
            this.nHOMNHANVIENDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nHOMNHANVIENDataGridView.Size = new System.Drawing.Size(638, 575);
            this.nHOMNHANVIENDataGridView.TabIndex = 0;
            this.nHOMNHANVIENDataGridView.SelectionChanged += new System.EventHandler(this.nHOMNHANVIENDataGridView_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.phanQuyen_ManHinhDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 595);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Màn hình chức năng:";
            // 
            // phanQuyen_ManHinhDataGridView
            // 
            this.phanQuyen_ManHinhDataGridView.AllowUserToAddRows = false;
            this.phanQuyen_ManHinhDataGridView.AutoGenerateColumns = false;
            this.phanQuyen_ManHinhDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.phanQuyen_ManHinhDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.phanQuyen_ManHinhDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phanQuyen_ManHinhDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.phanQuyen_ManHinhDataGridView.DataSource = this.phanQuyen_ManHinhBindingSource;
            this.phanQuyen_ManHinhDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phanQuyen_ManHinhDataGridView.Location = new System.Drawing.Point(3, 17);
            this.phanQuyen_ManHinhDataGridView.Name = "phanQuyen_ManHinhDataGridView";
            this.phanQuyen_ManHinhDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.phanQuyen_ManHinhDataGridView.Size = new System.Drawing.Size(649, 575);
            this.phanQuyen_ManHinhDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNhomNV";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Nhóm Nhân Viên";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenNhomNV";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Nhóm Nhân Viên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ghi Chú";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // nHOMNHANVIENBindingSource
            // 
            this.nHOMNHANVIENBindingSource.DataMember = "NHOMNHANVIEN";
            this.nHOMNHANVIENBindingSource.DataSource = this.qL_DocGia_KhoaHocTongHopTPHCMDataSet;
            // 
            // qL_DocGia_KhoaHocTongHopTPHCMDataSet
            // 
            this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.DataSetName = "QL_DocGia_KhoaHocTongHopTPHCMDataSet";
            this.qL_DocGia_KhoaHocTongHopTPHCMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaManHinh";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mã Màn Hình";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TenManHinh";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tên Màn Hình";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "XetQuyen";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Xét Quyền";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // phanQuyen_ManHinhBindingSource
            // 
            this.phanQuyen_ManHinhBindingSource.DataMember = "PhanQuyen_ManHinh";
            this.phanQuyen_ManHinhBindingSource.DataSource = this.qL_DocGia_KhoaHocTongHopTPHCMDataSet;
            // 
            // nHOMNHANVIENTableAdapter
            // 
            this.nHOMNHANVIENTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.MANHINHTableAdapter = this.mANHINHTableAdapter;
            this.tableAdapterManager.NGONNGUSACHTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHAXUATBANTableAdapter = null;
            this.tableAdapterManager.NHOMNGANHTableAdapter = null;
            this.tableAdapterManager.NHOMNHANVIENTableAdapter = this.nHOMNHANVIENTableAdapter;
            this.tableAdapterManager.PHANQUYENNHANVIENTableAdapter = this.pHANQUYENNHANVIENTableAdapter;
            this.tableAdapterManager.PHIEUMUONTableAdapter = null;
            this.tableAdapterManager.PHIEUTRATableAdapter = null;
            this.tableAdapterManager.QUOCTICHTableAdapter = null;
            this.tableAdapterManager.TACGIASACHTableAdapter = null;
            this.tableAdapterManager.TAIKHOAN_NHOMNHANVIENTableAdapter = null;
            this.tableAdapterManager.TAIKHOANNHANVIENTableAdapter = null;
            this.tableAdapterManager.THETHUVIENTableAdapter = null;
            this.tableAdapterManager.THONGTINSACHTableAdapter = null;
            this.tableAdapterManager.TRINHDOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QL_DocGiaThuVien.QL_DocGia_KhoaHocTongHopTPHCMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XULYVIPHAMTableAdapter = null;
            // 
            // mANHINHTableAdapter
            // 
            this.mANHINHTableAdapter.ClearBeforeFill = true;
            // 
            // pHANQUYENNHANVIENTableAdapter
            // 
            this.pHANQUYENNHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // mANHINHBindingSource
            // 
            this.mANHINHBindingSource.DataMember = "MANHINH";
            this.mANHINHBindingSource.DataSource = this.qL_DocGia_KhoaHocTongHopTPHCMDataSet;
            // 
            // pHANQUYENNHANVIENBindingSource
            // 
            this.pHANQUYENNHANVIENBindingSource.DataMember = "PHANQUYENNHANVIEN";
            this.pHANQUYENNHANVIENBindingSource.DataSource = this.qL_DocGia_KhoaHocTongHopTPHCMDataSet;
            // 
            // phanQuyen_ManHinhTableAdapter
            // 
            this.phanQuyen_ManHinhTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Luu);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1299, 78);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1299, 595);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(644, 595);
            this.panel4.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(644, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(655, 595);
            this.panel5.TabIndex = 16;
            // 
            // frm_PhanQuyenNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 673);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_PhanQuyenNhanVien";
            this.Text = "Phân quyền nhân viên";
            this.Load += new System.EventHandler(this.frm_PhanQuyenNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNHANVIENDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyen_ManHinhDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DocGia_KhoaHocTongHopTPHCMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyen_ManHinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANHINHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHANQUYENNHANVIENBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private QL_DocGia_KhoaHocTongHopTPHCMDataSet qL_DocGia_KhoaHocTongHopTPHCMDataSet;
        private System.Windows.Forms.BindingSource nHOMNHANVIENBindingSource;
        private QL_DocGia_KhoaHocTongHopTPHCMDataSetTableAdapters.NHOMNHANVIENTableAdapter nHOMNHANVIENTableAdapter;
        private QL_DocGia_KhoaHocTongHopTPHCMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView nHOMNHANVIENDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private QL_DocGia_KhoaHocTongHopTPHCMDataSetTableAdapters.MANHINHTableAdapter mANHINHTableAdapter;
        private System.Windows.Forms.BindingSource mANHINHBindingSource;
        private QL_DocGia_KhoaHocTongHopTPHCMDataSetTableAdapters.PHANQUYENNHANVIENTableAdapter pHANQUYENNHANVIENTableAdapter;
        private System.Windows.Forms.BindingSource pHANQUYENNHANVIENBindingSource;
        private System.Windows.Forms.BindingSource phanQuyen_ManHinhBindingSource;
        private QL_DocGia_KhoaHocTongHopTPHCMDataSetTableAdapters.PhanQuyen_ManHinhTableAdapter phanQuyen_ManHinhTableAdapter;
        private System.Windows.Forms.DataGridView phanQuyen_ManHinhDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
    }
}