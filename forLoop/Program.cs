﻿using System;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanicidan girilen sayiya kadar olan tek sayilari ekrana yazdir.
            Console.WriteLine("Lutfen bir sayi giriniz: ");
            int sayac = int.Parse(Console.ReadLine());

            for(int i = 1; i <= sayac; i++)
            {
                if(i%2 == 1)
                    Console.WriteLine(i);
            }

            //1 ile 1000 arasindaki tek ve cift sayilarin kendi icerisinde toplamlarini ekrana yazdir
            int tekToplam = 0, ciftToplam = 0;
            for(int i = 1; i <= 1000; i++)
            {
                if(i%2 == 1)
                    tekToplam += i;
                else
                    ciftToplam += i;
            }
            
            Console.WriteLine("Tek Toplam : " + tekToplam);
            Console.WriteLine("Çift Toplam : " + ciftToplam);

            // break, continue

            for(int i = 1; i <= 10; i++)
            {
                if(i == 4)
                    break;
                Console.WriteLine(i);
            }

            for(int i = 1; i <= 10; i++)
            {
                if(i == 4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
