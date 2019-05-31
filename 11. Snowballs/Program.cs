using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bestSnow = 0;
            int bestTime = 0;
            int bestQuality = 0;
            BigInteger bestValue = 0;
            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue =BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue >= bestValue)
                {
                    bestValue =snowballValue;
                    bestSnow = snowballSnow;
                    bestTime = snowballTime;
                    bestQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
        }
        
          
    }
}
//https://pastebin.com/uKb8JusH
//Трябва ти list от big integer, степента може да стигне 1000, и числото става доста голямо, при този тест.
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;
//using System.Text;
//using System.Threading.Tasks;

//namespace _01.Problem
//{

//    class Program
//    {

//        static void Main(string[] args)
//        {
//            int numberOfSnowballs = int.Parse(Console.ReadLine());

//            List<Tuple<double, double, BigInteger, double>> listOfValues = new List<Tuple<double, double, BigInteger, double>>();

//            for (int i = 0; i < numberOfSnowballs; i++)
//            {
//                double snowballSnow = double.Parse(Console.ReadLine());
//                double snowballTime = double.Parse(Console.ReadLine());
//                int snowballQuality = int.Parse(Console.ReadLine());

//                BigInteger numberOfThrows = (BigInteger)(snowballSnow / snowballTime);

//                BigInteger snowballValue = BigInteger.Pow(numberOfThrows, snowballQuality);

//                var tuple4Parts = new Tuple<double, double, BigInteger, double>
//                      (snowballSnow, snowballTime, snowballValue, snowballQuality);

//                listOfValues.Add(tuple4Parts);
//            }

//            var highestSnowBallValue = listOfValues.OrderByDescending(x => x.Item3).First();
//            Console.WriteLine($"{highestSnowBallValue.Item1} : {highestSnowBallValue.Item2} = {highestSnowBallValue.Item3} ({highestSnowBallValue.Item4})");

//        }

//    }
//}