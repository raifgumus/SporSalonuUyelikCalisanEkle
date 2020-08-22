using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UyelikCalisanTakip
{
    class Calisan
    {
        //Alanlar
        int _id;
        string _calisamAd;
        string _calisanSoyad;
        string _calisanMevki;
        string _calisanTelefon;
        //Özellikler

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string CalisanAd
        {
            get { return _calisamAd; }
            set { _calisamAd = value; }
        }
        public string CalisanSoyad
        {
            get { return _calisanSoyad; }
            set { _calisanSoyad = value; }
        }
        public string CalisanMevki
        {
            get { return _calisanMevki; }
            set { _calisanMevki = value; }

        }
        public string CalisanTelefon
        {
            get { return _calisanTelefon; }
            set { _calisanTelefon = value; }
        }
    }
}
