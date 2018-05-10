namespace QL_DocGiaThuVien
{
    partial class FindReaderCard
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
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_find_reader_card = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Mathe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaVachThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(192, 72);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(141, 20);
            this.textEdit1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(136, 75);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mã Thẻ ";
            // 
            // btn_find_reader_card
            // 
            this.btn_find_reader_card.Location = new System.Drawing.Point(364, 107);
            this.btn_find_reader_card.Name = "btn_find_reader_card";
            this.btn_find_reader_card.Size = new System.Drawing.Size(75, 23);
            this.btn_find_reader_card.TabIndex = 2;
            this.btn_find_reader_card.Text = "Tìm kiếm";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(136, 113);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Mã Thẻ ";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(192, 110);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(141, 20);
            this.textEdit2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mathe,
            this.MaVachThe,
            this.LoaiThe,
            this.MaDocGia,
            this.NgayLam,
            this.HanSD});
            this.dataGridView1.Location = new System.Drawing.Point(12, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // Mathe
            // 
            this.Mathe.HeaderText = "Mã thẻ";
            this.Mathe.Name = "Mathe";
            // 
            // MaVachThe
            // 
            this.MaVachThe.HeaderText = "Mã Vạch";
            this.MaVachThe.Name = "MaVachThe";
            // 
            // LoaiThe
            // 
            this.LoaiThe.HeaderText = "Loại thẻ";
            this.LoaiThe.Name = "LoaiThe";
            // 
            // MaDocGia
            // 
            this.MaDocGia.HeaderText = "Mã đọc giả";
            this.MaDocGia.Name = "MaDocGia";
            // 
            // NgayLam
            // 
            this.NgayLam.HeaderText = "Ngày làm thẻ";
            this.NgayLam.Name = "NgayLam";
            // 
            // HanSD
            // 
            this.HanSD.HeaderText = "Hạn sử dụng";
            this.HanSD.Name = "HanSD";
            // 
            // FindReaderCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 340);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.btn_find_reader_card);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit1);
            this.Name = "FindReaderCard";
            this.Text = "Tìm kiếm thẻ đọc giả";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_find_reader_card;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mathe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVachThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanSD;
    }
}