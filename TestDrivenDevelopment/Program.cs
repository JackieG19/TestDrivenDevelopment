using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("Wonderful Life Jackie"));
			Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("life wonderful jackie"));
			Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("Jackie life wonderful"));
			
			Console.Read();
        }
    }
}
