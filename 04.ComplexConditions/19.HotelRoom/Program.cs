using System;

namespace _19.HotelRoom
{
    class Program
    {
        static void Main()
        {
            string month = Console.ReadLine();
            double nights = int.Parse(Console.ReadLine());
            double pricePerNightStudio = 0;
            double pricePerNightAppartment = 0;

            switch (month)
            {
                case "October":
                case "May":
                    pricePerNightStudio = 50;
                    pricePerNightAppartment = 65;
                    break;
                case "June":
                case "September":
                    pricePerNightStudio = 75.2;
                    pricePerNightAppartment = 68.7;
                    break;
                case "July":
                case "August":
                    pricePerNightStudio = 76;
                    pricePerNightAppartment = 77;
                    break;
            }

            double priceStudio = 0;
            double priceAppartment = 0;
            if (nights > 14)
            {
                if (month == "May" || month == "October")
                {
                    priceStudio = nights * (pricePerNightStudio - pricePerNightStudio * 0.3);
                }

                else if (month == "June" || month == "September")
                {
                    priceStudio = nights * (pricePerNightStudio - pricePerNightStudio * 0.2);
                }

                else
                {
                    priceStudio = nights * pricePerNightStudio;
                }
                priceAppartment = nights * (pricePerNightAppartment - pricePerNightAppartment * 0.1);
            }

            else if (nights > 7)
            {
                if (month == "May" || month == "October")
                {
                    priceStudio = nights * (pricePerNightStudio - pricePerNightStudio * 0.05);
                }

                else
                {
                    priceStudio = nights * pricePerNightStudio;
                }
                priceAppartment = nights * pricePerNightAppartment;
            }

            else
            {
                priceAppartment = nights * pricePerNightAppartment;
                priceStudio = nights * pricePerNightStudio;
            }



            Console.WriteLine($"Apartment: {priceAppartment:F2} lv.");
            Console.WriteLine($"Studio: {priceStudio:F2} lv.");
        }
    }
}
