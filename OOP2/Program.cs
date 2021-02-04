using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.CustomerNo = "101";
            musteri1.MusteriAdi = "Koray";
            musteri1.MusteriSoyadi = "Kurucan";
            musteri1.TcNo = "1231231313";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.VergiNo = "1234567890";
            musteri2.Id = 2;
            musteri2.SirketAdi = "Deli A.Ş.";


            Customer customer1 = new TuzelMusteri();
            Customer customer2 = new GercekMusteri();

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(musteri1);
            customerManager.Add(customer1);
        }
    }
}
