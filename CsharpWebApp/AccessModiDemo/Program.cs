using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModiDemo
{
    class Program: CSharpConsole.AccessModifierMethods 
    {
        static void Main(string[] args)
        {
            Program k = new Program();
            k.m1();
            k.m4();
            k.m5();
            Console.ReadKey();
        }
    }
}
