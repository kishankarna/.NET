using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole
{
   public class AccessModifierMethods
    {
        public void m1() {
            Console.WriteLine("This is public method");
        }

        private void m2() {
            Console.WriteLine("This is private method");
        }

        internal void m3() {
            Console.WriteLine ("This is internal method");
        }

        protected void m4() {
            Console.WriteLine("This is protected method");
        }
        protected internal void m5()
        {
            Console.WriteLine ("This is protected internal method");
        }
        
        static void Main() {
            AccessModifierMethods ob = new AccessModifierMethods();

            ob.m1();
            ob.m2();
            ob.m3();
            ob.m4();
            ob.m5();
            Console.ReadKey();
        }
    }
}
