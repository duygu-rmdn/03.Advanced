using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> peoples = Console.ReadLine()
                .Split()
                .ToList();

            string command = Console.ReadLine();
            List<string> filters = new List<string>();
            while (command != "Print")
            {
                string[] spleted = command.Split(";");
                string operation = spleted[0];
                string filter = spleted[1];
                string argument = spleted[2];

                if (operation == "Add filter")
                {
                    filters.Add($"{filter};{argument}");
                }
                else if(operation == "Remove filter")
                {
                    filters.Remove($"{filter};{argument}");
                }

                command = Console.ReadLine();
            }
            foreach (var item in filters)
            {
                string[] splited = item.Split(";");
                string filterType = splited[0];
                string argument = splited[1];

                if (filterType == "Starts with")
                {
                    peoples = peoples.Where(p => !p.StartsWith(argument)).ToList();
                }
                else if (filterType == "Ends with")
                {
                    peoples = peoples.Where(p => !p.EndsWith(argument)).ToList();
                }
                else if (filterType == "Length")
                {
                    peoples = peoples.Where(p => p.Length != int.Parse(argument)).ToList();
                }
                else if(filterType == "Contains")
                {
                    peoples = peoples.Where(p => !p.Contains(argument)).ToList();
                }

            }
            Console.WriteLine(string.Join(" ", peoples));

        }
    }
}
