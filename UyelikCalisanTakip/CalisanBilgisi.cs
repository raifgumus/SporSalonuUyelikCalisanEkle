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
    public partial class frmCalisan : Form
    {
        CalisanProvider cp = new CalisanProvider();
        public frmCalisan()
        {
            InitializeComponent();
        }
        //Datagrid listeleme işlemi için metot. 
        void Listele()
        {
            dtwCalisan.DataSource = cp.Listele();
        }

        private void CalisanBilgisi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            Calisan yeniCalisan = new Calisan();

            yeniCalisan.CalisanAd = txtCalisanAdi.Text;
            yeniCalisan.CalisanSoyad = txtCalisanSoyadi.Text;
            yeniCalisan.CalisanMevki = txtCalisanMevki.Text;
            yeniCalisan.CalisanTelefon = txtCalisanTelefon.Text;
            cp.Ekle(yeniCalisan);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Calisan silinecekCalisan = new Calisan();
            silinecekCalisan = (Calisan)dtwCalisan.CurrentRow.DataBoundItem;
            cp.Sil(silinecekCalisan);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Calisan eskicalisan = new Calisan();
            eskicalisan = (Calisan)dtwCalisan.CurrentRow.DataBoundItem;
            Calisan yenicalisan = new Calisan();
            yenicalisan.CalisanAd = txtCalisanAdi.Text;
            yenicalisan.CalisanSoyad = txtCalisanSoyadi.Text;
            yenicalisan.CalisanMevki = txtCalisanMevki.Text;
            yenicalisan.CalisanTelefon = txtCalisanTelefon.Text;
            cp.Guncelle(eskicalisan, yenicalisan);
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtCalisanAdi.Clear();
            txtCalisanSoyadi.Clear();
            txtCalisanMevki.Clear();
            txtCalisanTelefon.Clear();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            frmUyelik form2sec = new frmUyelik();
            form2sec.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilgiler kaydedildi. Çıkış Yapılıyor");
            this.Close();
            Application.Exit();
        }

        private void dtwCalisan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCalisanAdi.Text = dtwCalisan.CurrentRow.Cells[1].Value.ToString();
            txtCalisanSoyadi.Text = dtwCalisan.CurrentRow.Cells[2].Value.ToString();
            txtCalisanMevki.Text = dtwCalisan.CurrentRow.Cells[3].Value.ToString();
            txtCalisanTelefon.Text = dtwCalisan.CurrentRow.Cells[4].Value.ToString();
            
        }
    }
}
