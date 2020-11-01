using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            People = new List<Person>();
        }
        public List<Person> People { get; set; }
        public void AddMember(Person member)
        {
            People.Add(member);
        }
        public Person GetOldestMember()
        {
            //int max = int.MinValue;
            //Person person = null;
            //foreach (var item in People)
            //{
            //    var curr = item.Age;
            //    if (curr > max)
            //    {
            //        max = curr;
            //        person = item;
            //    }
            //}
            //return person;


            Person[] oldest = People.OrderByDescending(x => x.Age).ToArray();
            return oldest[0];

        }
        public Person[] GetPeople()
        {
            var people = People.Where(x => x.Age > 30).OrderBy(x => x.Name).ToArray();
            return people;

        }
    }
}
