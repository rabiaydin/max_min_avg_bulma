using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_min_avg_bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 12, 9, 13, 7, 26, 45, 98, 74, 2, 4, 33 };
            int max_sayi = sayilar[0];
            int min_sayi = sayilar[0];
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i]>max_sayi)
                {
                    max_sayi = sayilar[i];
                }
            }
            Console.WriteLine($"Dizide yer alan en büyük sayı:{max_sayi}");

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] < min_sayi)
                {
                    min_sayi = sayilar[i];
                }
            }
            Console.WriteLine($"Dizide yer alan en küçük sayı:{min_sayi}");

            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }

            double ortalama = toplam / sayilar.Length;

            Console.WriteLine($"Dizide yer alan elemanların toplamı: {toplam}, eleman sayısı:{sayilar.Length}");
            Console.WriteLine($"Dizide yer alan sayıların ortalaması:{ortalama}");

            Console.ReadLine();

        }
    }
}
