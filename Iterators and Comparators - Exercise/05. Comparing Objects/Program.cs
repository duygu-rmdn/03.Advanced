using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Comparing_Objects
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<Person> peopleHashSet = new HashSet<Person>();
            SortedSet<Person> peopleSortedSet = new SortedSet<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] personArg = Console.ReadLine().Split().ToArray();
                string name = personArg[0];
                int age = int.Parse(personArg[1]);

                Person p = new Person(name, age);
                peopleHashSet.Add(p);
                peopleSortedSet.Add(p);
            }
            Console.WriteLine(peopleSortedSet.Count);
            Console.WriteLine(peopleHashSet.Count);
        }
    }
}
