using System;
namespace OOP3
{
    public class TasitKrediManager : IKrediManager
    {
        public TasitKrediManager()
        {
        }

        public void BirSeyYap()
        {
            Console.WriteLine("Taşıt Kredisi Hesaplandı.");
        }

        public void Hesapla()
        {
            throw new NotImplementedException();
        }
    }
}
