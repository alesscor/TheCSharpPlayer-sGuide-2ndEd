using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveOrNegative {
    class Program {
        static void Main(string[] args) {
            int theSign = 0; // 0: positive, 1: negative
            double theResult = 0;
            // Get two numbers to multiply
            Console.Write("Enter the first number: ");
            string firstNumberAsAString = Console.ReadLine();
            double firstNumber = Convert.ToDouble(firstNumberAsAString);
            Console.Write("Enter the second number: ");
            string secondNumberAsAString = Console.ReadLine();
            double secondNumber = Convert.ToDouble(secondNumberAsAString);
            // Get information on the input
            /**
                  00 positive positive=>positive
                  01 positive negative=>negative
                  10 negative positive=>negative
                  11 negative negative=>positive
            */
            if ((firstNumber >= 0 && secondNumber >= 0) || (firstNumber < 0 && secondNumber < 0)) {
                theSign = 0;
            } else {
                theSign = 1;
            }
            theResult = firstNumber * secondNumber;
            // Let know the results including the name of the sign
            Console.WriteLine($"The result is {theResult:0.0000}, and the sign is {((theSign == 0) ? "positive" : "negative")}.");
            Console.ReadKey();
        }
    }
}
