using System;
namespace _16.Voyage
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            if (budget < 10 || budget > 5000)
            {
                return;
            }
            string season = Console.ReadLine();
            double sum = 0;


            if (budget > 1000)
            {
                sum = budget * 0.9;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {sum:F2}");
            }

            else if (budget > 100)
            {
                if (season == "summer")
                {
                    sum = budget * 0.4;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {sum:F2}");
                }

                else
                {
                    sum = budget * 0.8;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {sum:F2}");
                }
            }

            else
            {
                if (season == "summer")
                {
                    sum = budget * 0.3;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {sum:F2}");
                }

                else
                {
                    sum = budget * 0.7;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {sum:F2}");
                }
            }
        }
    }
}
