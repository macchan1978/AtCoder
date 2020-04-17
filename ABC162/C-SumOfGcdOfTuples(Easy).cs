using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace ConsoleTest
{
    static partial class Program
    {
        static int max = 200;
        static int[] _gcd;
 
        static int Idx(int a, int b)
        {
            if (a >= b)
            {
                return (a - 1) * max + (b - 1);
            }
            return (b - 1) * max + (a - 1);
        }
 
        static int Gcd(int l, int r)
        {
            if (r == 0)
            {
                return l;
            }
 
            var idx = Idx(l, r);
            if (_gcd[idx] != 0) return _gcd[idx];
 
            _gcd[idx] = Gcd(r, l % r);
            return _gcd[idx];
        }
 
        static int Gcd(int a, int b, int c)
        {
            var g = Gcd(a, b);
            return Gcd(g,c);
        }
 
 
        static void Main(string[] args)
        {
 
            var n = Int();
            long sum = 0;
            _gcd = new int[max * max];
            for (int i = 1; i <= n; ++i)
                for (int j = 1; j <= n; ++j)
                    for (int k = 1; k <= n; ++k)
                    {
                        int gcd = Gcd(i, j, k);
                        sum += gcd;
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