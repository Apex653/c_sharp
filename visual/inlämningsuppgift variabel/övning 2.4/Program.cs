using System;

    namespace övning_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej din startavgift för att hyra bilen är 300 kr.");
            Console.WriteLine("Hur många dagar vill du hyra bilen?");
            int dagar = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många kilometer behöver du köra?");
            int kilometer = int.Parse(Console.ReadLine());
            Console.WriteLine($"Du kommer att hyra bilen i {dagar} dagar och köra {kilometer} kilometer.");
            int kostnad = 300 + 500 * (dagar - 1) + 1 * (kilometer);
            Console.WriteLine($"Din totala kostnad kommer att bli {kostnad} kr.");









        }
    }
}












