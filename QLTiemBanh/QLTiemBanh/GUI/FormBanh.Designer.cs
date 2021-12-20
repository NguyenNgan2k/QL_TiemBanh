namespace QLTiemBanh.GUI
{
    partial class FormBanh
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
            this.bntThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbMaB = new System.Windows.Forms.ComboBox();
            this.bntHuy = new System.Windows.Forms.Button();
            this.bntTim = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenB = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtMaB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataBanh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntXoa = new System.Windows.Forms.Button();
            this.bntSua = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBanh)).BeginInit();
            this.SuspendLayout();
            // 
            // bntThoat
            // 
            this.bntThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntThoat.Location = new System.Drawing.Point(671, 164);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(85, 28);
            this.bntThoat.TabIndex = 14;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbMaB);
            this.groupBox2.Controls.Add(this.bntHuy);
            this.groupBox2.Controls.Add(this.bntTim);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(45, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 67);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm nhanh";
            // 
            // cbbMaB
            // 
            this.cbbMaB.FormattingEnabled = true;
            this.cbbMaB.Location = new System.Drawing.Point(115, 25);
            this.cbbMaB.Name = "cbbMaB";
            this.cbbMaB.Size = new System.Drawing.Size(178, 21);
            this.cbbMaB.TabIndex = 4;
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
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã bánh:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.txtTenB);
            this.groupBox1.Controls.Add(this.txtDVT);
            this.groupBox1.Controls.Add(this.txtMaB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 95);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung:";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(397, 50);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(178, 20);
            this.txtGia.TabIndex = 1;
            // 
            // txtTenB
            // 
            this.txtTenB.Location = new System.Drawing.Point(115, 46);
            this.txtTenB.Name = "txtTenB";
            this.txtTenB.Size = new System.Drawing.Size(178, 20);
            this.txtTenB.TabIndex = 1;
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(397, 18);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(178, 20);
            this.txtDVT.TabIndex = 1;
            // 
            // txtMaB
            // 
            this.txtMaB.Location = new System.Drawing.Point(115, 18);
            this.txtMaB.Name = "txtMaB";
            this.txtMaB.Size = new System.Drawing.Size(178, 20);
            this.txtMaB.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đơn giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 25);
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
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên bánh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bánh:";
            // 
            // dataBanh
            // 
            this.dataBanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataBanh.Location = new System.Drawing.Point(112, 208);
            this.dataBanh.Name = "dataBanh";
            this.dataBanh.Size = new System.Drawing.Size(531, 210);
            this.dataBanh.TabIndex = 11;
            this.dataBanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBanh_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maBanh";
            this.Column1.HeaderText = "Mã bánh";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenBanh";
            this.Column2.HeaderText = "Tên bánh";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "dvt";
            this.Column3.HeaderText = "Đơn vị tính";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "donGia";
            this.Column4.HeaderText = "Đơn giá ";
            this.Column4.Name = "Column4";
            // 
            // bntXoa
            // 
            this.bntXoa.Image = global::QLTiemBanh.Properties.Resources.delete;
            this.bntXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntXoa.Location = new System.Drawing.Point(671, 115);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(85, 29);
            this.bntXoa.TabIndex = 15;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = true;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // bntSua
            // 
            this.bntSua.Image = global::QLTiemBanh.Properties.Resources.edit;
            this.bntSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntSua.Location = new System.Drawing.Point(671, 69);
            this.bntSua.Name = "bntSua";
            this.bntSua.Size = new System.Drawing.Size(85, 26);
            this.bntSua.TabIndex = 16;
            this.bntSua.Text = "Sửa";
            this.bntSua.UseVisualStyleBackColor = true;
            this.bntSua.Click += new System.EventHandler(this.bntSua_Click);
            // 
            // bntThem
            // 
            this.bntThem.Image = global::QLTiemBanh.Properties.Resources.add;
            this.bntThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntThem.Location = new System.Drawing.Point(671, 21);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(85, 28);
            this.bntThem.TabIndex = 17;
            this.bntThem.Text = "Thêm";
            this.bntThem.UseVisualStyleBackColor = true;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // FormBanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.bntXoa);
            this.Controls.Add(this.bntSua);
            this.Controls.Add(this.bntThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataBanh);
            this.Name = "FormBanh";
            this.Text = "Quản lý bánh";
            this.Load += new System.EventHandler(this.FormBanh_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button bntSua;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbMaB;
        private System.Windows.Forms.Button bntHuy;
        private System.Windows.Forms.Button bntTim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenB;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtMaB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataBanh;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}