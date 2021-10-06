using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whatWillCodeOutput
{
    class Program
    {
        public static void ChangeValue(int value)
        {
            value = 2;
        }

        static void Main(string[] args)
        {
            int a = 5;
            ChangeValue(a);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}