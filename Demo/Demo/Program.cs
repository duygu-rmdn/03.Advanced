using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double machine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int toyCount = 0;
            int money = 0;
            int item = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    toyCount++;
                }
                else
                {
                    item += 10;
                    money += item;
                    money -= 1;
                }
            }

            money += toyCount * toyPrice;
            if (money >= machine)
            {
                Console.WriteLine("Yes! {0:f2}", (money - machine));
            }
            else
            {
                Console.WriteLine("No! {0:f2}", (machine - money));
            }








            //int n = int.Parse(Console.ReadLine());
            //int max = int.MinValue;
            //int min = int.MaxValue;
            //for (int i = 0; i < n; i++)
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    if (num > max)
            //    {
            //        max = num;
            //    }
            //    if (num < min)
            //    {
            //        min = num;
            //    }
            //}
            //Console.WriteLine(max);
            //Console.WriteLine(min);
            //double n = double.Parse(Console.ReadLine());
            //double p1 = 0;
            //double p2 = 0;
            //double p3 = 0;
            //double p4 = 0;
            //double p5 = 0;


            //for (int i = 0; i < n; i++)
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    if (num < 200)
            //    {
            //        p1++;
            //    }
            //    else if (num < 400 && num > 199)
            //    {
            //        p2++;
            //    }
            //    else if (num < 600 && num > 399)
            //    {
            //        p3++;
            //    }
            //    else if (num < 800 && num > 599)
            //    {
            //        p4++;
            //    }
            //    else
            //    {
            //        p5++;
            //    }

            //}
            //double p11 = p1 / n * 100;
            //double p12 = p2 / n * 100;
            //double p13 = p3 / n * 100;
            //double p14 = p4 / n * 100;
            //double p15 = p5 / n * 100;
            //Console.WriteLine("{0:f2}%", p11 );
            //Console.WriteLine("{0:f2}%", p12 );
            //Console.WriteLine("{0:f2}%", p13 );
            //Console.WriteLine("{0:f2}%", p14 );
            //Console.WriteLine("{0:f2}%", p15 );
        }
    }
}
