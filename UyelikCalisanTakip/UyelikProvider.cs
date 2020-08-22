using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; //Eklenen kütüpahneler
using System.Data.SqlClient; //Ekle kütüphaneler
using System.Threading.Tasks;

namespace UyelikCalisanTakip
{
    class UyelikProvider
    {
        SqlConnection baglanti;
        SqlCommand komut;
        //Kurucu(constructor) metotun olusturulması
        public UyelikProvider()
        {
            Baglan();
        }

        public void Baglan()
        {
            baglanti = new SqlConnection("server=DESKTOP-R8PK08I; Initial Catalog=Data;Integrated Security=SSPI");
            komut = new SqlCommand();
            komut.Connection = baglanti;
        }
        public List<Uyelik> Listele()
        {

            try
            {
                List<Uyelik> uyeListesi = new List<Uyelik>();
                komut.CommandText = "Select *From uyelik";
                komut.CommandType = CommandType.Text;
                baglanti.Open();
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    Uyelik yeniUye = new Uyelik();
                    yeniUye.tcNo =reader[1].ToString();
                    yeniUye.Ad = reader[2].ToString();
                    yeniUye.Soyad = reader[3].ToString();
                    yeniUye.Telefon = reader[4].ToString();
                    yeniUye.Mail = reader[5].ToString();


                    uyeListesi.Add(yeniUye);
                }

                return uyeListesi;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }
        }
        public void Ekle(Uyelik yeniUye)
        {
            try
            {
                komut.CommandText = "Insert Into uyelik (TC_No,Ad,Soyad,Telefon,Mail) Values (" + yeniUye.tcNo +
                    ",'" + yeniUye.Ad + "','" + yeniUye.Soyad +
                    "','" + yeniUye.Telefon + "','" + yeniUye.Mail + "')";
                komut.CommandType = CommandType.Text;
                baglanti.Open();
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }

        }
        public void Sil(Uyelik yeniUye)
        {
            try
            {
                komut.CommandText = "Delete From uyelik Where TC_No=" + yeniUye.tcNo + "";
                komut.CommandType = CommandType.Text;
                baglanti.Open();
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }
        }
        public void Guncelle(Uyelik eskiUyeler, Uyelik yeniUyeler)
        {
            try
            {
                komut.CommandText = "Update uyelik SET Ad='" + yeniUyeler.Ad +
                    "',Soyad='" + yeniUyeler.Soyad + "',Telefon='" + yeniUyeler.Telefon
                    + "',Mail='" + yeniUyeler.Mail + "' Where TC_No=" + eskiUyeler.tcNo + "";
                komut.CommandType = CommandType.Text;
                baglanti.Open();
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }

        }

    }
}
