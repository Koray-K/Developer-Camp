using System;
namespace Metotlar
{
    public class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: " + urun.Name + " " + urun.Price);
        }


        public void Ekle2(string urunAdi, string Description, double Price, int Quantity)
        {
            //yukardaki satır diyor ki ben eklicem ürünü ama bana ürünün adı, açıklaması ve fiyatını ver ki ben gidip veri kaynağına bu 3ünü birden ekleyeyim

            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }


    }
}
