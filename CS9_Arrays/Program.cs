using System;

namespace CS9_Arrays
{
    class Program
    {
        #region Additional Task

        static void AdditionalTask()
        {
            var arrayTask1 = new int[10];

            Console.Write("Массив:");
            for (int i = 0; i < arrayTask1.Length; i++)
            {
                arrayTask1[i] = i << 4;
                Console.Write("  " + arrayTask1[i]);
            }

            Console.Write("\nМассив в обратном порядке:");
            for (int i = arrayTask1.Length - 1; i >= 0; i--)
            {
                Console.Write("  " + arrayTask1[i]);
            }

            Console.WriteLine();
        }

        #endregion

        #region Task 2

        static void Task2()
        {
            var length = 15;
            var arrayT2 = CreateAndFillArray(length);
            int minVal = default,
                maxVal = default,
                sumElements = 0;

            foreach (var i in arrayT2)
            {
                Console.WriteLine(i);
                if (minVal > i || minVal == 0) minVal = i;
                if (maxVal < i || maxVal == 0) maxVal = i;
                sumElements += i;
            }

            int middleArithmetics = sumElements / length;

            Console.WriteLine(
                $"Минимальное значение: {minVal}.\n" +
                $"Максимальное значение: {maxVal}\n" + 
                $"Сумма всех элеменетов: {sumElements}\n" +
                $"Среднее арифметическое: {middleArithmetics}\n");

            ShowOdd(arrayT2);
            Console.WriteLine();
        }

        static int[] CreateAndFillArray(int lengthArray, int minValue = 1, int maxValue = 100)
        {
            var array = new int[lengthArray];
            var rand = new Random();

            for (var i = 0; i < lengthArray; i++)
            {
                array[i] = rand.Next(minValue, maxValue);
            }

            return array;
        }

        static void ShowOdd(int[] array)
        {
            Console.Write("Нечетные числа: ");
            foreach (var item in array)
            {
                if (item % 2 == 1) Console.Write($"  {item}");
            }
        }

        #endregion

        #region Task 3

        static void Task3()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] reverseArray = MyReverse(array);
            int[] subArr = SubArray(array, 2, 6);

            foreach (var i in subArr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
        }

        static int[] MyReverse(int[] array)
        {
            int[] myArray = array;
            int[] reverseArray = new int[array.Length];

            for (int i = myArray.Length - 1, j = 0; i >= 0; i--, j++)
            {
                reverseArray[j] = myArray[i];
            }

            return reverseArray;
        }

        static int[] SubArray(int[] array, int index, int count)
        {
            int[] newArray = new int[count];

            for (int i = index, j = 0; j < count; j++, i++)
            {
                if (j > (array.Length - 1) - index)
                {
                    newArray[j] = 1;
                }
                else
                {
                    newArray[j] = array[i];
                }
            }

            return newArray;
        }

        #endregion

        #region Task 4

        static void Task4()
        {
            int[] arrayT4A = { 1, 2, 3, 4, 5, 6 };
            int value = 94;

            int[] arrayT4B = MyShift(arrayT4A, value);
            int[] arrayT4C = MyPush(arrayT4A, value);

            foreach (var i in arrayT4B)
            {
                Console.WriteLine(i);
            }
        }

        static int[] MyShift(int[] array, int value)
        {
            var newArray = new int[array.Length + 1];

            for (var i = 0; i < newArray.Length; i++)
            {
                if (i == 0)
                {
                    newArray[i] = value;
                }
                else
                {
                    newArray[i] = array[i - 1];
                }
            }

            return newArray;
        }

        static int[] MyPush(int[] array, int value)
        {
            var newArray = new int[array.Length + 1];

            for (var i = 0; i < newArray.Length; i++)
            {
                if (i == newArray.Length - 1)
                {
                    newArray[i] = value;
                }
                else
                {
                    newArray[i] = array[i];
                }
            }

            return newArray;
        }

        #endregion

        static void Main(string[] args)
        {
            //AdditionalTask();
            //Task2();
            Task3();
            //Task4();
        }
    }
}
