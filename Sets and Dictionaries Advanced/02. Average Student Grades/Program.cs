using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] names = Console.ReadLine().Split().ToArray();
                string curr = names[0];
                double grade = double.Parse(names[1]);
                if (!grades.ContainsKey(curr))
                {
                    grades.Add(curr, new List<double>());
                }
                grades[curr].Add(grade);
            }
            foreach (var item in grades)
            {
                Console.Write($"{item.Key} -> ");
                foreach (var grade in item.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {(item.Value.Average()):f2})");
            }
        }
    }
}
