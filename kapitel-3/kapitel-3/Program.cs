using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapitel_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            double d = 1.25;
            string s = "Hallo";
            char c = 'x';

            //Console.WriteLine(i);
            //Console.WriteLine("Integer: " + i + " double: " + d);
            //Console.WriteLine("Zeichenkette: " + s + "Zeichen: " + c);
            //Console.ReadKey();

            //Console.WriteLine("Integer: {0}  double: {1} \a", i, d);
            //Console.WriteLine("Zeichenkette: {0} Zeichen: {1} \a", s, c);
            //Console.ReadKey();
            if (i is int)
            {
                Console.WriteLine("i ist ein Int, Yeah");
            }

            if (s is string)
            {
                Console.WriteLine("s ist ein String, Yuhuuuuu");
            }
            Console.ReadKey();

        }
    }
}
