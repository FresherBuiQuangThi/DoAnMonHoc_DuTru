namespace QL_DocGiaThuVien
{
    partial class frm_CauHinh
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
            this.pn_KetNoiCSDL = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pn_KetNoiCSDL
            // 
            this.pn_KetNoiCSDL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_KetNoiCSDL.Location = new System.Drawing.Point(0, 0);
            this.pn_KetNoiCSDL.Name = "pn_KetNoiCSDL";
            this.pn_KetNoiCSDL.Size = new System.Drawing.Size(418, 487);
            this.pn_KetNoiCSDL.TabIndex = 0;
            // 
            // frm_CauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 487);
            this.Controls.Add(this.pn_KetNoiCSDL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_CauHinh";
            this.Text = "Thông Tin Cấu Hình";
            this.Load += new System.EventHandler(this.frm_CauHinh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_KetNoiCSDL;

    }
}