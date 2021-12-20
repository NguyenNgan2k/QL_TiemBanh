using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTiemBanh.GUI;
using QLTiemBanh.DTO;
using QLTiemBanh.BLL;
using System.Threading;

namespace QLTiemBanh
{
    public partial class Form1 : Form
    {
         
        public Form1()
        {
            InitializeComponent();
             
              
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTenTK.Text = "nguyenngan";
            txtMK.Text = "12345678";
        }
        private void ShowForm()
        {
            var menu = new Menu();
            menu.ShowDialog();
        }

        
        private void btnDN_Click(object sender, EventArgs e)
        {
            if (txtTenTK.Text.Trim()=="" || txtMK.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin ! ", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string userName = txtTenTK.Text;
                string pass = txtMK.Text;
                TaiKhoan userDTO = new TaiKhoan();
                TaiKhoanBLL userBLL = new TaiKhoanBLL();
                userDTO.TenTK = userName;
                userDTO.MatKhau = pass;
                TaiKhoan result = userBLL.FindOne(userName, pass);
                if (result == null)
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu sai ! ", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Thread thread = new Thread(new ThreadStart(ShowForm));
                thread.Start();
                this.Close();
            }
        }

        private void bntHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
