﻿using System;

namespace exceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            //     Console.WriteLine("Bir sayı giriniz:");
            //     int sayi = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Girmis oldugunuz sayi : " + sayi);
            // }
            // catch(Exception ex)
            // {
            //     Console.WriteLine("Hata : "+ ex.Message.ToString());
            // }
            // finally
            // {
            //     Console.WriteLine("İşlem Tamamlandı.");
            // }

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem basariyla tamamlandi.");
            }
        }
    }
}
