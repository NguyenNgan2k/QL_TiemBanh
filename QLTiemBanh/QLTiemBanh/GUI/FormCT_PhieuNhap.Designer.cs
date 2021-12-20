namespace QLTiemBanh.GUI
{
    partial class FormCT_PhieuNhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bntHuy = new System.Windows.Forms.Button();
            this.cbbMa = new System.Windows.Forms.ComboBox();
            this.bntTim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataCT_PhieuNhap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntXoa = new System.Windows.Forms.Button();
            this.bntSua = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbMaNL = new System.Windows.Forms.ComboBox();
            this.cbbMapn = new System.Windows.Forms.ComboBox();
            this.txtsolg = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCT_PhieuNhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.dataCT_PhieuNhap);
            this.panel1.Controls.Add(this.bntXoa);
            this.panel1.Controls.Add(this.bntSua);
            this.panel1.Controls.Add(this.bntThem);
            this.panel1.Controls.Add(this.bntThoat);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bntHuy);
            this.groupBox2.Controls.Add(this.cbbMa);
            this.groupBox2.Controls.Add(this.bntTim);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(87, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 50);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm nhanh";
            // 
            // bntHuy
            // 
            this.bntHuy.Location = new System.Drawing.Point(414, 11);
            this.bntHuy.Name = "bntHuy";
            this.bntHuy.Size = new System.Drawing.Size(89, 29);
            this.bntHuy.TabIndex = 22;
            this.bntHuy.Text = "Hủy";
            this.bntHuy.UseVisualStyleBackColor = true;
            this.bntHuy.Click += new System.EventHandler(this.bntHuy_Click);
            // 
            // cbbMa
            // 
            this.cbbMa.FormattingEnabled = true;
            this.cbbMa.Location = new System.Drawing.Point(115, 16);
            this.cbbMa.Name = "cbbMa";
            this.cbbMa.Size = new System.Drawing.Size(178, 21);
            this.cbbMa.TabIndex = 3;
            // 
            // bntTim
            // 
            this.bntTim.Image = global::QLTiemBanh.Properties.Resources.view;
            this.bntTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntTim.Location = new System.Drawing.Point(319, 11);
            this.bntTim.Name = "bntTim";
            this.bntTim.Size = new System.Drawing.Size(89, 29);
            this.bntTim.TabIndex = 21;
            this.bntTim.Text = "Tìm";
            this.bntTim.UseVisualStyleBackColor = true;
            this.bntTim.Click += new System.EventHandler(this.bntTim_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã phiếu nhập";
            // 
            // dataCT_PhieuNhap
            // 
            this.dataCT_PhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCT_PhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataCT_PhieuNhap.Location = new System.Drawing.Point(44, 239);
            this.dataCT_PhieuNhap.Name = "dataCT_PhieuNhap";
            this.dataCT_PhieuNhap.Size = new System.Drawing.Size(641, 186);
            this.dataCT_PhieuNhap.TabIndex = 20;
            this.dataCT_PhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCT_PhieuNhap_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maPN";
            this.Column1.HeaderText = "Mã phiếu nhập";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "maNL";
            this.Column2.HeaderText = "Mã nguyên liệu";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tenNL";
            this.Column3.HeaderText = "Tên nguyên liệu";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "tenDVT";
            this.Column4.HeaderText = "Đơn vị tính";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "dongiaNL";
            this.Column5.HeaderText = "Đơn giá";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "soLuongN";
            this.Column6.HeaderText = "Số lượng nhập";
            this.Column6.Name = "Column6";
            // 
            // bntXoa
            // 
            this.bntXoa.Image = global::QLTiemBanh.Properties.Resources.delete;
            this.bntXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntXoa.Location = new System.Drawing.Point(654, 143);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(89, 28);
            this.bntXoa.TabIndex = 17;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = true;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click_1);
            // 
            // bntSua
            // 
            this.bntSua.Image = global::QLTiemBanh.Properties.Resources.edit;
            this.bntSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntSua.Location = new System.Drawing.Point(654, 90);
            this.bntSua.Name = "bntSua";
            this.bntSua.Size = new System.Drawing.Size(89, 29);
            this.bntSua.TabIndex = 18;
            this.bntSua.Text = "Sửa";
            this.bntSua.UseVisualStyleBackColor = true;
            this.bntSua.Click += new System.EventHandler(this.bntSua_Click);
            // 
            // bntThem
            // 
            this.bntThem.Image = global::QLTiemBanh.Properties.Resources.add;
            this.bntThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntThem.Location = new System.Drawing.Point(654, 40);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(89, 29);
            this.bntThem.TabIndex = 19;
            this.bntThem.Text = "Thêm";
            this.bntThem.UseVisualStyleBackColor = true;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.Location = new System.Drawing.Point(654, 194);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(89, 29);
            this.bntThoat.TabIndex = 13;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbMaNL);
            this.groupBox1.Controls.Add(this.cbbMapn);
            this.groupBox1.Controls.Add(this.txtsolg);
            this.groupBox1.Controls.Add(this.txtDongia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(87, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 149);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung:";
            // 
            // cbbMaNL
            // 
            this.cbbMaNL.FormattingEnabled = true;
            this.cbbMaNL.Location = new System.Drawing.Point(115, 45);
            this.cbbMaNL.Name = "cbbMaNL";
            this.cbbMaNL.Size = new System.Drawing.Size(178, 21);
            this.cbbMaNL.TabIndex = 3;
            // 
            // cbbMapn
            // 
            this.cbbMapn.FormattingEnabled = true;
            this.cbbMapn.Location = new System.Drawing.Point(115, 17);
            this.cbbMapn.Name = "cbbMapn";
            this.cbbMapn.Size = new System.Drawing.Size(178, 21);
            this.cbbMapn.TabIndex = 2;
            // 
            // txtsolg
            // 
            this.txtsolg.Location = new System.Drawing.Point(115, 108);
            this.txtsolg.Name = "txtsolg";
            this.txtsolg.Size = new System.Drawing.Size(178, 20);
            this.txtsolg.TabIndex = 1;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(115, 80);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(178, 20);
            this.txtDongia.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Đơn giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nguyên liệu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // FormCT_PhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormCT_PhieuNhap";
            this.Text = "Chi tiết phiếu nhập";
            this.Load += new System.EventHandler(this.FormCT_PhieuNhap_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCT_PhieuNhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsolg;
        private System.Windows.Forms.ComboBox cbbMapn;
        private System.Windows.Forms.DataGridView dataCT_PhieuNhap;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button bntSua;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.Button bntTim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bntHuy;
        private System.Windows.Forms.ComboBox cbbMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ComboBox cbbMaNL;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.Label label6;
    }
}