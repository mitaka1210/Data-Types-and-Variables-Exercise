using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {

            int startingYieldOfSource = int.Parse(Console.ReadLine());
            int crewConsumesSpice = 0;//produced
            int days = 0;


            //  int yieldDrops = 0;

            //int spiceEveryDay = startingYieldOfSource - crewConsumesSpice;

            //int endOfDayIsLeft = startingYieldOfSource - yieldDrops;
            if (startingYieldOfSource < 100)
            {
                Console.WriteLine(days);
                Console.WriteLine(crewConsumesSpice);
            }
            else
            {
                while (startingYieldOfSource >= 100)
                {
                    crewConsumesSpice += startingYieldOfSource - 26;
                    startingYieldOfSource -= 10;
                    days++;
                }

                crewConsumesSpice -= 26;

                Console.WriteLine(days);
                Console.WriteLine(crewConsumesSpice);



            }
        }
    }
}
