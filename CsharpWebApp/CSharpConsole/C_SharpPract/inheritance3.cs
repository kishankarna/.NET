using System;

//When there is parameterized constructor in parent class
namespace CSharpConsole
{
    class inh3 {
        public inh3(int a) { Console.WriteLine("This is parent constructor"); }
        public void m1() { Console.WriteLine("This is method from parent class"); }
    }
    class inheritance3 : inh3 
    {
        public inheritance3 (): base(10) {          //static way
        //public inheritance3(int a) : base(a) {    //dynamic way

        }
        static void Main()
        {
            inheritance3 ob = new inheritance3();       //static way
            //inheritance3 ob = new inheritance3 (13);  //dynamic way
            ob.m1();
            Console.ReadLine();
        }
    }
}
