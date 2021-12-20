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
    public partial class FormNguyenLieu : Form
    {
        NguyenLieuBLL nlbll = new NguyenLieuBLL();
        public FormNguyenLieu()
        {
            InitializeComponent();
        }

        private void FormNguyenLieu_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = nlbll.SelectNL();
            dataNL.DataSource = dt;
            cbbMaNL.DataSource = dt;
            cbbMaNL.DisplayMember = "maNL";
            cbbMaNL.ValueMember = "maNL";
            txtMaNL.Text = "";
            txtTenNL.Text = "";
            txtDVT.Text = "";
            txtSLC.Text = "";
            txtSLX.Text = "";

        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            if (txtMaNL.Text.Trim() != "" && txtTenNL.Text.Trim() != "")
            {
                try
                {
                    float a = float.Parse(txtSLC.Text);
                    float b;
                    if (txtSLX.Text.Trim() == "")
                        b = 0;
                    else b = float.Parse(txtSLX.Text);
                    nlbll.InsertNL(txtMaNL.Text, txtTenNL.Text, txtDVT.Text, a - b);
                    FormNguyenLieu_Load(sender, e);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Lỗi nhập dữ liệu.", "Thông báo");
                }
                
            }
            else
            {
                MessageBox.Show("Mã và tên nguyên liệu không được để trống.", "Thông báo");
            }

        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            if (txtMaNL.Text.Trim() != "" && txtTenNL.Text.Trim() != "")
            {
                try
                {
                    float a = float.Parse(txtSLC.Text);
                    float b;
                    if (txtSLX.Text.Trim() == "")
                        b = 0;
                    else b = float.Parse(txtSLX.Text);
                    nlbll.UpdateNL(txtMaNL.Text, txtTenNL.Text, txtDVT.Text, a - b);
                    FormNguyenLieu_Load(sender, e);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Lỗi nhập dữ liệu.", "Thông báo");
                }
                 
            }
            else
            {
                MessageBox.Show("Mã và tên nguyên liệu không được để trống.", "Thông báo");
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNL.Text.Trim() != "" && txtTenNL.Text.Trim() != "")
            {
                nlbll.DeleteNL(txtMaNL.Text);
                FormNguyenLieu_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Mã và tên nguyên liệu không được để trống.", "Thông báo");
            }
        }
        private void ShowForm()
        {
            var menu = new Menu();
            menu.ShowDialog();
        }
        private void bntThoat_Click(object sender, EventArgs e)
        {
            //this.Close();
            Thread thread = new Thread(new ThreadStart(ShowForm));
            thread.Start();
            this.Close();

        }

        private void bntTim_Click(object sender, EventArgs e)
        {
            if (cbbMaNL.Text.Trim() != "")
            {
                DataTable dt1 = new DataTable();
                dt1 = nlbll.TimNL(cbbMaNL.Text);
                dataNL.DataSource = dt1;
            }
            else
            {
                MessageBox.Show("Chọn mã cần tìm", "Thông báo");
            }
        }

        private void bntHuy_Click(object sender, EventArgs e)
        {
            FormNguyenLieu_Load(sender, e);
        }

        private void dataNL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaNL.Text = dataNL.Rows[row].Cells[0].Value.ToString();
                txtTenNL.Text = dataNL.Rows[row].Cells[1].Value.ToString();
                txtDVT.Text = dataNL.Rows[row].Cells[2].Value.ToString();
                txtSLC.Text = dataNL.Rows[row].Cells[3].Value.ToString();
            }
        }

        
    }
}
