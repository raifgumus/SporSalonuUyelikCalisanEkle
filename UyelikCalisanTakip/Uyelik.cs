using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UyelikCalisanTakip
{
    class Uyelik
    {
        // Üyelik adlı sınıfın oluşturuluması


        //Alanlar

        string _tcNo;
        string _ad;
        string _soyad;
        string _telefon;
        string _mail;
        //Özellikler
        public string tcNo
        {
            get { return _tcNo; }
            set { _tcNo = value; }
        }
        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }
        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }

        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }
        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }


    }
}
