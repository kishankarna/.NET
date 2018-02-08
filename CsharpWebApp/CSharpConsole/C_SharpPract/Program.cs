using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole
{
    class Program
    {
        int a = 10;
        public Program() {
            
        }
        public Program(int i) {
            this.a = i;
        }

        static void Main(string[] args)
        {
            Program ob = new Program();
            Program ob1 = new Program(22);
            Program ob2 = new Program(12);
            Console.WriteLine("A value in constructor is : "+ob.a );
            Console.WriteLine("A value in constructor is : " +ob1.a );
            Console.WriteLine("A value in constructor is : " + ob2 .a);
            Console.WriteLine("A value in constructor is : " + ob.a);

            Console.ReadKey();
        }
    }
}
