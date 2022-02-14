using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if(time >= 6 && time < 11)
                Console.WriteLine("Günaydın!");
            else if(time <= 18)
                Console.WriteLine("İyi Günler..");
            else
                Console.WriteLine("İyi geceler...");

            string sonuc = time >= 6 && time < 12 ? "Good Morning!" : time <= 17 ? "Good Afternoon!" : "Good Night!";
            Console.WriteLine(sonuc);
        }
    }
}
