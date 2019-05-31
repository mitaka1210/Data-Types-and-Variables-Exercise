using System;

namespace _07.Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfLines = int.Parse(Console.ReadLine());
            int volumeOfTank = 255;
            int litterInTank = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                int incomingLitters = int.Parse(Console.ReadLine());

                if (litterInTank + incomingLitters <= volumeOfTank)//
                {
                    litterInTank += incomingLitters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(litterInTank);
        }
    }
}
