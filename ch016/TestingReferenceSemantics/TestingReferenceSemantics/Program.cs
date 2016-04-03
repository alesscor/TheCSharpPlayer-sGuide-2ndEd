using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingReferenceSemantics {
    class Program {
        static void Main(string[] args) {
            string aString = "one value";
            Console.WriteLine($"the value is: {aString}");
            SecondMethod(aString);
            Console.WriteLine($"the value is: {aString}");
            Console.ReadKey();
        }
        static void SecondMethod(string arg) {
            arg=arg.Insert(arg.Length,"_tail"); // this makes arg to point another string in the heap
            Console.WriteLine($"the value is: {arg}");
        }
    }
}
