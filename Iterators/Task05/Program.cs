using System;
using System.Collections;

/* На вход подается число N.
 * Нужно создать коллекцию из N кубов последовательного ряда натуральных чисел 
 * и вывести ее на экран ТРИЖДЫ. Инвертировать порядок элементов при каждом последующем выводе.
 * Элементы коллекции разделять пробелом. 
 * Очередной вывод коллекции разделять переходом на новую строку.
 * Не хранить всю коллекцию в памяти.
 * 
 * Код, данный в условии, НЕЛЬЗЯ стирать, его можно только дополнять.
 * Не использовать yield и foreach. Не вызывать метод Reset() в классе Program.
 * 
 * Пример входных данных:
 * 3
 * 
 * Пример выходных данных:
 * 1 8 27
 * 27 8 1
 * 1 8 27
 * 
 * В случае ввода некорректных данных выбрасывайте ArgumentException.
*/
namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int value =  //int.Parse(Console.ReadLine());
                MyInts myInts = new MyInts();
                IEnumerator enumerator = myInts.MyEnumerator(value);

                IterateThroughEnumeratorWithoutUsingForeach(enumerator);
                Console.WriteLine();
                IterateThroughEnumeratorWithoutUsingForeach(enumerator);
                Console.WriteLine();
                IterateThroughEnumeratorWithoutUsingForeach(enumerator);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("error");
            }

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
        //bool increasedOrder = true;

        //public IEnumerator MyEnumerator(int N)
        //{
        //    this.N = N;
        //    return this;
        //}

        public bool MoveNext()
        {
            //if (increasedOrder && index == N || (!increasedOrder) && index == 1)
            //{
            //    Reset();
            //    increasedOrder = !increasedOrder;
            //    return false;
            //}

            //if (increasedOrder)
            //    index++;
            //else
            //    index--;

            //return true;
        }

        //public void Reset()
        //{
        //    if (increasedOrder)
        //        index = N + 1;
        //    else
        //        index = 0;
        //}

        public object Current
        {
            //get {
            //    return index * index * index;
            //}
        }
    }
}
