using System;
// static method examles

namespace CSharpConsole
{
    class karna {

       public  static int Multiply(int a, int b) {
            return a * b;
        }

       public static int Add(int a, int b) {
            return a + b;
        }

    }
    class staticMethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Tha multiplication of {0} and {1} is : {2} ",2,5,karna.Multiply(2, 5));
            Console.WriteLine("The addition of {0} and {1} is : {2} ",100,200,karna.Add(100, 200));
            Console.ReadKey();
        }
    }
}
