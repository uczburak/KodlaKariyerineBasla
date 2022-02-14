using System;

namespace while_foreach_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // while
            // 1'den kullanıcıdan alınan sayıya kadar olan sayıların ortalamasını bulma
            Console.Write("Lütfen bir sayı giriniz:     ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1, toplam = 0;

            while(sayac <= sayi)
            {
                toplam += sayac;
                sayac ++;
            }

            Console.WriteLine(toplam/sayi);

            //a'dan z'ye kadar tüm harfleri yazdır
            char character = 'a';
            while(character < 'z')
            {
                Console.Write(character+" ");
                character++;
            }

            //foreach
            Console.WriteLine("\n***** FOREACH *****");
            string[] arabalar = {"BMW", "Ford", "Toyota", "Nissan"};

            foreach (var araba in arabalar)
            {
                Console.Write(araba + " ");
            }
        }
    }
}
