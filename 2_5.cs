using System;

namespace _2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket år är det?");
            int år = int.Parse(Console.ReadLine());
            int nu = 2100;
            int skillnad = år - nu;
            Console.WriteLine("det är " + skillnad + " år kvar till 2100");





        }
    }
}
