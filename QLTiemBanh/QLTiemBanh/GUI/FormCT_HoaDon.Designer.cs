namespace QLTiemBanh.GUI
{
    partial class FormCT_HoaDon
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
            this.dataCTHD = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntTim = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSLB = new System.Windows.Forms.TextBox();
            this.cbbMaHD = new System.Windows.Forms.ComboBox();
            this.cbbMaB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataCTHD)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataCTHD
            // 
            this.dataCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataCTHD.Location = new System.Drawing.Point(56, 203);
            this.dataCTHD.Name = "dataCTHD";
            this.dataCTHD.Size = new System.Drawing.Size(592, 150);
            this.dataCTHD.TabIndex = 0;
            this.dataCTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCTHD_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maBanh";
            this.Column1.HeaderText = "Mã bánh";
            this.Column1.Name = "Column1";
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
            this.Column3.DataPropertyName = "donGia";
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "soLuongB";
            this.Column4.HeaderText = "Số lượng bán";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "thanhTien";
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.Name = "Column5";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bntTim);
            this.panel1.Controls.Add(this.bntThoat);
            this.panel1.Controls.Add(this.bntXoa);
            this.panel1.Controls.Add(this.bntThem);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataCTHD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // bntTim
            // 
            this.bntTim.Image = global::QLTiemBanh.Properties.Resources.view;
            this.bntTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntTim.Location = new System.Drawing.Point(672, 39);
            this.bntTim.Name = "bntTim";
            this.bntTim.Size = new System.Drawing.Size(92, 28);
            this.bntTim.TabIndex = 15;
            this.bntTim.Text = "Hiển thị";
            this.bntTim.UseVisualStyleBackColor = true;
            this.bntTim.Click += new System.EventHandler(this.bntTim_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.Location = new System.Drawing.Point(672, 178);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(92, 29);
            this.bntThoat.TabIndex = 11;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.Image = global::QLTiemBanh.Properties.Resources.delete;
            this.bntXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntXoa.Location = new System.Drawing.Point(672, 128);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(92, 29);
            this.bntXoa.TabIndex = 12;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = true;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // bntThem
            // 
            this.bntThem.Image = global::QLTiemBanh.Properties.Resources.add;
            this.bntThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntThem.Location = new System.Drawing.Point(672, 83);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(92, 28);
            this.bntThem.TabIndex = 14;
            this.bntThem.Text = "Thêm";
            this.bntThem.UseVisualStyleBackColor = true;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSLB);
            this.groupBox1.Controls.Add(this.cbbMaHD);
            this.groupBox1.Controls.Add(this.cbbMaB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(56, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 147);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung:";
            // 
            // txtSLB
            // 
            this.txtSLB.Location = new System.Drawing.Point(115, 96);
            this.txtSLB.Name = "txtSLB";
            this.txtSLB.Size = new System.Drawing.Size(178, 20);
            this.txtSLB.TabIndex = 4;
            // 
            // cbbMaHD
            // 
            this.cbbMaHD.FormattingEnabled = true;
            this.cbbMaHD.Location = new System.Drawing.Point(115, 17);
            this.cbbMaHD.Name = "cbbMaHD";
            this.cbbMaHD.Size = new System.Drawing.Size(178, 21);
            this.cbbMaHD.TabIndex = 3;
            // 
            // cbbMaB
            // 
            this.cbbMaB.FormattingEnabled = true;
            this.cbbMaB.Location = new System.Drawing.Point(115, 54);
            this.cbbMaB.Name = "cbbMaB";
            this.cbbMaB.Size = new System.Drawing.Size(178, 21);
            this.cbbMaB.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số lượng bán:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã bánh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // FormCT_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormCT_HoaDon";
            this.Text = "Chi tiết hóa đơn";
            this.Load += new System.EventHandler(this.FormCT_HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCTHD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCTHD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbMaB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSLB;
        private System.Windows.Forms.ComboBox cbbMaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.Button bntTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}