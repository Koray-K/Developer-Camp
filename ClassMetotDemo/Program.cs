using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.MusteriAdi = "Metin";
            musteri.MusteriSoyadi = "Tekin";
            musteri.Id = 1;
            musteri.yas = 39;

            Musteri musteri1 = new Musteri();
            musteri.MusteriAdi = "Ali";
            musteri.MusteriSoyadi = "Gültekin";
            musteri.Id = 1;
            musteri.yas = 39;

            Musteri musteri2 = new Musteri();
            musteri.MusteriAdi = "Feyyaz";
            musteri.MusteriSoyadi = "Uçar";
            musteri.Id = 1;
            musteri.yas = 39;




            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri);


        }
    }
}
