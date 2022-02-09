using System;

namespace hafta3VeriTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;     //1 byte
            sbyte c = 5;    //1 byte

            short s = 5;    //2 byte
            ushort us = 5;  //2 byte

            Int16 i16 = 2;  //2 byte
            int i = 2;      //4 byte
            Int32 i32 = 2;  //4 byte
            Int64 i64 = 2;  //8 byte

            uint ui = 2;    //4 byte
            long l = 4;     //8 byte
            ulong ul = 4;   //8 byte

            float f = 5;    //4 byte
            double d = 5;   //8 byte
            decimal de = 5; //16 byte

            char ch = '2';  //2 byte
            string str = ""; //sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            //String phrases

            string str1 = string.Empty;
            str1 = "Burak UCUZ";
            string ad = "Burak";
            string soyad = "UCUZ";
            string tamAd = ad + " " + soyad;

            //Integer definitions

            int int1 = 5;
            int int2 = 10;
            int int3 = int1 * int2;

            //boolean

            bool bool1 = 10>2;

            //veriable transformations

            string str20 = "20";
            int int20 = 20;

            string newVal = str20 + int20.ToString();
            Console.WriteLine(newVal); // 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // 40

            int int22 = int20 + int.Parse(str20); // 40

            // datetime

            string datetime = DateTime.Now.ToString("dd/MM/yyyy");
            string hour = DateTime.Now.ToString("HH:mm");

            Console.WriteLine(datetime);
            Console.WriteLine(hour);

        }
    }
}
