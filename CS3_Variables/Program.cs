using System;

namespace CS3_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание");
            int num1 = 20;
            int num2 = 5;
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 % num2);
            Console.WriteLine();

            Console.WriteLine("Задание 1");
            int x = 10, y = 12, z = 3;
            Console.WriteLine(x += y - x++ * z);
            Console.WriteLine(z = --x - y * 5);
            Console.WriteLine(y /= x + 5 % z);
            Console.WriteLine(z = x++ + y * 5);
            Console.WriteLine(x = y - x++ * z);

            Console.WriteLine("\nЗадание 2");
            int a = 6, b = 13, c = 4;
            double result = (double)(a + b + c) / 3;
            Console.WriteLine("{0:F2}", result);

            Console.WriteLine("\nЗадание 3");
            const double pi = 3.141592653D;
            double r = pi * Math.Sqrt(30);
            Console.WriteLine(r);

            Console.WriteLine("\nЗадание 4");
            double h = 15;
            double V = pi * Math.Sqrt(17) * h;
            double S = 2 * pi * Math.Sqrt(17) * (17 + h);
            Console.WriteLine($"Объём:\t\t{V}\nПлощадь:\t{S}");

            //Console.WriteLine("\nЗадание 5");
            //int uberflu?;
            //int _Identifier;
            //int \u006fIdentifier;
            //int &myVar;
            ///int myVariab1le;

            Console.ReadKey();
        }
    }
}
