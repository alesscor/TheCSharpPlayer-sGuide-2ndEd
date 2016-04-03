using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator {
    class Program {
        static void Main(string[] args) {
            double theResult = 0.0;
            bool isValidOperator = true;

            // Asks the user for a two numbers first and second
            Console.Write("Enter the first number: ");
            string firstNumberAsAString = Console.ReadLine();
            double firstNumber = Convert.ToDouble(firstNumberAsAString);
            Console.Write("Enter the second number: ");
            string secondNumberAsAString = Console.ReadLine();
            double secondNumber = Convert.ToDouble(secondNumberAsAString);

            // Asks the user for an operator to apply between the first and second number
            // to be chosen from: +,-,*,/ and ^
            Console.WriteLine("Enter an operator to be applied to the numbers so the result = <first> operator <second>: ");
            Console.Write("Please choose from +, -, *, /, ^, P=^: ");
            char theOperator = Console.ReadKey().KeyChar;
            switch (theOperator) {
                case '+':
                    theResult = firstNumber + secondNumber;
                    break;
                case '-':
                    theResult = firstNumber - secondNumber;
                    break;
                case '*':
                    theResult = firstNumber * secondNumber;
                    break;
                case '/':
                    if (secondNumber == 0) {
                        theResult = double.PositiveInfinity;
                        isValidOperator = false;
                    } else {
                        theResult = firstNumber / secondNumber;
                    }
                    break;
                case 'P':
                case '^':
                    theResult = Math.Pow(firstNumber, secondNumber);
                    break;
                default:
                    theResult = double.PositiveInfinity;
                    isValidOperator = false;
                    break;
            }
            // Lets the user know the result
            Console.Write($"\nThe result from operating <{firstNumber}> {theOperator} <{secondNumber}>");
            Console.WriteLine($"is: {( isValidOperator ? $"{theResult}" : "«Undefined»")}");

            Console.ReadKey();
        }
    }
}
