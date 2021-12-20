using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTiemBanh.BLL;
using System.Data.SqlClient;
using System.Threading;

namespace QLTiemBanh.GUI
{
    public partial class FormPhieuNhap : Form
    {
        public static Form fm1 = new Form();
        PhieuNhapBLL pnbll = new PhieuNhapBLL();

        public FormPhieuNhap()
        {
            InitializeComponent();
            fm1 = this;
        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = pnbll.SelectPN();
            dataPN.DataSource = dt;
            cbbMaPN.DataSource = dt;
            cbbMaPN.DisplayMember = "maPN";
            cbbMaPN.ValueMember = "maPN";
            txtMaPN.Text = "";
            txtNhaCC.Text = "";
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
        
            if(txtMaPN.Text.Trim() != "")
            {
                pnbll.InsertPN(txtMaPN.Text, txtNhaCC.Text, dtpNgayLap.Value);
                FormPhieuNhap_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Mã phiếu nhập không được để trống.","Thông báo");
            }

        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            if (txtMaPN.Text.Trim() != "")
            {
                pnbll.UpdatePN(txtMaPN.Text, txtNhaCC.Text, dtpNgayLap.Value);
                FormPhieuNhap_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Mã phiếu nhập không được để trống.", "Thông báo");
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPN.Text.Trim() != "")
            {
                pnbll.DeletePN(txtMaPN.Text);
                FormPhieuNhap_Load(sender, e);
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

        private void dataPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if(row>=0)
            {
                txtMaPN.Text = dataPN.Rows[row].Cells[0].Value.ToString();
                txtNhaCC.Text = dataPN.Rows[row].Cells[1].Value.ToString();
                dtpNgayLap.Text = dataPN.Rows[row].Cells[2].Value.ToString();

            }
        }

        private void bntTim_Click(object sender, EventArgs e)
        {
            if (cbbMaPN.Text.Trim() != "" )
            {
                DataTable dt1 = new DataTable();
                dt1 = pnbll.TimPN(cbbMaPN.Text);
                dataPN.DataSource = dt1;
            }
            else
            {
                MessageBox.Show("Chọn mã cần tìm", "Thông báo");
            }
        }

        private void bntHuy_Click(object sender, EventArgs e)
        {
            FormPhieuNhap_Load(sender, e);
        }
        private void ShowFormCTPN()
        {
            var menu = new FormCT_PhieuNhap();
            menu.ShowDialog();
        }
        private void btnChiTietPN_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowFormCTPN));
            thread.Start();
            this.Close();
        }

       
    }
}
