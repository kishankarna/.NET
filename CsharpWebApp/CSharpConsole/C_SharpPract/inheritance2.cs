using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole
{
    class parent1 {
        public parent1() {
            Console.WriteLine("This is parent class constructor");
        }
        public void m1() {
            Console.WriteLine("Hello this is m1 method of parent class");
        }
    }
    class inheritance2 : parent1 
    {
        public inheritance2() {
            Console.WriteLine("This is child class constructor");
        }
        public void m2() {
            Console.WriteLine("This is m2 method from chil class ");
        }
        static void Main(string[] args)
        {
            //inheritance2 ob = new inheritance2();
            //ob.m1();
            parent1 ob = new inheritance2();
            ob.m1();
                       
            Console.ReadKey();
        }
    }
}
