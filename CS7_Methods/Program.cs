using System;

namespace CS7_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Additional task
            //Console.WriteLine("Additional task: ");

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            // int c = Convert.ToInt32(Console.ReadLine());

            // Calculate(a, b, c);

            #endregion

            #region Task 2
            /*Console.WriteLine("\nTask 2");

            Console.WriteLine("Введите значения в формате: операнд1 знак операнд2");
            int a = Convert.ToInt32(Console.ReadLine());
            string sign = Console.ReadLine();
            int b = Convert.ToInt32(Console.ReadLine());*/

            /*switch (sign)
            {
                case "+":
                    {
                        Add(a, b);
                        break;
                    }
                case "-":
                    {
                        Sub(a, b);
                        break;
                    }
                case "*":
                    {
                        Mul(a, b);
                        break;
                    }
                case "/":
                    {
                        Div(a, b);
                        break;
                    }
            }*/

            #endregion

            #region Task 3

            /*Console.WriteLine("Введи сумму денег: ");
            double sum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введи курс для конвертации");
            double course = Convert.ToDouble(Console.ReadLine());

            ConvertMoney(sum, course);

            Console.WriteLine(ConvertMoney(sum, course));*/

            #endregion

            #region Task 4



            #endregion
        }

        static void Calculate(int a, int b, int c)
        {
            Console.WriteLine($"Среднее арифметическое чисел {a}, {b} и {c} = {(a + b + c) / 3}");
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        static void Div(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                Console.WriteLine("Попытка деления на ноль!");
            }
            else
            {
                Console.WriteLine(a / b);
            }
        }

        static double ConvertMoney(double a, double b)
        {
            return a * b;
        }

        static void 
    }
}
