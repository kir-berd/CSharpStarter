using System;

namespace CS4_Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Задание 1");
            Translator.Translate();*/

            /*Console.WriteLine("Задание 2");
            Console.Write("Введите оператор 1: ");
            int operator1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите оператор 2: ");
            int operator2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите знак: ");
            string sign = Console.ReadLine();
            int result = 0;
            switch (sign)
            {
                case "+":
                    result = operator1 + operator2;
                    break;
                case "-":
                    result = operator1 - operator2;
                    break;
                case "*":
                    result = operator1 * operator2;
                    break;
                case "/":
                    if (operator1 == 0 || operator2 == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя!");
                    }
                    else
                    {
                        result = operator1 / operator2;
                    }
                    break;
            }
            Console.WriteLine($"Результат: {result}");*/

            Console.WriteLine("\nЗадание 3");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number >= 0 && number <=14)
            {
                Console.WriteLine("0-14");
            }
            else if(number >= 15 && number <= 35)
            {
                Console.WriteLine("15-35");
            }
            else if (number >= 36 && number <= 50)
            {
                Console.WriteLine("36-50");
            }
            else if (number >= 50 && number <= 100)
            {
                Console.WriteLine("50-100");
            }
            else
            {
                Console.WriteLine("Out of range");
            }

            Console.ReadKey();
        }
    }
}
