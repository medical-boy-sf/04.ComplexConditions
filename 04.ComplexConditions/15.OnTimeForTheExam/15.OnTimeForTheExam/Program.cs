using System;

namespace OnTimeForTheExam
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int hoursExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hoursArrival = int.Parse(Console.ReadLine());
            int minutesArrival = int.Parse(Console.ReadLine());

            int totalMinsExam = hoursExam * 60 + minutesExam;
            int totalMinsArrival = hoursArrival * 60 + minutesArrival;
            int difference = totalMinsExam - totalMinsArrival;

            int hours = Math.Abs(difference / 60);
            int minutes = Math.Abs(difference % 60);

            if (difference < 0)
            {
                Console.WriteLine("Late");
                if (Math.Abs(hours) > 0)
                {
                    Console.WriteLine($"{hours}:{minutes:D2} hours after the start");
                }

                else
                {
                    Console.WriteLine($"{minutes} minutes after the start");
                }
            }

            else
            {
                if (Math.Abs(difference) > 30)
                {
                    if (hours > 0)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
                    }

                    else
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{minutes} minutes before the start");
                    }
                }

                else
                {
                    if (difference!= 0)
                    {
						Console.WriteLine("On time");
                        Console.WriteLine($"{minutes} minutes before the start");
                    }

                    else
                    {
                        Console.WriteLine("On time");
                    }

                }
            }
        }
    }
}
