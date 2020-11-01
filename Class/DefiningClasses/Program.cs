using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                Person person = new Person(input[0], int.Parse(input[1]));
                family.AddMember(person);
            }
            Person[] people = family.GetPeople();
            foreach (var item in people)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");

            }





            //Person person = new Person();
            //Person person1 = new Person(12);
            //Person person2 = new Person("pesho", 21);



            //Person person = new Person("Pesho", 20);
            //Console.WriteLine($"{person.Name} {person.Age}");
            //Person person1 = new Person();
            //person1.Name = "Gosho";
            //person1.Age = 18;
            //Console.WriteLine($"{person1.Name} {person1.Age}");
            //Person person2 = new Person();
            //person2.Name = "Stamat";
            //person2.Age = 43;
            //Console.WriteLine($"{person2.Name} {person2.Age}");
        }
    }
}
