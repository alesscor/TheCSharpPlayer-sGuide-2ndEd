using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz {
    class Program {
        static void Main(string[] args) {
            for(int number = 0; number <= 100; number++) {
                /**
                 divisor 3 divisor 5
                         0         0
                         0         1
                         1         0
                         1         1
                */
                if (number % 3 == 0 && number % 5==0) {
                    Console.WriteLine("FizzBuzz");
                }else if (number % 3 == 0 && number % 5!=0) {
                    Console.WriteLine("Fizz");
                }else if (number % 3 != 0 && number % 5==0) {
                    Console.WriteLine("Buzz");
                } else {
                    Console.WriteLine($"{number}");
                }
            }
            Console.ReadKey();
        }
    }
}
