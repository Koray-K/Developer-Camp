using System;
namespace OOP3
{
    public class EvKrediManager : IKrediManager
    {
        public EvKrediManager()
        {
        }

        public void BirSeyYap()
        {
            Console.WriteLine("Ev Kredisi Hesaplandı.");
        }

        public void Hesapla()
        {
            throw new NotImplementedException();
        }
    }
}
