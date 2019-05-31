using System;

namespace _02.Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine()); // четем едно число

            int summOfDigits = 0; // събираме цялата сума на цифрите 2+4+5+6+7+8 = 32
            int lastDigits ;
            
            while (number != 0)
            {
                lastDigits = number % 10; // тук получаваме последните цифри и числото става  2+4+5+6+7;
                summOfDigits += lastDigits;
                number = number / 10;
            }
            Console.WriteLine(summOfDigits);

        }
    }
}
