using System;
using System.Collections.Generic;

namespace Demo
{
    public static class MathExp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(MathExp.Max<int>(63, 800, 700));
            Console.WriteLine(MathExp.Max<string>("Almonds", "walnuts", "Pistachios"));

            Console.WriteLine(MathExp.Max(63, 800, 700, 800.1));
            Console.WriteLine(MathExp.Max("Almonds", "walnuts", "Pistachios"));
            Console.Read();
        }
        public static T Max<T>(T first, params T[] values)
            where T : IComparable
        {
            T max = first;
            foreach (T item in values)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }
        public static T Min<T>(T first, params T[] values)
            where T : IComparable
        {
            T mini = first;
            foreach (T item in values)
            {
                if (item.CompareTo(mini) < 0)
                {
                    mini = item;
                }
            }
            return mini;
        }
    }
}