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
    
    
    public partial class FormCT_PhieuNhap : Form
    {
        public static Form fm1 = new Form();
        CT_PhieuNhapBLL ctpn = new CT_PhieuNhapBLL();
        public FormCT_PhieuNhap()
        {
            InitializeComponent();
            fm1 = this;
        }

        private void FormCT_PhieuNhap_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ctpn.SelectCTPN();
            dataCT_PhieuNhap.DataSource = dt;
            DataTable dt1 = new DataTable();
            dt1 = ctpn.SelectHD();
            if (cbbMapn.Text.Trim() == "")
            {
                cbbMapn.DataSource = dt1;
                cbbMapn.DisplayMember = "maPN";
                cbbMapn.ValueMember = "maPN";
            }
            cbbMa.DataSource = dt1;
            cbbMa.DisplayMember = "maPN";
            cbbMa.ValueMember = "maPN";
            DataTable dt2 = new DataTable();
            dt2 = ctpn.SelectNL();
            if (cbbMaNL.Text.Trim() == "")
            {
                cbbMaNL.DataSource = dt2;
                cbbMaNL.DisplayMember = "maNL";
                cbbMaNL.ValueMember = "maNL";
            }
            txtsolg.Text = "";
            txtDongia.Text = "";
        }
        private void bntThem_Click(object sender, EventArgs e)
        {
            if (cbbMapn.Text.Trim() != "" && cbbMaNL.Text.Trim() != "")
            {
                try
                {
                    ctpn.InsertCTPN(cbbMapn.Text, cbbMaNL.Text, float.Parse(txtsolg.Text), float.Parse(txtDongia.Text));
                    FormCT_PhieuNhap_Load(sender, e);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Lỗi nhập dữ liệu.", "Thông báo");
                }


            }
            else
            {
                MessageBox.Show("Mã không được để trống.", "Thông báo");
            }
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            if (cbbMapn.Text.Trim() != "" && cbbMaNL.Text.Trim() != "")
            {
                try
                {
                    ctpn.UpdateCTPN(cbbMapn.Text, cbbMaNL.Text, float.Parse(txtsolg.Text), float.Parse(txtDongia.Text));
                    FormCT_PhieuNhap_Load(sender, e);
                }
                 
                catch (FormatException ex)
                {
                    MessageBox.Show("Lỗi nhập dữ liệu.", "Thông báo");
                }
                
            }
            else
            {
                MessageBox.Show("Mã không được để trống.", "Thông báo");
            }
        }

        private void bntXoa_Click_1(object sender, EventArgs e)
        {
            if (cbbMapn.Text.Trim() != "" && cbbMaNL.Text.Trim() != "")
            {
                    ctpn.DeleteCTPN(cbbMapn.Text, cbbMaNL.Text);
                    FormCT_PhieuNhap_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Chọn vào dòng cần xóa", "Thông báo");
            }
        }
        private void ShowForm()
        {
            var menu = new FormPhieuNhap();
            menu.ShowDialog();
        }
 
        private void bntThoat_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowForm));
            thread.Start();
            this.Close();
        }
        private void dataCT_PhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                cbbMapn.Text = dataCT_PhieuNhap.Rows[row].Cells[0].Value.ToString();
                cbbMaNL.Text = dataCT_PhieuNhap.Rows[row].Cells[1].Value.ToString();
                txtsolg.Text = dataCT_PhieuNhap.Rows[row].Cells[5].Value.ToString();
                txtDongia.Text=dataCT_PhieuNhap.Rows[row].Cells[4].Value.ToString();
            }
        }

        private void bntTim_Click(object sender, EventArgs e)
        {
            if (cbbMapn.Text.Trim() != "")
            {
                DataTable dt1 = new DataTable();
                dt1 = ctpn.TimCTPN(cbbMapn.Text);
                dataCT_PhieuNhap.DataSource = dt1;
            }
            else
            {
                MessageBox.Show("Chọn mã cần tìm", "Thông báo");
            }
        }

        private void bntHuy_Click(object sender, EventArgs e)
        {
            FormCT_PhieuNhap_Load(sender, e);
        }

        
    }
}
