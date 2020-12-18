using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             Random random = new Random(0 4);
             int b = random.Next(4);
             int a = random.Next(4);

             if(a % 2 == 0) {
                 Console.WriteLine($"{a} четное число!");
             } else
             {
                 Console.WriteLine($"{a} нечетное число!");
             }

             if (b % 2 == 0)
             {
                 Console.WriteLine($"{b} четное число!");
             }
             else
             {
                 Console.WriteLine($"{b} нечетное число!");
             }

            */
            /* задача 2
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if ((a >= b) && (a >= c))
            {
                Console.WriteLine($"{b} - наибольшое число");
            }
            else
            if ((b >= a) && (b >= c))
            {
                Console.WriteLine($"{b} - наибольшое число"); 
            }
            else
            if ((c >= a) && (c >= b))
            {
                Console.WriteLine($"{c} - наибольшое число"); 
            };
            */
            /* Задача 3
            Console.WriteLine("Введите радиус:");
            string str1 = Console.ReadLine();
            int R = int.Parse(str1);

            Console.WriteLine("Введите X координату:");
            string str2 = Console.ReadLine();
            int x = int.Parse(str2);

            Console.WriteLine("Введите Y координату:");
            string str3 = Console.ReadLine();
            int y = int.Parse(str3);

            if ((x * x) + (y * y) == R * R)
            {
                Console.WriteLine("Заданная точка лежит на окружности");
            }
            else if ((x * x) + (y * y) < R * R)
            {
                Console.WriteLine("Заданная точка находится внутри круга");
            }
            else if ((x * x) + (y * y) > R * R)
            {
                Console.WriteLine("Заданная точка находится за пределами круга");
            }
            /*
            /* Задача 4
            Random random = new Random();
            int a = random.Next(0, 31);

            switch(a)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    Console.WriteLine($"Число {a} попало в первый числовой диапазон (0,10)");
                    break;
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 19:
                    Console.WriteLine($"Число {a} попало во второй числовой диапазон [10, 20)");
                    break;
                default:
                    Console.WriteLine($"Число {a} попало в третий числовой диапазон [20,30]");
                    break;
            }
            */
            /*
                Console.WriteLine("Введите год: ");
                string str = Console.ReadLine();
                int y = int.Parse(str);
                if (y % 4 != 0)
                    {
                    Console.WriteLine("Обычный год");
                    }
                else if (y % 100 == 0)
                    {
                    Console.WriteLine("Столетие");
                    }
                else if (y % 400 == 0)
                    {
                    Console.WriteLine("Високосный год");
                    }
                else
                    {
                    Console.WriteLine("Обычный год");
                    }

                    }
                */

            /*
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            bool exist = false;
            bool isosceles = false;
            if (a == b || b == c || c == a)
            {
                isosceles = true;
            }
            if (a + b >= c || a + c >= b || b + c >= a)
            {
                exist = true;
            }
            if (exist)
            {
                Console.Write("Треугольник существует");
                if (isosceles)
                    Console.WriteLine(".Равнобедренный треугольник существует");
            }
            */
        }
    }
}

