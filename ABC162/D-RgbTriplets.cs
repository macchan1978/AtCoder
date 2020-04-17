using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace ConsoleTest
{
    static partial class Program
    {
        static int[] _ss;
        static int[] FromString(string src)
        {
            var result = new int[src.Length];
            for(int i = 0; i <src.Length; ++i)
            {
                result[i] = src[i] == 'R' ? 0 : (src[i] == 'G' ? 1 : 2);
            }
 
            return result;
        }
 
        static int[] CreateRandomItems()
        {
            var rnd = new Random();
            int num = 2000;
            var result = new int[num];
            for(int i=0;i < num; ++i)
            {
                result[i] = rnd.Next()%3;
            }
            return result;
        }
 
        static int[] FindTrg(int a)
        {
            return new int[] { (a + 1) % 3, (1 + 2) % 3 };
        }
 
        static int FindTrg2(int a, int b)
        {
            if(a>b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }
            if (a == 0 && b == 1) return 2;
            if (a == 0 && b == 2) return 1;
            if (a == 1 && b == 2) return 0;
            throw new ArgumentException();
        }
 
        static void Main(string[] args)
        {            
            _ = Int();
            int[] _s = FromString(Console.ReadLine());
            //_s = CreateRandomItems();
            var len = _s.Length;
            _ss = new int[len];
            var sums = new int[3];
            for(int i = len-1; i >= 0; --i)
            {
                sums[_s[i]]++;
                _ss[i] = sums[_s[i]];
            }
            //Console.WriteLine(string.Join(",", _ss.Select(s => s.ToString())));
 
            long sum=0;
            for (int i = 0; i < len; ++i)
            {
                int[] trg1 = FindTrg(_s[i]);
                for (int j = i + 1; j < len; ++j)
                {
                    if (_s[j] == _s[i]) continue;
                    int dist = j - i;
                    int trg2 = FindTrg2(_s[i], _s[j]);
                    for (int k = j + 1; k < len; ++k)
                    {
                        if (_s[k] != trg2) continue;
                        int val = _ss[k];
 
                        if (dist + j < len && _s[j + dist] == _s[k]) val--;
                        sum += val;
                        break;
                    }
                }
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