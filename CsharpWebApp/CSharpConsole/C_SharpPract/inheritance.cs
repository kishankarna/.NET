using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole
{
    class parent {
      
        //void m1() { //by default it is private
        public void m1() { 
            Console.WriteLine("This is m1 method from child class");
        }
    }
    class inheritance : parent

    {
        static void Main(string[] args)
        {
            inheritance ob = new inheritance();
            ob.m1();
            Console.ReadKey();
        }
    }
}
