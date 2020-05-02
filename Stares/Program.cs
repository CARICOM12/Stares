using System;

namespace Stares
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // enter a number
            Console.Write("Please enter a number ");
            int number = Convert.ToInt32(Console.ReadLine());
            //if a number is less than a zero print a message and quit
            if(number == 0)
            {
                Console.WriteLine("The number is equal to zero");
                return;
            }
            Console.Write("Please enter a symbol ");
            char ch = (char)Console.Read();
            Console.WriteLine();
            //Print symbol (ch variable) as many times as number variable in a row

            if (number > 0)
            {
                /* наш цикл */
                // ширина ступенек изменяется от 1 до переменной number 
                for (int j = 1; j <= number; j++)
                {
                    for (int i = 1; i <= j; i++)
                    {
                        Console.Write(ch);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                /* новый цикл для отрицательных чисел */
                // ширина ступенек изментся от number до 1 
                for (int j = -number; j >= 1; j--)
                {
                    for (int i = 1; i <= j; i++)
                    {
                        Console.Write(ch);
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
