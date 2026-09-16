using System;


namespace övning_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin i meter?");
            double Elin = double.Parse(Console.ReadLine());
            Console.WriteLine("Hur långt hoppade Alma i meter?");
            double Alma = double.Parse(Console.ReadLine());

            double skillnad = Elin - Alma;
            Console.WriteLine($"Elin hoppade {skillnad} längre än Alma");










        }
    }
}
