using System;


namespace CSharpConsole
{
    class inh4 {
        public  inh4(int a, int b) {
            Console.WriteLine("The multiplication of {0} and {1} is : {2}",a,b,a*b);
        }
        public void m1() { Console.WriteLine("This is method from parent class"); }
    }
    class inheritance4: inh4
    {
        public inheritance4(int a, int b) : base(a,b) {

        }
        static void Main(string[] args)
        {
            inheritance4 ob = new inheritance4(12,4);
            Console.ReadKey();

        }
    }
}
