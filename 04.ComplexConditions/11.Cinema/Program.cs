using System;

namespace _11.Cinema
{
    class Program
    {
        static void Main()
        {
            string typeProjection = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int seats = r * c;
            double priceProjection = 0;
            double total = 0;

            switch (typeProjection)
            {
                case "Premiere":
                    priceProjection = 12.0;
                    break;
                case "Normal":
                    priceProjection = 7.5;
                    break;

                case "Discount":
                    priceProjection = 5;
                    break;
            }
            total = seats * priceProjection;

            Console.WriteLine($"{total:F2} leva");
        }
    }
}
