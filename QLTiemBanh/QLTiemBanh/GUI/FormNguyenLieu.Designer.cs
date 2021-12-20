namespace QLTiemBanh.GUI
{
    partial class FormNguyenLieu
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
            this.bntThoat = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.bntSua = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbMaNL = new System.Windows.Forms.ComboBox();
            this.bntHuy = new System.Windows.Forms.Button();
            this.bntTim = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSLX = new System.Windows.Forms.TextBox();
            this.txtSLC = new System.Windows.Forms.TextBox();
            this.txtTenNL = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtMaNL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataNL = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNL)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bntThoat);
            this.panel1.Controls.Add(this.bntXoa);
            this.panel1.Controls.Add(this.bntSua);
            this.panel1.Controls.Add(this.bntThem);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataNL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // bntThoat
            // 
            this.bntThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntThoat.Location = new System.Drawing.Point(683, 173);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(85, 28);
            this.bntThoat.TabIndex = 7;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.Image = global::QLTiemBanh.Properties.Resources.delete;
            this.bntXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntXoa.Location = new System.Drawing.Point(683, 124);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(85, 29);
            this.bntXoa.TabIndex = 8;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = true;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // bntSua
            // 
            this.bntSua.Image = global::QLTiemBanh.Properties.Resources.edit;
            this.bntSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntSua.Location = new System.Drawing.Point(683, 78);
            this.bntSua.Name = "bntSua";
            this.bntSua.Size = new System.Drawing.Size(85, 26);
            this.bntSua.TabIndex = 9;
            this.bntSua.Text = "Sửa";
            this.bntSua.UseVisualStyleBackColor = true;
            this.bntSua.Click += new System.EventHandler(this.bntSua_Click);
            // 
            // bntThem
            // 
            this.bntThem.Image = global::QLTiemBanh.Properties.Resources.add;
            this.bntThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntThem.Location = new System.Drawing.Point(683, 30);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(85, 28);
            this.bntThem.TabIndex = 10;
            this.bntThem.Text = "Thêm";
            this.bntThem.UseVisualStyleBackColor = true;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbMaNL);
            this.groupBox2.Controls.Add(this.bntHuy);
            this.groupBox2.Controls.Add(this.bntTim);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(57, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 67);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm nhanh";
            // 
            // cbbMaNL
            // 
            this.cbbMaNL.FormattingEnabled = true;
            this.cbbMaNL.Location = new System.Drawing.Point(115, 25);
            this.cbbMaNL.Name = "cbbMaNL";
            this.cbbMaNL.Size = new System.Drawing.Size(178, 21);
            this.cbbMaNL.TabIndex = 4;
            // 
            // bntHuy
            // 
            this.bntHuy.Location = new System.Drawing.Point(464, 19);
            this.bntHuy.Name = "bntHuy";
            this.bntHuy.Size = new System.Drawing.Size(89, 27);
            this.bntHuy.TabIndex = 3;
            this.bntHuy.Text = "Hủy";
            this.bntHuy.UseVisualStyleBackColor = true;
            this.bntHuy.Click += new System.EventHandler(this.bntHuy_Click);
            // 
            // bntTim
            // 
            this.bntTim.Image = global::QLTiemBanh.Properties.Resources.view;
            this.bntTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntTim.Location = new System.Drawing.Point(331, 19);
            this.bntTim.Name = "bntTim";
            this.bntTim.Size = new System.Drawing.Size(89, 27);
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
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã nguyên liệu:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSLX);
            this.groupBox1.Controls.Add(this.txtSLC);
            this.groupBox1.Controls.Add(this.txtTenNL);
            this.groupBox1.Controls.Add(this.txtDVT);
            this.groupBox1.Controls.Add(this.txtMaNL);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(57, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 113);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung:";
            // 
            // txtSLX
            // 
            this.txtSLX.Location = new System.Drawing.Point(411, 48);
            this.txtSLX.Name = "txtSLX";
            this.txtSLX.Size = new System.Drawing.Size(178, 20);
            this.txtSLX.TabIndex = 2;
            // 
            // txtSLC
            // 
            this.txtSLC.Location = new System.Drawing.Point(411, 18);
            this.txtSLC.Name = "txtSLC";
            this.txtSLC.Size = new System.Drawing.Size(178, 20);
            this.txtSLC.TabIndex = 1;
            // 
            // txtTenNL
            // 
            this.txtTenNL.Location = new System.Drawing.Point(115, 46);
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.Size = new System.Drawing.Size(178, 20);
            this.txtTenNL.TabIndex = 1;
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(115, 77);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(178, 20);
            this.txtDVT.TabIndex = 1;
            // 
            // txtMaNL
            // 
            this.txtMaNL.Location = new System.Drawing.Point(115, 18);
            this.txtMaNL.Name = "txtMaNL";
            this.txtMaNL.Size = new System.Drawing.Size(178, 20);
            this.txtMaNL.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số  lượng xuất:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng còn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn vị tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nguyên liệu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nguyên liệu:";
            // 
            // dataNL
            // 
            this.dataNL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataNL.Location = new System.Drawing.Point(115, 228);
            this.dataNL.Name = "dataNL";
            this.dataNL.Size = new System.Drawing.Size(531, 210);
            this.dataNL.TabIndex = 1;
            this.dataNL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNL_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maNL";
            this.Column1.HeaderText = "Mã nguyên liệu";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenNL";
            this.Column2.HeaderText = "Tên nguyên liệu";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tenDVT";
            this.Column3.HeaderText = "Đơn vị tính";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "soLuongC";
            this.Column4.HeaderText = "Số lượng còn";
            this.Column4.Name = "Column4";
            // 
            // FormNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormNguyenLieu";
            this.Text = "Quản lý nguyên liệu";
            this.Load += new System.EventHandler(this.FormNguyenLieu_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataNL;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button bntSua;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbMaNL;
        private System.Windows.Forms.Button bntHuy;
        private System.Windows.Forms.Button bntTim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtMaNL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenNL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSLC;
        private System.Windows.Forms.TextBox txtSLX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}