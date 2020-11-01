using System;

namespace DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string startData = Console.ReadLine();
            string endData = Console.ReadLine();
            DateModifier dateModifire = new DateModifier();
            var result = dateModifire.GetDaysDifference(startData, endData);
            Console.WriteLine(Math.Abs(result));
        }
    }
}
