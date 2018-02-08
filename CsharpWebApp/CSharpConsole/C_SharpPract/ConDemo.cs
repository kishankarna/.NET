using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Constructors in C sharp
//    1. Default Constructor or parameter less constructor
//    2. Parameterized constructor
//    3. Copy Constructor
//    4. static Constructor
//***********************************************************
namespace CSharpConsole
{
    class ConDemo
    {

        static int a;
        int b,c;
        public ConDemo() {  //parameterless constructor
            b = 20;
            Console.WriteLine("This is Regular Constructor, the value of b is " + b);
        }

        public ConDemo(int i) {  //parameterized 
            c = i;
            Console.WriteLine("This is a parameterized constructor, given value is "+i);

        }
        static ConDemo()
        {  //static constructor // first to excute // can not be overloaded
           //also can not be parametreized // implicitly called //responsible for initializing static variables 
            a = 20;
            
            Console.WriteLine( "This is static constructor, The vale of a is {0}",a); 
        }
        public ConDemo(ConDemo obj) {   //copy constructor
            c = obj.c;
            Console.WriteLine("This is copy constructor, The value of c after copying paratermized constructor: "+c);
        }

        static void Main(string[] args)
        {
            // implicitly static constructor is called, which excutes always first
            new ConDemo();                  //parameter less constructor calling
            ConDemo ob= new ConDemo(233);  // parameterized constructor calling
            new ConDemo(ob);               //copy-constructor calling
            Console.ReadKey();
        }
    }
}
