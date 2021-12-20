namespace QLTiemBanh
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuNL = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBanh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHD = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bntDX = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNL,
            this.menuPN,
            this.menuBanh,
            this.menuHD});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuNL
            // 
            this.menuNL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuNL.Name = "menuNL";
            this.menuNL.Size = new System.Drawing.Size(162, 23);
            this.menuNL.Text = "Quản Lý Nguyên Liệu";
            this.menuNL.Click += new System.EventHandler(this.menuNL_Click);
            // 
            // menuPN
            // 
            this.menuPN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuPN.Name = "menuPN";
            this.menuPN.Size = new System.Drawing.Size(156, 23);
            this.menuPN.Text = "Quản Lý Phiếu Nhập";
            this.menuPN.Click += new System.EventHandler(this.menuPN_Click);
            // 
            // menuBanh
            // 
            this.menuBanh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuBanh.Name = "menuBanh";
            this.menuBanh.Size = new System.Drawing.Size(112, 23);
            this.menuBanh.Text = "Quản Lý Bánh";
            this.menuBanh.Click += new System.EventHandler(this.menuBanh_Click);
            // 
            // menuHD
            // 
            this.menuHD.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuHD.Name = "menuHD";
            this.menuHD.Size = new System.Drawing.Size(138, 23);
            this.menuHD.Text = "Quản Lý Hóa Đơn";
            this.menuHD.Click += new System.EventHandler(this.menuHD_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLTiemBanh.Properties.Resources._78981_Bread_Vol_5_No_17;
            this.pictureBox1.Location = new System.Drawing.Point(178, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 340);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bntDX
            // 
            this.bntDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDX.Location = new System.Drawing.Point(677, 30);
            this.bntDX.Name = "bntDX";
            this.bntDX.Size = new System.Drawing.Size(111, 31);
            this.bntDX.TabIndex = 2;
            this.bntDX.Text = "Đăng xuất";
            this.bntDX.UseVisualStyleBackColor = true;
            this.bntDX.Click += new System.EventHandler(this.bntDX_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntDX);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Quản lý tiệm bánh";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuNL;
        private System.Windows.Forms.ToolStripMenuItem menuPN;
        private System.Windows.Forms.ToolStripMenuItem menuBanh;
        private System.Windows.Forms.ToolStripMenuItem menuHD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bntDX;
    }
}