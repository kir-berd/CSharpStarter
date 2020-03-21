using System;

namespace CS5_Logic
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Дополнителные задания

            int s = 0;
            Console.WriteLine("Введите число для проверки:");
            int x = Convert.ToInt32(Console.ReadLine());
            s = x & (x - 1);

            if (s == 0)
            {
                Console.WriteLine("Число являеться степенью двойки.");
            }
            else
            {
                Console.WriteLine("Число не являеться степенью двойки.");
            }

            Console.WriteLine("\nTask 2");
            bool a = true, b = false, c;
            Console.WriteLine(a | b);
            Console.WriteLine(!(!a & !b));

            #endregion

            #region Самостоятельные задания
            /*
            Console.WriteLine("Задача 1");
            int a = 982163;
            byte mask = 0x01;
            int result = a & mask;

            // Variant 1
            if(result == mask)
            {
                Console.WriteLine("Odd");
            }
            else
            {
                Console.WriteLine("Even");
            }

            // Variant 2
            if(a % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            Console.WriteLine("\nЗадача 2");
            int x = 5, y = 10, z = 15;
            //x += y >> x++ * z;
            //z = ++x & y * 5;
            //y /= x + 5 | z;
            //z = x++ & y * 5;
            x = y << x++ ^ z;
            Console.WriteLine($"x = {x}, y = {y}, z = {z}");

            Console.WriteLine("\nЗадача 3");
            int years = 5;
            if (years < 5)
            {
                Console.WriteLine("Премия 15% от ЗП");
            }
            else if (years >= 5 && years < 10)
            {
                Console.WriteLine("Премия 15% от ЗП");
            }
            else if (years >= 10 && years < 15)
            {
                Console.WriteLine("Премия 25% от ЗП");
            }
            else if (years >= 15 && years < 20)
            {
                Console.WriteLine("Премия 35% от ЗП");
            }
            else if (years >= 20 && years < 25)
            {
                Console.WriteLine("Премия 45% от ЗП");
            }
            else if (years >= 25)
            {
                Console.WriteLine("Премия 50% от ЗП");
            }
            */
            #endregion
        }
    }
}
