using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> effects = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToList() );

            Stack<int> casing = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToList());

            int datura = 0;
            int cherry = 0;
            int smoke = 0;
            int decrease = 0;
            bool fulled = false;
            while (effects.Count > 0 && casing.Count > 0)
            {
                int currEffect = effects.Peek();
                int currCasing = casing.Peek();
                int sum = currCasing + currEffect - decrease;
                bool isBomb = false;
                if (sum  == 40)
                {
                    datura++;
                    isBomb = true;
                    decrease = 0;
                }
                else if (sum == 60)
                {
                    cherry++; 
                    isBomb = true;
                    decrease = 0;
                }
                else if (sum == 120)
                {
                    smoke++;
                    isBomb = true;
                    decrease = 0;
                }
                else
                {
                    decrease += 5;
                }
                if (isBomb)
                {
                    casing.Pop();
                    effects.Dequeue();
                }
                if (datura >= 3 && cherry >= 3 && smoke >= 3)
                {
                    fulled = true;
                    break;
                }
            }
            if (fulled)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            if (effects.Count > 0)
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", effects)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            if (casing.Count > 0)
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", casing)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            Console.WriteLine($"Cherry Bombs: {cherry}");
            Console.WriteLine($"Datura Bombs: {datura}");
            Console.WriteLine($"Smoke Decoy Bombs: {smoke}");
        }
    }
}
