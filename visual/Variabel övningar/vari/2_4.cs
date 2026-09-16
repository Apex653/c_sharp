using System;

namespace _2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal: ");
            double tal = double.Parse(Console.ReadLine());
            Console.Writeline("Skriv in ett tal till: ");
            double tal2 = double.Parse(Console.ReadLine());

            double summa = tal + tal2;
            double produkt = tal * tal2;
            Console.WriteLine("Summan av talen är: " + summa);
            Console.WriteLine("Produkten av talen är: " + produkt);






        }
    }
}
