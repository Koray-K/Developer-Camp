using System;
namespace OOP3
{
    class BasvuruManager
    {

        public void BasvuruYap(IKrediManager krediManager)
        {

            krediManager.Hesapla();
        }

    }

}

