using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace ConsoleTest
{
    static partial class Program
    {
 
        static void Main(string[] args)
        {
            var n = Int();
            long sum=0;
            for(int i = 1; i <= n; ++i)
            {
                if (i % 3 == 0) continue;
                if (i % 5 == 0) continue;
                sum += i;
            }
            Console.WriteLine(sum);
 
        }
 
    }
    static partial class Program
    {
        public static int Int()
        {
            return int.Parse(Console.ReadLine());
        }
        public static int[] Ints()
        {
            return Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
        }
        public static long[] Longs()
        {
            return Console.ReadLine().Split(' ').Select(s => long.Parse(s)).ToArray();
        }
        public static int[][] MultiInts(int num)
        {
            var result = new int[num][];
            for(int i = 0; i < num; ++i)
            {
                result[i] = Ints();
            }
            return result;
        }
        public static T[] MultiItems<T>(int num, Func<string,T> parser)
        {
            var result = new T[num];
            for(int i =0; i < num; ++i)
            {
                result[i] = parser(Console.ReadLine());
            }
            return result;
        }
    }
}