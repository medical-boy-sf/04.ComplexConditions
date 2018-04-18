using System;

namespace _01.PersonalTitles
{
    class Program
    {
        static void Main()
        {
            double age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());

            if (gender == 'm')
            {
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }

                else
                {
                    Console.WriteLine("Master");
                }
            }

            else
            {
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }

                else
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}
