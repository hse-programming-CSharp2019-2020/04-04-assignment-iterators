using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Необходимо построить ряд чисел Фибоначчи, ограниченный числом, введенным с клавиатуры.
 * 
 * Пример входных данных:
 * 6
 * Пример выходных данных:
 * 1 1 2 3 5
 * Пояснение:
 * следующее число 3 + 5 = 8 не выводится на экран, так как 8 > 6.
 * 
 * В случае ввода некорректных данных выбрасывайте ArgumentException.
 * 
*/
namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int value = // int.Parse(Console.ReadLine());
                foreach (int el in Fibonacci(value))
                {
                    Console.Write(el + " ");
                }
            }
            catch (ArgumentException)
            {
                Console.Write("error");
            }
            //Console.ReadKey();
        }

        public static IEnumerable<int> Fibonacci(int maxValue)
        {
            //yield return 1;
            //yield return 1;

            //var last = 1;
            //var beforeLast = 1;

            //while (last + beforeLast <= maxValue)
            //{
            //    var current = last + beforeLast;
            //    beforeLast = last;
            //    last = current;

            //    yield return current;
            //}
        }
    }
}
