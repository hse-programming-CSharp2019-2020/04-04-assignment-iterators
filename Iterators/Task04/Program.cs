using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());
            MyInts myInts = new MyInts();
            IEnumerator enumerator = myInts.MyEnumerator(value);

            while (enumerator.MoveNext())
            {
                Console.Write(enumerator.Current + " ");
            }
            Console.WriteLine();
            while (enumerator.MoveNext())
            {
                Console.Write(enumerator.Current + " ");
            }
            Console.ReadKey();
        }
    }

    class MyInts : IEnumerator
    {
        int index = 0;
        int N;
        
        public IEnumerator MyEnumerator(int N)
        {
            this.N = N;
            return this;
        }
        
        public bool MoveNext()
        {
            if (index == N)
            {
                Reset();
                return false;
            }

            index++;
            return true;
        }

        public void Reset()
        {
            index = 0;
        }

        public object Current
        {
            get {
                return index * index;
            }
        }
    }
}
