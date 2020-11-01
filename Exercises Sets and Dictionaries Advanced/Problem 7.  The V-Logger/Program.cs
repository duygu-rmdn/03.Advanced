using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_7.__The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            HashSet<Vloger> vlogers = new HashSet<Vloger>();
            while (input[0] != "Statistics")
            {
                if (input[1] == "joined")
                {
                    Vloger newVloger = new Vloger(input[0]);
                    if (!vlogers.Any(v => v.Name == newVloger.Name))
                    {
                        vlogers.Add(newVloger);
                    }
                }
                else if (input[1] == "followed")
                {
                    var following = input[0];
                    var followed = input[2];
                    if (following != followed && vlogers.Any(v => v.Name == following) && vlogers.Any(v => v.Name == followed))
                    {
                        Vloger vlogger1 = vlogers.Where(v => v.Name == following).FirstOrDefault();
                        vlogger1.AddFollowing(followed);

                        Vloger vlogger2 = vlogers.Where(vlogers => vlogers.Name == followed).FirstOrDefault();
                        vlogger2.AddFollower(following);
                    }
                }

                input = Console.ReadLine().Split();
            }
            int max = int.MinValue;
            foreach (var item in vlogers)
            {
                if (item.Followers.Count > max)
                {
                    max = item.Followers.Count;
                }
            }
            Console.WriteLine($"The V-Logger has a total of {vlogers.Count} vloggers in its logs.");
            Vloger famous = vlogers.Where(v => v.Followers.Count == max).FirstOrDefault();
            Console.WriteLine($"1. {famous.Name} : {famous.Followers.Count} followers, {famous.Following.Count} following");
            foreach (var item1 in famous.Followers)
            {
                Console.WriteLine($"*  {item1}");
            }
            vlogers.Remove(famous);
            vlogers.OrderByDescending(x => x.Followers.Count).ThenBy(x => x.Followers.Count);
            int counter = 2;
            foreach (var item in vlogers)
            {
                Console.WriteLine($"{counter}. {item.Name} : {item.Followers.Count} followers, {item.Following.Count} following");
                
                counter++;
            }
        }
    }
    public class Vloger
    {
        public string Name { get; set; }
        public SortedSet<string> Followers { get; set; }
        public HashSet<string> Following { get; set; }

        public Vloger(string name)
        {
            this.Name = name;
            this.Followers = new SortedSet<string>();
            this.Following = new HashSet<string>();
        }
        public void AddFollower(string name)
        {
            Followers.Add(name);
        }
        public void AddFollowing(string name)
        {
            Following.Add(name);
        }
    }
}