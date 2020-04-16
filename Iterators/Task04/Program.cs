using System;
using System.Collections;

/* На вход подается число N.
 * Нужно создать коллекцию из N квадратов последовательного ряда натуральных чисел 
 * и вывести ее на экран дважды. Элементы коллекции разделять пробелом. 
 * Выводы всей коллекции разделять переходом на новую строку.
 * Не хранить всю коллекцию в памяти.
 * 
 * Код, данный в условии, НЕЛЬЗЯ стирать, его можно только дополнять.
 * Не использовать yield и foreach. Не вызывать метод Reset() в классе Program.
 * 
 * Пример входных данных:
 * 3
 * 
 * Пример выходных данных:
 * 1 4 9
 * 1 4 9
 * 
 * В случае ввода некорректных данных выбрасывайте ArgumentException.
*/
namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int value = // int.Parse(Console.ReadLine());
                MyInts myInts = new MyInts();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("error");
            }
            IEnumerator enumerator = myInts.MyEnumerator(value);

            IterateThroughEnumeratorWithoutUsingForeach(enumerator);
            Console.WriteLine();
            IterateThroughEnumeratorWithoutUsingForeach(enumerator);
            //Console.ReadKey();
        }

        static void IterateThroughEnumeratorWithoutUsingForeach(IEnumerator enumerator)
        {
            //while (enumerator.MoveNext())
            //{
            //    Console.Write(enumerator.Current + " ");
            //}
        }
    }

    class MyInts : IEnumerator // НЕ МЕНЯТЬ ЭТУ СТРОКУ
    {
        //int index = 0;
        //int N;
        
        //public IEnumerator MyEnumerator(int N)
        //{
            //this.N = N;
            //return this;
        //}
        
        public bool MoveNext()
        {
            //if (index == N)
            //{
            //    Reset();
            //    return false;
            //}

            //index++;
            //return true;
        }

        //public void Reset()
        //{
        //    index = 0;
        //}

        public object Current
        {
            //get {
            //    return index * index;
            //}
        }
    }
}
