using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTiemBanh.BLL;
namespace QLTiemBanh.GUI
{
    public partial class FormBanh : Form
    {
        BanhBLL banh = new BanhBLL();
        public FormBanh()
        {
            InitializeComponent();
        }

        private void FormBanh_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = banh.SelectB();
            dataBanh.DataSource = dt;
            cbbMaB.DataSource = dt;
            cbbMaB.DisplayMember = "maBanh";
            cbbMaB.ValueMember = "maBanh";
            txtMaB.Text = "";
            txtTenB.Text = "";
            txtDVT.Text = "";
            txtGia.Text = "";

        }

        private void bntThem_Click(object sender, EventArgs e)
        {
             
            if (txtMaB.Text.Trim() != "" && txtTenB.Text.Trim() !="")
            {
                try
                {
                    banh.InsertB(txtMaB.Text, txtTenB.Text, txtDVT.Text, float.Parse(txtGia.Text));
                    FormBanh_Load(sender, e);
                }
                 catch(FormatException ex)
                {
                    MessageBox.Show("Lỗi nhập dữ liệu.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Mã và tên bánh không được để trống.", "Thông báo");
            }

        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            if (txtMaB.Text.Trim() != "" && txtTenB.Text.Trim() != "")
            {
                try
                {
                    banh.UpdateB(txtMaB.Text, txtTenB.Text, txtDVT.Text, float.Parse(txtGia.Text));
                    FormBanh_Load(sender, e);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Lỗi nhập dữ liệu.","Thông báo");
                }
                
            }
            else
            {
                MessageBox.Show("Mã và tên bánh không được để trống.", "Thông báo");
            }
             
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            if (txtMaB.Text.Trim() != "")
            {
                banh.DeleteB(txtMaB.Text);
                FormBanh_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Mã bánh không được để trống.", "Thông báo");
            }
             
        }

        private void bntTim_Click(object sender, EventArgs e)
        {
            if (cbbMaB.Text.Trim() != "")
            {
                DataTable dt1 = new DataTable();
                dt1 = banh.TimB(cbbMaB.Text);
                dataBanh.DataSource = dt1;
            }
            else
            {
                MessageBox.Show("Chọn mã cần tìm.", "Thông báo");
            }
        }

        private void bntHuy_Click(object sender, EventArgs e)
        {
            FormBanh_Load(sender, e);
        }
        private void ShowForm()
        {
            var menu = new Menu();
            menu.ShowDialog();
        }
        
        private void bntThoat_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowForm));
            thread.Start();
            this.Close();
        }

        private void dataBanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaB.Text = dataBanh.Rows[row].Cells[0].Value.ToString();
                txtTenB.Text = dataBanh.Rows[row].Cells[1].Value.ToString();
                txtDVT.Text = dataBanh.Rows[row].Cells[2].Value.ToString();
                txtGia.Text = dataBanh.Rows[row].Cells[3].Value.ToString();
            }
        }
    }
}
