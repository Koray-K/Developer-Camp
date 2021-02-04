using System;
namespace OOP3
{
    public class IhtiyacKrediManager : IKrediManager
    {
        public IhtiyacKrediManager()
        {
        }

        public void BirSeyYap()
        {
            Console.WriteLine("İhtiyaç Kredisi Hesaplandı.");
        }

        public void Hesapla()
        {
            throw new NotImplementedException();
        }
    }
}
