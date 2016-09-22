﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapitel_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double kapital, prozentsatz, zinsen;

            Console.Write("Bitte dein Kapital eingeben: ");
            kapital = Convert.ToDouble(Console.ReadLine());

            Console.Write("Bitte deine Zinsen eingeben: ");
            zinsen = Convert.ToDouble(Console.ReadLine());

            if (kapital == 0)
            {
                Console.WriteLine("Fehler! Dein Kapital darf nicht 0 sein.");
            }
            else
            {
                prozentsatz = zinsen * 100 / kapital;
                Console.WriteLine("Dein Prozentsatz liegt bei: {0}%", prozentsatz);
            }
            Console.ReadKey();
        }
    }
}
