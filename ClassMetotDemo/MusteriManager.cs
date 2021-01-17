using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " adında yeni bir müşteri eklendi!");
        }

        public void silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Id +" numarasına sahip müşteri çıkarıldı!");
        }

        public void listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Cinsiyet + " Cinsiyeti olan müşteriler listelendi!");
        }
    }
}
