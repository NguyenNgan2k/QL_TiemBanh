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
using QLTiemBanh.DTO;

namespace QLTiemBanh.GUI
{
    public partial class FormCT_HoaDon : Form
    {
        
        
        CT_HoaDonBLL ct = new CT_HoaDonBLL();
        public FormCT_HoaDon()
        {
            InitializeComponent();
        }

        private void FormCT_HoaDon_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = ct.SelectCTHD(cbbMaHD.Text);
            dataCTHD.DataSource = dt;
            DataTable dt1 = new DataTable();
            dt1 = ct.SelectHD();
            if(cbbMaHD.Text.Trim()=="")
            {
                cbbMaHD.DataSource = dt1;
                cbbMaHD.DisplayMember = "maHD";
                cbbMaHD.ValueMember = "maHD";
            }
             

            DataTable dt2 = new DataTable();
            dt2 = ct.SelectB();
            cbbMaB.DataSource = dt2;
            cbbMaB.DisplayMember = "maBanh";
            cbbMaB.ValueMember = "maBanh";
            txtSLB.Text = "";
        }
        private void bntThem_Click(object sender, EventArgs e)
        {
            if (cbbMaHD.Text.Trim() != "" && cbbMaB.Text.Trim() != "")
            {
                try
                {
                    Banh bn = new Banh();
                    bn = ct.SelectB(cbbMaB.Text);
                    float a = bn.DonGia;
                    int solg = int.Parse(txtSLB.Text);
                    ct.InsertCTHD(cbbMaHD.Text, cbbMaB.Text, int.Parse(txtSLB.Text), a * solg);    
                    FormCT_HoaDon_Load(sender, e);

                }
                catch(FormatException ex)
                {
                    MessageBox.Show("Lỗi nhập dữ liệu.", "Thông báo");
                }
                 
            }
            else
            {
                MessageBox.Show("Mã không được để trống.", "Thông báo");
            }
            
        }
        private void bntXoa_Click(object sender, EventArgs e)
        {
            if (cbbMaHD.Text.Trim() != "" && cbbMaB.Text.Trim() != "")
            {
                ct.DeleteCTHD(cbbMaHD.Text,cbbMaB.Text);
                FormCT_HoaDon_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Chọn dòng cần xóa", "Thông báo");
            }
        }
        private void ShowForm()
        {
            var menu = new FormHoaDon();
            menu.ShowDialog();
        }

        
        private void bntThoat_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowForm));
            thread.Start();
            this.Close();
        }

        private void dataCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {    
                cbbMaB.Text = dataCTHD.Rows[row].Cells[0].Value.ToString();
                txtSLB.Text = dataCTHD.Rows[row].Cells[3].Value.ToString();  
            }
        }

        private void bntTim_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = ct.SelectCTHD(cbbMaHD.Text);
            dataCTHD.DataSource = dt;
            FormCT_HoaDon_Load(sender, e);
        }
      
    }
}
