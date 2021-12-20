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
using QLTiemBanh.GUI;
namespace QLTiemBanh
{
    public partial class Menu : Form
    {
        public static Form fm = new Form();
        public Menu()
        {
            InitializeComponent();
            fm = this;
        }



        private void Menu_Load(object sender, EventArgs e)
        {

        }
        private void ShowForm()
        {
            var dn = new Form1();
            dn.ShowDialog();
        }

        private void bntDX_Click(object sender, EventArgs e)
        {
             
            Thread thread = new Thread(new ThreadStart(ShowForm));
            thread.Start();
            this.Close();
        }

        private void ShowFormNL()
        {
            FormNguyenLieu fmnl = new FormNguyenLieu();
            fmnl.ShowDialog();
        }

        
        private void menuNL_Click(object sender, EventArgs e)
        {

            Thread thread = new Thread(new ThreadStart(ShowFormNL));
            thread.Start();
            this.Close();
        }
        private void ShowFormPN()
        {
            FormPhieuNhap fmpn = new FormPhieuNhap();
            fmpn.ShowDialog();
        }

        private void menuPN_Click(object sender, EventArgs e)
        {

            Thread thread = new Thread(new ThreadStart(ShowFormPN));
            thread.Start();
            this.Close();

        }
        private void ShowFormB()
        {
            FormBanh fmb = new FormBanh();
            fmb.ShowDialog();
        }
        private void menuBanh_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowFormB));
            thread.Start();
            this.Close();

        }
        private void ShowFormHD()
        {
            FormHoaDon fmhd = new FormHoaDon();
            fmhd.ShowDialog();
        }
        private void menuHD_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowFormHD));
            thread.Start();
            this.Close();

        }
    }
}
