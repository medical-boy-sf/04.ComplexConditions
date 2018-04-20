using System;

namespace Demo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool isOnBorderHor = (y == 0 && x >= 0 && x <= 3 * h) || (y == h && ((x >= 0 && x <= h) || (x >= 2 * h && x <= 3 * h))) || (x == 0 && y >= 0 && y <= h) || (x == 3 * h && y >= 0 && y <= h);
            bool isOnBorderVer = (x == h && y >= h && y <= 4 * h) || (x == 2 * h && y >= h && y <= 4 * h) || (y == 4 * h && x >= h && x <= 2 * h);
            bool isInsideHor = (x > 0 && x < 3 * h && y > 0 && y < h);
            bool isInsideVer = (x > h && x < 2 * h && y >= h && y <= 4 * h);

            if (isOnBorderHor || isOnBorderVer)
            {
                Console.WriteLine("Border");
            }

            else if (isInsideHor || isInsideVer)
            {
                Console.WriteLine("Inside");
            }

            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
