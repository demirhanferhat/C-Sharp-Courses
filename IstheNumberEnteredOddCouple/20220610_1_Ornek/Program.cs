using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IstheNumberEnteredOddCouple
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 1 adet sayı talep edelim.
            // Girilen sayı tek mi? çift mi? ekrana yazdıralım.

            Console.Write("Bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Sayı tektir.");
            }

            Console.ReadKey();
        }
    }
}
