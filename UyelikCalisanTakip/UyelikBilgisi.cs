using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UyelikCalisanTakip
{
    public partial class frmUyelik : Form
    {
        UyelikProvider uprovider = new UyelikProvider();
        //readonly string ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        public frmUyelik()
        {
            InitializeComponent();
        }
        void Listele()
        {
            dtwUyelikTablo.DataSource = uprovider.Listele();
        }

        private void btn_Kayit_Click(object sender, EventArgs e)
        {
            Uyelik uye = new Uyelik();
            uye.tcNo = txtTC.Text;
            uye.Ad = txtAd.Text;
            uye.Soyad = txtSoyad.Text;
            uye.Telefon = Convert.ToString(txtTelefon.Text);
            uye.Mail = txtMail.Text;
            uprovider.Ekle(uye);
            Listele();
        }

        private void frmUyelik_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Uyelik silinecekUye = new Uyelik();
            silinecekUye = (Uyelik)dtwUyelikTablo.CurrentRow.DataBoundItem;
            uprovider.Sil(silinecekUye);
            Listele();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Uyelik eskiUyeler = new Uyelik();
            eskiUyeler = (Uyelik)dtwUyelikTablo.CurrentRow.DataBoundItem;
            Uyelik yeniUyeler = new Uyelik();
            yeniUyeler.tcNo = txtTC.Text;
            yeniUyeler.Ad = txtAd.Text;
            yeniUyeler.Soyad = txtSoyad.Text;
            yeniUyeler.Telefon = txtTelefon.Text;
            yeniUyeler.Mail = txtMail.Text;
            uprovider.Guncelle(eskiUyeler, yeniUyeler);
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtTC.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtMail.Clear();
        }

        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            frmCalisan form1sec = new frmCalisan();
            form1sec.Show();
            this.Hide();

        }

        private void dtwUyelikTablo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTC.Text = dtwUyelikTablo.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text = dtwUyelikTablo.CurrentRow.Cells[2].Value.ToString();
            txtSoyad.Text = dtwUyelikTablo.CurrentRow.Cells[3].Value.ToString();
            txtTelefon.Text = dtwUyelikTablo.CurrentRow.Cells[4].Value.ToString();
            txtMail.Text = dtwUyelikTablo.CurrentRow.Cells[5].Value.ToString();

        }

    }
}
