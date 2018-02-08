using System;
using System.Collections.Generic;

namespace CSharpConsole.nikson
{
    class nikson
    {
        static List<data> person = new List<data>();
        static void Main()
        {
            //Console.WriteLine("Enter person name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter Address: ");
            //string address = Console.ReadLine();
            //Console.WriteLine("Enter Phone: ");
            //string phone = Console.ReadLine();

            person.Add(new data("Karna"));
            person.Add(new data("Nikson"));
            person.Add(new data("Nanu"));

            foreach( var kk in person)
                Console.WriteLine(kk.name);

            Console.ReadKey();
        }


    }

    class data {
        public string name;
        public data(string pname) {
            this.name = pname;

        }
    }
}
