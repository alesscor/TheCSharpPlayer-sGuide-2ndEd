using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("I'm about to go into a method.");
            DoSomethingAwesome();
            Console.WriteLine("I'm back from the method.");
            Console.ReadKey();
        }
        static void DoSomethingAwesome() {
            Console.WriteLine("I'm inside of a method! Awesome!!!");
        }
    }
}
