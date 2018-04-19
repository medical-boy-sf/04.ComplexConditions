using System;

namespace _12.Volleyball
{
    class Program
    {
        static void Main()
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double weekendInSofia = (48 - h) * 3 / 4.0;
            double holidaysSofia = p * 2.0 / 3;
            double total = weekendInSofia + holidaysSofia + h;
            double bonus = 0;

            if (year == "leap")
            {
                bonus = 0.15 * total;
            }

            total = total + bonus;

            Console.WriteLine($"{Math.Floor(total)}");




        }
    }
}
