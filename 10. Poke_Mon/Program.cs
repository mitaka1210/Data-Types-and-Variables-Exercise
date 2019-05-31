using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {

            int pokePower = int.Parse(Console.ReadLine());

            int distanceBetweenTargets = int.Parse(Console.ReadLine());

            int exhaustionFactor = int.Parse(Console.ReadLine());

            decimal halfPower = pokePower * 0.5m;
            int counter = 0;

            while (pokePower > distanceBetweenTargets)
            {
                pokePower -= distanceBetweenTargets;
                counter++;
                if (pokePower == halfPower && exhaustionFactor > 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(counter);
        }
    }
}

