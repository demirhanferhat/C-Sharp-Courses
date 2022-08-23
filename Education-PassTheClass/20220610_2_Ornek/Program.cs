using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _20220610_2_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 3 adet not bilgisi talep edelim.
            // Girilen notların ortalaması 50 ve üzeri ise geçti, değilse kaldı diye ekrana mesaj yazdıralım.

            Console.Write("1. notu giriniz: ");
            int not1 = int.Parse(Console.ReadLine());

            Console.Write("2. notu giriniz: ");
            int not2 = int.Parse(Console.ReadLine());

            Console.Write("3. notu giriniz: ");
            int not3 = int.Parse(Console.ReadLine());

            // Tam sayı bölme işleminde double sayı ile bölme yaparsanız ondalıklı sayı elde edersiniz.
            //double ortalama = (not1 + not2 + not3) / 3.0;

            // Tam sayılardan ondalıklı sayı elde etme işlemini bilinçli tür dönüşümü işlemi ile yapabilirsiniz. Bu işleme cast etme işlemide denir.
            double ortalama = (double)(not1 + not2 + not3) / 3;

            Console.WriteLine("Ortalama: " + ortalama);
            if (ortalama >= 50)
            {
                Console.WriteLine("GEÇTİ");
            }
            else
            {
                Console.WriteLine("KALDI");
            }

            Console.ReadKey();
        }
    }
}
