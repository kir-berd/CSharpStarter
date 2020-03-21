using System;

namespace CS8_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //AdditionalTask();
            //Task2();
            //Console.WriteLine(Factorial(5));
        }

        #region Additional Task

        static void AdditionalTask()
        {
            Console.WriteLine("Addintional Task: ");

            int a = 15,
                b = 8,
                c = 150;

            Calculate(ref a, ref b, ref c);

            Console.WriteLine($"a = {a}, b = {b}, c = {c}\n");
        }

        static void Calculate(ref int a, ref int b, ref int c)
        {
            a /= 5;
            b /= 5;
            c /= 5;
        }

        #endregion

        #region Task 2

        static void Task2()
        {
            Console.WriteLine("Task 2: ");

            ShowInfoAboutCredit();

            Console.WriteLine();
        }

        static void ShowInfoAboutCredit()
        {
            int payments = 7;
            int debt = 700;
            int overpayment = 0;

            while (payments > 0 && debt > 0)
            {
                Console.WriteLine($"Сумма задолженности: {debt}.\nОсталось платежей: {payments}");
                Console.WriteLine($"Введите сумму платежа: ");

                int input = Convert.ToInt32(Console.ReadLine());
                debt -= input;
                if (debt < 0)
                {
                    overpayment = -debt;
                }

                payments--;
            }

            if (payments == 0 && debt > 0)
            {
                Console.WriteLine("Платеж просрочен! Коллекторы уже выехали.");
            }

            if (debt <= 0)
            {
                Console.WriteLine($"Кредит закрыт!");
                Console.WriteLine($"Переплата: {overpayment}");
            }
        }

        #endregion

        #region Task 3

        static int Factorial(int n)
        {
            if (n == 1) return n;

            return n * Factorial(n - 1);
        }

        #endregion
    }
}
