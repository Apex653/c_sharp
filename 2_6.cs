using System;

namespace _2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal: ");
            double tal = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ett tal till: ");
            double tal2 = double.Parse(Console.ReadLine());

            double medelvärde = (tal + tal2) / 2;
            Console.WriteLine("Medelvärdet av talen är: " + medelvärde);




        }
    }
}
