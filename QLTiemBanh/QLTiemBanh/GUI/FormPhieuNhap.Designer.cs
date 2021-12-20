namespace QLTiemBanh.GUI
{
    partial class FormPhieuNhap
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
            this.dataPN = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChiTietPN = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.bntSua = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbMaPN = new System.Windows.Forms.ComboBox();
            this.bntHuy = new System.Windows.Forms.Button();
            this.bntTim = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtNhaCC = new System.Windows.Forms.TextBox();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataPN)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPN
            // 
            this.dataPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataPN.Location = new System.Drawing.Point(152, 238);
            this.dataPN.Name = "dataPN";
            this.dataPN.Size = new System.Drawing.Size(430, 150);
            this.dataPN.TabIndex = 0;
            this.dataPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPN_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maPN";
            this.Column1.HeaderText = "Mã phiếu nhập";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nhaCC";
            this.Column2.HeaderText = "Nhà cung cấp";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ngayLap";
            this.Column3.HeaderText = "Ngày lập";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChiTietPN);
            this.panel1.Controls.Add(this.bntThoat);
            this.panel1.Controls.Add(this.bntXoa);
            this.panel1.Controls.Add(this.bntSua);
            this.panel1.Controls.Add(this.bntThem);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataPN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
            // 
            // btnChiTietPN
            // 
            this.btnChiTietPN.Location = new System.Drawing.Point(663, 181);
            this.btnChiTietPN.Name = "btnChiTietPN";
            this.btnChiTietPN.Size = new System.Drawing.Size(110, 28);
            this.btnChiTietPN.TabIndex = 4;
            this.btnChiTietPN.Text = "Chi tiết phiếu nhập";
            this.btnChiTietPN.UseVisualStyleBackColor = true;
            this.btnChiTietPN.Click += new System.EventHandler(this.btnChiTietPN_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.Location = new System.Drawing.Point(663, 142);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(88, 28);
            this.bntThoat.TabIndex = 3;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.Image = global::QLTiemBanh.Properties.Resources.delete;
            this.bntXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntXoa.Location = new System.Drawing.Point(663, 103);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(88, 28);
            this.bntXoa.TabIndex = 3;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = true;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // bntSua
            // 
            this.bntSua.Image = global::QLTiemBanh.Properties.Resources.edit;
            this.bntSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntSua.Location = new System.Drawing.Point(663, 61);
            this.bntSua.Name = "bntSua";
            this.bntSua.Size = new System.Drawing.Size(88, 28);
            this.bntSua.TabIndex = 3;
            this.bntSua.Text = "Sửa";
            this.bntSua.UseVisualStyleBackColor = true;
            this.bntSua.Click += new System.EventHandler(this.bntSua_Click);
            // 
            // bntThem
            // 
            this.bntThem.Image = global::QLTiemBanh.Properties.Resources.add;
            this.bntThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntThem.Location = new System.Drawing.Point(663, 23);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(88, 28);
            this.bntThem.TabIndex = 3;
            this.bntThem.Text = "Thêm";
            this.bntThem.UseVisualStyleBackColor = true;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbMaPN);
            this.groupBox2.Controls.Add(this.bntHuy);
            this.groupBox2.Controls.Add(this.bntTim);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(106, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 67);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm nhanh";
            // 
            // cbbMaPN
            // 
            this.cbbMaPN.FormattingEnabled = true;
            this.cbbMaPN.Location = new System.Drawing.Point(115, 25);
            this.cbbMaPN.Name = "cbbMaPN";
            this.cbbMaPN.Size = new System.Drawing.Size(178, 21);
            this.cbbMaPN.TabIndex = 4;
            // 
            // bntHuy
            // 
            this.bntHuy.Location = new System.Drawing.Point(409, 19);
            this.bntHuy.Name = "bntHuy";
            this.bntHuy.Size = new System.Drawing.Size(88, 27);
            this.bntHuy.TabIndex = 3;
            this.bntHuy.Text = "Hủy";
            this.bntHuy.UseVisualStyleBackColor = true;
            this.bntHuy.Click += new System.EventHandler(this.bntHuy_Click);
            // 
            // bntTim
            // 
            this.bntTim.Image = global::QLTiemBanh.Properties.Resources.view;
            this.bntTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntTim.Location = new System.Drawing.Point(315, 19);
            this.bntTim.Name = "bntTim";
            this.bntTim.Size = new System.Drawing.Size(88, 28);
            this.bntTim.TabIndex = 2;
            this.bntTim.Text = "Tìm";
            this.bntTim.UseVisualStyleBackColor = true;
            this.bntTim.Click += new System.EventHandler(this.bntTim_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã phiếu nhập:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayLap);
            this.groupBox1.Controls.Add(this.txtNhaCC);
            this.groupBox1.Controls.Add(this.txtMaPN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(106, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung:";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(115, 72);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(178, 20);
            this.dtpNgayLap.TabIndex = 2;
            // 
            // txtNhaCC
            // 
            this.txtNhaCC.Location = new System.Drawing.Point(115, 46);
            this.txtNhaCC.Name = "txtNhaCC";
            this.txtNhaCC.Size = new System.Drawing.Size(178, 20);
            this.txtNhaCC.TabIndex = 1;
            // 
            // txtMaPN
            // 
            this.txtMaPN.Location = new System.Drawing.Point(115, 18);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(178, 20);
            this.txtMaPN.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày lập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhà cung cấp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu nhập:";
            // 
            // FormPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormPhieuNhap";
            this.Text = "Quản lý phiếu nhập";
            this.Load += new System.EventHandler(this.FormPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bntHuy;
        private System.Windows.Forms.Button bntTim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.TextBox txtNhaCC;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbMaPN;
        private System.Windows.Forms.Button btnChiTietPN;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button bntSua;
        private System.Windows.Forms.Button bntThem;
    }
}