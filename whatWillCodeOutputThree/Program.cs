﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whatWillCodeOutputThree
{
    class Program
    {
        static void ChangeValue(int[] value)
        {
            value = new int[3];
            value[0] = 2;
        }

        static void Main(string[] args)
        {
            int[] a = new int[] { 5, 1, 7 };
            ChangeValue(a);
            Console.WriteLine(a[0]);
            Console.ReadKey();
        }
    }
}