using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            string biggerKegModel = String.Empty;

            double biggerVolume = 0;

            //тук завъртаме един цикъл с броя на кеговете който са ни подадени
            for (int i = 0; i < number; i++)
            {
                //Въвеждаме данните за кега модел радиус височина
                string model = Console.ReadLine();

                double beerKegRadius = double.Parse(Console.ReadLine());

                int beerKegHeight = int.Parse(Console.ReadLine());

                //тук изчисляваме по формулата размерите на кега
                double singelVolumeKeg = Math.PI * beerKegRadius * beerKegRadius * beerKegHeight;

                //тук проверяваме кой е най-големия кег и го отпечатваме
                if (singelVolumeKeg > biggerVolume)
                {
                    biggerVolume = singelVolumeKeg;
                    biggerKegModel = model;

                }
            }
            Console.WriteLine(biggerKegModel);
        }
    }
}
//3
//Keg 1
//10
//10
//Keg 2
//20
//20
//Keg 3
//10
//30
