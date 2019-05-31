using System;

namespace _03._Elevators
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfPeople = int.Parse(Console.ReadLine());

            int capacity = int.Parse(Console.ReadLine());

            double courses = Math.Ceiling((double)numberOfPeople / capacity); // важното  е на къде закръглеме в тази задача.

            Console.WriteLine(courses);


        }
    }
}
