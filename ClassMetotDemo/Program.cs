using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Tahsin";
            musteri1.Soyad = "Şener";
            musteri1.Cinsiyet = "Erkek";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Esma";
            musteri2.Soyad = "Çalışkan";
            musteri2.Cinsiyet = "Kadın";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Fatih";
            musteri3.Soyad = "Korkmaz";
            musteri3.Cinsiyet = "Erkek";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Cinsiyet);
                Console.WriteLine("*******************************");
            }


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.ekle(musteri1);
            musteriManager.silme(musteri2);
            musteriManager.listele(musteri3);



        }
    }
}
