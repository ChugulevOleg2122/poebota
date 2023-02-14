using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int exit = 1;

            while (exit == 1  )
            {
                Console.WriteLine("Введите число от 1 до 30");
                int num = Convert.ToInt32(Console.ReadLine());



                switch (num)
                {

                    case var s when new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }.Contains(s):
                        Console.WriteLine("1-ая декада");
                        exit = 0;
                        break;
                    case var s when new[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }.Contains(s):
                        Console.WriteLine("2-ая декада");
                        exit = 0;
                        break;
                    case var s when new[] { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 }.Contains(s):
                        Console.WriteLine("3-ая декада");
                        exit = 0;
                        break;
                    default:
                        Console.WriteLine("Вы ввели не правильное число, оно не входит в промежуток от 1 до 30 ");
                        break;
                }
            }*/


            int a = 10;
            int b = 20;
            int c = 30;
            double i = 0;

            //Console.WriteLine("Введите число i от 1 до 30: ");
            //i = Convert.ToDouble(Console.ReadLine());

            while (i <= 0 || i > c)
            {
                Console.WriteLine("Введите число i, которое входит в диапозон от 1 до 30: ");
                i = Convert.ToDouble(Console.ReadLine());
            }

                if (i <= a)
                {
                    Console.WriteLine("Число i определилась в первую декаду");
                    
                }
                else if (i > a && i <= b)
                {
                    Console.WriteLine("Число i определилась во вторую декаду");
                    
                }
                else if (i > b && i <= c)
                {
                    Console.WriteLine("Число i определилась в третью декаду");
                    
                }
                
                
            


            Console.ReadKey();


        }
    }
}