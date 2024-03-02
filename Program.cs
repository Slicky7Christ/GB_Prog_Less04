
using System.Globalization;
using System.Xml.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Выберите задачу(1, 2, 3):\nЗадача 1\nЗадача 2\nЗадача 3");
        while (true)
        {
            switch (int.Parse(Console.ReadLine()!))
            {
                case 1:
                    Task01();
                    Console.WriteLine("______________________________________________");
                    Console.WriteLine("Выберите задачу:\nЗадача 1\nЗадача 2\nЗадача 3");
                    break;
                case 2:
                    Task02();
                    Console.WriteLine("______________________________________________");
                    Console.WriteLine("Выберите задачу:\nЗадача 1\nЗадача 2\nЗадача 3");
                    break;
                case 3:
                    Task03();
                    Console.WriteLine("______________________________________________");
                    Console.WriteLine("Выберите задачу:\nЗадача 1\nЗадача 2\nЗадача 3");
                    break;
                default:
                    Console.WriteLine("______________________________________________");
                    Console.WriteLine("Неправильный пункт меню!");
                    Console.WriteLine("Выберите задачу:\nЗадача 1\nЗадача 2\nЗадача 3");
                    break;
            }
        }
        /*Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
        Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.*/
        void Task01()
        {
            InputNumbers();
            static void InputNumbers()
            {
                Console.WriteLine("Введите целое число. Для выхода нажмите 'q/Q'");
                string number = Console.ReadLine()!;
                ExtInputNumbers(number);
            }

            static void ExtInputNumbers(string number)
            {
                if (number != "q" && number != "Q")
                {
                    int Num = int.Parse(number);
                    DigitCount(Num);
                }
                else
                {
                    return;
                }

            }

            static void DigitCount(int Num)
            {
                int i = 1, sum = 0, digitCount = (int)Math.Log10(Num) + 1;
                while (i < digitCount + 1)
                {
                    sum += (int)(Num / Math.Pow(10, digitCount - i) % 10);
                    i++;
                }
                Console.WriteLine(sum);
                OutputNumbers(sum);
            }

            static void OutputNumbers(int sum)
            {
                if (sum % 2 == 0)
                    Console.WriteLine($"Сумма цифр числа = {sum} - четная, остановка выполнения задачи");
                else InputNumbers();
            }
        }

        /*Задача 2: Задайте массив заполненный случайными трёхзначными числами.
        Напишите программу, которая покажет количество чётных чисел в массиве.*/
        void Task02()
        {
            Console.Write("Введите размерность массива: ");
            int size = int.Parse(Console.ReadLine()!), count = 0;
            int[] numbers = new int[size];
            RndFillArray();
            OutputCountEvenNum();

            void RndFillArray()
            {
                for (int i = 0; i < size; i++)
                {
                    Random rnd = new Random();
                    numbers[i] = rnd.Next(100, 1000);
                }
            }
            void OutputCountEvenNum()
            {
                foreach (int num in numbers)
                {
                    Console.Write($"{num} ");
                    if (num % 2 == 0) count++;
                }
                Console.WriteLine($"\nКоличество четных чисел в массиве: {count}");
            }
        }

        /*Задача 3: Напишите программу, которая перевернёт одномерный массив 
        (первый элемент станет последним, второй – предпоследним и т.д.)*/
        void Task03()
        {
            Console.Write("Введите размерность массива: ");
            int size = int.Parse(Console.ReadLine()!);
            int[] numbers = new int[size];
            int[] rev_numbers = new int[size];
            RndFillArray();
            Console.Write("Начальный массив: ");
            OutputArray(numbers);
            ReverseArr();
            Console.Write("Новый массив:     ");
            OutputArray(rev_numbers);

            void RndFillArray()
            {
                for (int i = 0; i < size; i++)
                {
                    Random rnd = new Random();
                    numbers[i] = rnd.Next(-1000, 1000);
                }
            }

            void OutputArray(int[] numbers)
            {
                foreach (int num in numbers)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }

            void ReverseArr()
            {
                for (int i = 0; i < size; i++)
                {
                    rev_numbers[i] = numbers[size - i - 1];
                }
            }
        }
    }
}






