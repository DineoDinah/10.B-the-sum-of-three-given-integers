﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.B_the_sum_of_three_given_integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(4, 5, 7));
            Console.WriteLine(test(7, 4, 12));
            Console.WriteLine(test(10, 10, 12));
            Console.WriteLine(test(12, 12, 18));
            Console.Read();
        }
        public static int test(int a, int b, int c)
        {

            if (a == b &&  b==c) return  0;

            if (a == b) return c;

            if (a == c) return b;

            if (b == a) return a;

            return a + b + c;
        }


    }
}
