using System;
using System.Collections;

/* На вход подается число N.
 * На каждой из следующих N строках записаны имя и фамилия человека, 
 * разделенныые одним пробелом.
 * Используя собственноручно написанный итератор, выведите имена людей,
 * отсортированные в лексико-графическом порядке в формате 
 *      <Фамилия_с_большой_буквы> <Заглавная_первая_буква_имени>.
 * Затем выведите имена людей в исходном порядке.
 * 
 * Код, данный в условии, НЕЛЬЗЯ стирать, его можно только дополнять.
 * 
 * Пример входных данных:
 * 3
 * Bill Banana
 * Alex Apple
 * Clark Carrot
 * 
 * Пример выходных данных:
 * Apple A.
 * Banana B.
 * Carrot C.
 * 
 * Banana B.
 * Apple A.
 * Carrot C.
 * 
 * В случае ввода некорректных данных выбрасывайте ArgumentException.
*/
namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int N = // int.Parse(Console.ReadLine());
                Person[] people = new Person[N];
            }
            catch (ArgumentException)
            {
                Console.Write("error");
            }
            //for (int i = 0; i < N; i++)
            //{
            //    string[] arr = Console.ReadLine().Split();
            //    people[i] = new Person(arr[0], arr[1]);
            //}
            
            People peopleList = new People(people);
            
            foreach (Person p in peopleList)
                Console.WriteLine(p);

            foreach (Person p in peopleList.People)
                Console.WriteLine(p);

            //Console.Read();
        }
    }

    public class Person//: IComparable<Person>
    {
        public string firstName;
        public string lastName;

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        //public int CompareTo(Person other)
        //{
        //    return this.ToString().CompareTo(other.ToString());
        //}

        //public override string ToString()
        //{
        //    return lastName + " " + firstName[0] + ".";
        //}
    }


    public class People : IEnumerable
    {
        private Person[] _people;
        public Person[] People
        {
            get {
                return _people;
            }
        }
        //public People(Person[] pArray)
        //{
        //    _people = new Person[pArray.Length];

        //    for (int i = 0; i < pArray.Length; i++)
        //    {
        //        _people[i] = pArray[i];
        //    }
        //}

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(_people);
        }
    }
    
    public class PeopleEnum : IEnumerator
    {
        public Person[] _people;

        //int position = -1;

        //public PeopleEnum(Person[] list)
        //{
        //    _people = (Person[])list.Clone();
        //    Array.Sort(_people);
        //}

        public bool MoveNext()
        {
            //position++;
            //return (position < _people.Length);
        }

        public void Reset()
        {
            //position = -1;
        }

        //object IEnumerator.Current
        //{
        //    get {
        //        return Current;
        //    }
        //}

        public Person Current
        {
            //get {
            //    try
            //    {
            //        return _people[position];
            //    }
            //    catch (IndexOutOfRangeException)
            //    {
            //        throw new InvalidOperationException();
            //    }
            //}
        }
    }
}
