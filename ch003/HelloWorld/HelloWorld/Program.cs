/*
 Declares from which libraries we are going to take reusable resources.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Defines the namespace that groups the HelloWorld example's resources: its class(es) and its method(s)
namespace HelloWorld{
    // Defines our first C# program.
    class Program{
        static void Main(string[] args){
            // the first c# lines I've added ever <3<3<3<3<3:
            // Console.WriteLine("Hello Dear World!!!");
            Console.WriteLine("I'm sorry, Dave. I'm affraid I can't do that.");
            if (args.Length > 0){
                Console.WriteLine($"{args[0]}!!!");
            }
            Console.ReadKey();
        }
    }
}
