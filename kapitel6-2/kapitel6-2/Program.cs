using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapitel6_2
{
    //class CPerson
    //{
    //    private string name;

    //    public void initName()
    //    {
    //        name = "BRUNATA";
    //    }

    //    public void WriteName()
    //    {
    //        Console.WriteLine(name);
    //    }

    //    public string GetName()
    //    {
    //        return name;
    //    }

    //}

    class CVerweis
    {
        private int x;
        public int GetValue()
        {
            return x;
        }
        public void SetValue(int param)
        {
            x = param;
        }
    }

    class CTest
    {
        //call by Value
        public void Werteuebergabe(CVerweis param)
        {
            param.SetValue(10);
            param = new CVerweis();
            param.SetValue(30);
        }

        //call by reference
        public void Referenzuebergabe(ref CVerweis param)
        {
            param.SetValue(10);
            param = new CVerweis();
            param.SetValue(30);
        }

        //call by reference mit out
        public void Referenceubergabe_2(out CVerweis param)
        {
            param = new CVerweis();
            param.SetValue(30);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //string einName;

            //CPerson einePerson = new CPerson();
            //einePerson.initName();
            ////einePerson.WriteName();
            //einName = einePerson.GetName();
            //Console.WriteLine(einName);
            //Console.ReadKey();

            CTest einTest = new CTest();
            CVerweis einVerweis = new CVerweis();

            einVerweis.SetValue(0);
            einTest.Werteuebergabe(einVerweis);
            Console.WriteLine(einVerweis.GetValue());

            einVerweis.SetValue(0);
            einTest.Referenzuebergabe(ref einVerweis);
            Console.WriteLine(einVerweis.GetValue());

            einVerweis.SetValue(0);
            einTest.Referenceubergabe_2(out einVerweis);
            Console.WriteLine(einVerweis.GetValue());
            Console.ReadKey();
        }
    }
}
