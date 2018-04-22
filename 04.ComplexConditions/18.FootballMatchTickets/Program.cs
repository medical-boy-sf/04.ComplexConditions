using System;

namespace _18.FootballMatchTickets
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numberOfPeople = int.Parse(Console.ReadLine());
            double transportTaxes = 0;
            double priceTickets = 0;
            double leftBudget = 0;

            if (category == "VIP")
            {
                priceTickets = numberOfPeople * 499.99;
            }

            else
            {
                priceTickets = numberOfPeople * 249.99;
            }

            if (numberOfPeople >= 50)
            {
                transportTaxes = budget * 0.25;
            }

            else if (numberOfPeople > 24)
            {
                transportTaxes = budget * 0.4;
            }

            else if (numberOfPeople > 9)
            {
                transportTaxes = budget * 0.5;
            }

            else if (numberOfPeople > 4)
            {
                transportTaxes = budget * 0.6;
            }

            else
            {
                transportTaxes = budget * 0.75;
            }

            leftBudget = budget - transportTaxes;

            if (leftBudget > priceTickets)
            {
                Console.WriteLine($"Yes! You have {leftBudget - priceTickets:F2} leva left.");
            }

            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(leftBudget - priceTickets):F2} leva.");
            }
        }
    }
}
