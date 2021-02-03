using System;
using System.Collections.Generic;

namespace DictionaryOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> sozluk = new MyDictionary<int, string>();

            sozluk.Add(1, "KORAY");
            sozluk.Add(2, "Aybar");

            for (int i = 0; i < sozluk.Keys.Length; i++)
            {
                Console.WriteLine(sozluk.Keys[i] + " " + sozluk.Values[i]);

            }
        }
    }
}
