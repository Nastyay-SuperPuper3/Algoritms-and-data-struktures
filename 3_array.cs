using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(4);
                if (array[i] == 0)
                {
                    array[i] = 2;
                }
                Console.WriteLine(array[i]);
            }
            */
            /*
            int count = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[count];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
            */

            /*
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-7, 10);
            }

            int maxMinus = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < maxMinus)
                {
                    maxMinus = array[i];
                }
            }
            if (maxMinus == 0)
            {
                Console.WriteLine("Элемента нет");
            }
            else
            {
                Console.WriteLine($"Элемент {maxMinus}");
            }
            */

            /*
            int[] array = new int[10];
            int sumNumbers = 0;
            int productNumbers = 0;
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-6, 10);
            }
            for (int i = 0; i < array.Length; i++)
            {
                sumNumbers += array[i];
                productNumbers *= array[i];
            }
            Console.WriteLine($"Сумма: {sumNumbers} Произведение: {productNumbers}");
            */

            /*
            int[] array = new int[10];
            int sumNumbers = 0;
            int productNumbers = 0;
            Random random = new Random();
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = random.Next(0, 39);
            }
            int lastNumber = Convert.ToInt32(Console.ReadLine());
            int position = Convert.ToInt32(Console.ReadLine());
            if (position >= 0 && position < array.Length)
            {
                for (int i = array.Length - 1; i > position; i--)
                    array[i] = array[i - 1];
            }
            else
            {
                position = array.Length - 1;
            }
            array[position] = lastNumber;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            */

            /*
            int[] array = new int[20];
            Random random = new Random();
            short countPos = 0;
            short countNeg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-6, 10);
                if (array[i] >= 0)
                {
                    countPos++;
                }
                else
                {
                    countNeg++;
                }
            }
            short curIndexPos = 0;
            short curIndexNeg = 0;
            int[] arrayPos = new int[countPos];
            int[] arrayNeg = new int[countNeg];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    arrayPos[curIndexPos] = array[i];
                    curIndexPos++;
                }
                else
                {
                    arrayNeg[curIndexNeg] = array[i];
                    curIndexNeg++;
                }
            }

            Console.WriteLine("Положительные ");
            for (int i = 0; i < arrayPos.Length; i++)
            {
                Console.Write($"{arrayPos[i]} ");
                if (i == arrayPos.Length - 1)
                {
                    Console.Write("\n");
                }
            }
            Console.WriteLine("Отрицательные ");
            for (int i = 0; i < arrayNeg.Length; i++)
            {
                Console.Write($"{arrayNeg[i]} ");
            }
            */

            /*
            {
                int[] arr = new int[10];
                Random rnd = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(-7, 9);
                    if (arr[i] > 0)
                    {
                        Console.WriteLine(i);
                    }

                }
            */
        }
    }   
}
