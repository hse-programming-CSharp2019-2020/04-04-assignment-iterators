using System;
using System.Collections;

/* На вход подается число N.
 * Нужно создать коллекцию из N элементов последовательного ряда натуральных чисел, возведенных в 10 степень, 
 * и вывести ее на экран ТРИЖДЫ. Инвертировать порядок элементов при каждом последующем выводе.
 * Элементы коллекции разделять пробелом. 
 * Очередной вывод коллекции разделять переходом на новую строку.
 * Не хранить всю коллекцию в памяти.
 * 
 * Код, данный в условии, НЕЛЬЗЯ стирать, его можно только дополнять.
 * Не использовать yield и foreach. Не вызывать метод Reset() в классе Program.
 * 
 * Пример входных данных:
 * 2
 * 
 * Пример выходных данных:
 * 1 1024
 * 1024 1
 * 1 1024
 * 
 * В случае ввода некорректных данных выбрасывайте ArgumentException.
 * В других ситуациях выбрасывайте 
*/
namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //long value =  long.Parse(Console.ReadLine());
                MyDigits myDigits = new MyDigits();
                IEnumerator enumerator = myDigits.MyEnumerator(value);

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
            catch (ArithmeticException)
            {
                Console.WriteLine("ooops");
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

    class MyDigits : IEnumerator // НЕ МЕНЯТЬ ЭТУ СТРОКУ
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

        //public object Current
        //{
            //get {
            //    return (long)Math.Pow(index, 10);
            //}
        //}
    }
}
