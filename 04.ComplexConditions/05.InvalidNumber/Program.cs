using System;

namespace _05.InvalidNumber
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());

            if (number != 0)
            {
                if (number > 200 || number < 100)
                {
                    Console.WriteLine("invalid");
                }
            }
        }
    }
}
