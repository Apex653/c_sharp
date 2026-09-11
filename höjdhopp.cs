using System;


namespace Variabel_övningar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur högt kan du hoppa i höjdhopp mätt i meter?");
            string höjd1 = Console.ReadLine();
            double höjd2 = double.Parse(höjd1);
            double skillnad = 2.45 - höjd2;

            Console.WriteLine("Världsrekordet i höjdhopp är " + skillnad + " meter högre .");


                





        }
    }
}
