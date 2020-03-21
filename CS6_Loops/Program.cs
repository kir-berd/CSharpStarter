using System;

namespace CS6_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Additional task

            Console.WriteLine("Additional task: ");
            int a = 8, b = 12;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            #region Task 2

            Console.WriteLine("\nTask 2: ");
            int c = 14, d = 20, sum = 0;

            Console.Write($"All even numbers between {c} and {d}: ");
            for (int i = c; i <= d; i++)
            {
                sum += i;

                if (i % 2 == 1)
                {
                    Console.Write("{0} ", i);
                } 
            }
            Console.WriteLine($"\nSum number between {c} and {d} equals {sum}");

            #endregion

            #region Task 3
            Console.WriteLine("\nTask 3: ");

            Console.WriteLine();

            int x = 10;
            int y = 10;
            int z = 1;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.WriteLine();

            int buf = y;

            // Равносторонний треугольник
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < z; k++)
                {
                    Console.Write("*");
                }
                y -= 1;
                z += 2;
                Console.WriteLine();
            }

            z = 1;

            // Ромб
            for (int i = 0; i < (x + x + 1); i++)
            {
                if (i < x)
                {
                    for (int j = 0; j < buf; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < z; k++)
                    {
                        Console.Write("*");
                    }
                    buf -= 1;
                    z += 2;
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j < buf; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < z; k++)
                    {
                        Console.Write("*");
                    }
                    buf += 1;
                    z -= 2;
                    Console.WriteLine();
                }
            }

            #endregion

            #region Task 4
            Console.WriteLine("\nTask 4: ");

            int n = 5, fact = 1, m = n;
            do
            {
                fact *= n--;
            } while (n > 1);
            Console.WriteLine($"Factorial {m}! = {fact}");

            #endregion
        }
    }
}
