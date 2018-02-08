using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole
{
    class VariablesExmp
    {// The only difference:static variable can be modified but const variable can not be modified
        const int a = 100;  //It maintains only one copy through out the life. Fixed value for whole class
        static int b = 200; //Maintains one copy for whole class and can be modified
        // readonly variable
        readonly int c=12;// it maintains copy for each instance, It is fixed value specific to an instance of class
        //can be initialized in constructor as well //once initialized then its value can not be modified

        //instance variable
        int d = 300;//multiple copy //modification available

        public static void Main() {
           //instance creation not required
            Console.WriteLine("Constant variable : "+a);
            Console.WriteLine("static variable : "+b);
            
            // for instance and readonly variables instance creation is requied
            VariablesExmp ob = new VariablesExmp();
            Console.WriteLine("Instance variable: " + ob.d);
            Console.WriteLine("readonly variable : " + ob.c);
            Console.ReadKey();
        }
    }
}
