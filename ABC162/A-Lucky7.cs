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
            var s = Console.ReadLine();
            if(s[0]=='7' || s[1]=='7'||s[2]=='7')
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
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