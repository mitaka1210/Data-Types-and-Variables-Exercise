using System;

namespace _01.Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstNumber = int.Parse(Console.ReadLine());

            int secondNumber = int.Parse(Console.ReadLine());

            int thirdNumber = int.Parse(Console.ReadLine());

            int fourNumber = int.Parse(Console.ReadLine());

            int summNumbers = firstNumber + secondNumber;

            int devideNumbers = summNumbers / thirdNumber;


            int multiplyNumbers = devideNumbers * fourNumber;

            Console.WriteLine(multiplyNumbers);


        }
    }
}
