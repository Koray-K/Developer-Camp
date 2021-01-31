using System;
using System.Collections.Generic
namespace ClassMetotDemo
{
    public class MusteriManager
    {

        List<Musteri> musteriList = new List<Musteri> { };

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Yeni Müşteri Kaydı Oluşturuldu");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri başarıyla silindi");
        }


        public void Listele()
        {

        }


    }
}
