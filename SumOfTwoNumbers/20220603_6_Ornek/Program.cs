using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 2 adet sayı talep edelim. Sayıların toplamını ekrana yazdıralım.

            Console.Write("1. sayıyı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());


            Console.Write("2. sayıyı giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sayıların Toplamı: " + (sayi1 + sayi2));

            Console.ReadKey();

        }
    }
}
