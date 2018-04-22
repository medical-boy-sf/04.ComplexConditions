using System;

namespace _17.OperationWithNumbers
{
    class Program
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char oprt = char.Parse(Console.ReadLine());
            int result = 0;

            //if ((n1 < 0 || n1 > 40000) || n2 < 0 || n2 > 40000)
            //{
            //    return;
            //}

            if (false)
            {

            }

            else
            {
                if (oprt == '+')
                {
                    result = n1 + n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} {oprt} {n2} = {result} - even");
                    }

                    else
                    {
                        Console.WriteLine($"{n1} {oprt} {n2} = {result} - odd");
                    }
                }

                else if (oprt == '-')
                {
                    result = n1 - n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} {oprt} {n2} = {result} - even");
                    }

                    else
                    {
                        Console.WriteLine($"{n1} {oprt} {n2} = {result} - odd");
                    }
                }

                else if (oprt == '*')
                {
                    result = n1 * n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} {oprt} {n2} = {result} - even");
                    }

                    else
                    {
                        Console.WriteLine($"{n1} {oprt} {n2} = {result} - odd");
                    }
                }

                else if (oprt == '/')
                {
                    if (n2 != 0)
                    {

                        double res = n1 / (double)n2;
                        if (result % 2 == 0)
                        {
                            Console.WriteLine($"{n1} {oprt} {n2} = {res:F2}");
                        }

                        else
                        {
                            Console.WriteLine($"{n1} {oprt} {n2} = {res:F2}");
                        }
                    }

                    else
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }

                }

                else if (oprt == '%')
                {
                    if (n2 != 0)
                    {
                        result = n1 % n2;
                        Console.WriteLine($"{n1} {oprt} {n2} = {result}");
                    }

                    else
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }

                }
            }
        }
    }
}
