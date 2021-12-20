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
    public partial class FormHoaDon : Form
    {
        HoaDonBLL hd = new HoaDonBLL();
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = hd.SelectHD();
            dataHD.DataSource = dt;
            cbbMaHD.DataSource = dt;
            cbbMaHD.DisplayMember = "maHD";
            cbbMaHD.ValueMember = "maHD";
            txtMaHD.Text = "";
            txtTenKH.Text = "";
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim() != "")
            {
                hd.InsertHD(txtMaHD.Text, txtTenKH.Text, dtpNgayLap.Value);
                FormHoaDon_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Mã hóa đơn không được để trống.", "Thông báo");
            }
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim() != "")
            {
                hd.UpdateHD(txtMaHD.Text, txtTenKH.Text, dtpNgayLap.Value);
                FormHoaDon_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Mã hóa đơn không được để trống.", "Thông báo");
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim() != "")
            {
                hd.DeleteHD(txtMaHD.Text);
                FormHoaDon_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Mã phiếu nhập không được để trống.", "Thông báo");
            }
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
        private void ShowFormCTHD()
        {
            var menu = new FormCT_HoaDon();
            menu.ShowDialog();
        }
         
        private void btnChiTietHD_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowFormCTHD));
            thread.Start();
            this.Close();
        }

        private void bntTim_Click(object sender, EventArgs e)
        {
            if (cbbMaHD.Text.Trim() != "")
            {
                DataTable dt1 = new DataTable();
                dt1 = hd.TimHD(cbbMaHD.Text);
                dataHD.DataSource = dt1;
            }
            else
            {
                MessageBox.Show("Chọn mã cần tìm", "Thông báo");
            }
        }

        private void bntHuy_Click(object sender, EventArgs e)
        {
            FormHoaDon_Load(sender, e);
        }

        private void dataHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaHD.Text = dataHD.Rows[row].Cells[0].Value.ToString();
                txtTenKH.Text = dataHD.Rows[row].Cells[1].Value.ToString();
                dtpNgayLap.Text = dataHD.Rows[row].Cells[2].Value.ToString();

            }
        }
    }
}
