using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //РАБОТА С МАССИВАМИ
            
           Console.Write("Введите длину массива при условие что он должен быть больше 10: ");
            int ArrayLength = Convert.ToInt32(Console.ReadLine());

            while (ArrayLength < 10)
            {
                Console.Write("Введите длину массива еще раз: ");
                ArrayLength = Convert.ToInt32(Console.ReadLine());
            }

            int[] Array = new int[ArrayLength];
            
            Random rand = new Random();

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = rand.Next(-20, 20);
                Console.WriteLine($"Число в массиве {i + 1} = {Array[i]}");

            }

            Console.WriteLine("\nПроверка на отрицательные числа\n");
            
            for (int j = 0; j < Array.Length; j++)
            {
                if (Array[j] < 0)
                {
                    Console.WriteLine($"Число {Array[j]} отрицательное. Возведем ее в степень 2");
                }

            }

            Console.WriteLine("\nВозведение чисел в квадрат\n");

            for (int g = 0; g < ArrayLength; g++)
            {
                if (Array[g] < 0)
                {
                    Array[g] = Convert.ToInt32(Math.Pow(Array[g], 2));
                    Console.WriteLine($"Получим {Array[g]}");
                }
            }

            Console.WriteLine($"\nвывод массива\n");

            for (int f = 0; f < Array.Length; f++)
            {
                Console.Write($"{Array[f]} ");
            }
            
            Console.ReadLine();
            
            
            //РАБОТА С FOR
            
            int numberOf = 0;
            int numberMinus = 0;
            int i;
            Console.WriteLine("Введите количество желаемых чисел: ");
            int numbers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Начните вводить желаемые числа: ");

            for ( i = 0; i < numbers; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    numberMinus += number;
                    numberOf += 1;
                }

                
            }

            Console.WriteLine("\nВы ввели все числа!\n");
            Console.WriteLine("Теперь компьютер произведен несколько действий, " +
                                "\nкоторые помогут определить количество и сумму отрицательных чисел\n");
            Console.WriteLine($"Сумма отрицательных чисел равна {numberMinus}. " +
                                $"\nКоличество отрицательных чисел равно {numberOf}");

            Console.ReadKey();




        }
    }
}
