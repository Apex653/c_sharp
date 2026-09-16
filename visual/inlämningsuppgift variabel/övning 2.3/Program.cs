using System;


namespace övning_2._3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vad har anställd 1 för lön?");
            int lon1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Vad har anställd 2 för lön?");
            int lon2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Vad har anställd 3 för lön?");
            int lon3 = int.Parse(Console.ReadLine());
            int medel = (lon1 + lon2 + lon3) / 3;
            Console.WriteLine("Medellönen är " + medel + " kr");
        }
    }
}
