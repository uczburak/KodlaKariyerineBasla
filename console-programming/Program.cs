﻿using System;

namespace console_programming
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi Girin!");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi Girin!");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba " + name + " " + surname);
        }
    }
}
