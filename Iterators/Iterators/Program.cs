using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterators
{
    class IteratorSample : IEnumerable<string>
    {
        string[] values; 
        int start;       

        public IteratorSample(string[] values, int start)
        {
            this.values = values;
            this.start = start;
        }

        //public IEnumerator<string> GetEnumerator()
        //{
        //    for (int index = 0; index < values.Length; index++)
        //        yield return values[(index + start) % values.Length];
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            int startingIndex = //int.Parse(Console.ReadLine());
            string[] values = //Console.ReadLine().Trim().Split();

            try
            {
                foreach (string ob in new IteratorSample(values, startingIndex))
                    Console.Write(ob + " ");
                Console.WriteLine();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("error");
            }
            
            Console.ReadLine();
        }
    }
}
