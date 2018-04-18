using System;
namespace _08.TradeComission
{
    class Program
    {
        static void Main()
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commission = 0;

            if (city == "Sofia")
            {
                if (sales > 10000)
                {
                    commission = 0.12;
                }

                else if (sales > 1000)
                {
                    commission = 0.08;
                }

                else if (sales > 500)
                {
                    commission = 0.07;
                }

                else if (sales > 0)
                {
                    commission = 0.05;
                }

                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }

            else if (city == "Varna")
            {
                if (sales > 10000)
                {
                    commission = 0.13;
                }

                else if (sales > 1000)
                {
                    commission = 0.10;
                }

                else if (sales > 500)
                {
                    commission = 0.075;
                }

                else if (sales > 0)
                {
                    commission = 0.045;
                }

                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }

            else if (city == "Plovdiv")
            {
                if (sales > 10000)
                {
                    commission = 0.145;
                }

                else if (sales > 1000)
                {
                    commission = 0.12;
                }

                else if (sales > 500)
                {
                    commission = 0.08;
                }

                else if (sales > 0)
                {
                    commission = 0.055;
                }

                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }

            else
            {
                Console.WriteLine("error");
                return;
            }

            double total = sales * commission;
            Console.WriteLine($"{total:F2}");
        }
    }
}
