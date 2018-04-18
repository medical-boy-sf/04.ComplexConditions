using System;

namespace _07.FruitShop
{
    class Program
    {
        static void Main()
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            switch (fruit)
            {
                case "banana":
                    switch (dayOfWeek)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 2.5;
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 2.7;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                case "apple":
                    switch (dayOfWeek)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 1.2;
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 1.25;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                case "orange":
                    switch (dayOfWeek)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 0.85;
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 0.9;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                case "grapefruit":
                    switch (dayOfWeek)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 1.45;
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 1.60;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                case "kiwi":
                    switch (dayOfWeek)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 2.7;
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 3;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                case "pineapple":
                    switch (dayOfWeek)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 5.5;
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 5.6;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                case "grapes":
                    switch (dayOfWeek)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 3.85;
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 4.2;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }

            double total = price * quantity;

            Console.WriteLine($"{total:F2}");

        }
    }
}
