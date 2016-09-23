using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapitel_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verweis auf neues Objekt anlegen und Speicher zuordnen
            Class1 objektVerweis = new Class1();
            //Zugriff auf die Variablen in der Class1
            objektVerweis.x = 2;
            //Fehler da private
            objektVerweis.s = "Hey";
        }
    }
}
