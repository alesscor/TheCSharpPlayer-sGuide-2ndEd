using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomethingReturnedMethods {
    class Program {
        static private Random random = new Random();
        static void Main(string[] args) {
            // int usersNumber = GetNumberFromUser();
            // Console.WriteLine($"CalculatePlayerScore():{CalculatePlayerScore()}");
            // Count(100);
            // Console.WriteLine(GetRandomInteger());
            // Console.WriteLine(GetRandomInteger());
            // Console.WriteLine(GetRandomInteger());
            // int[] anArray = GenerateArray(15);
            // PrintArray(anArray);
            // ReverseArray(anArray);
            // PrintArray(anArray);
            // Console.WriteLine($"{Factorial(5)}");
            // Console.WriteLine($"{Fibonacci(6)}");
            // TestFibonacci(25);
            // Console.WriteLine($"CalculatePlayerScore(1,2,3,4):{CalculatePlayerScore(1,2,3,4)}");
            int[] anArray = FibonacciArray(25);
            PrintArray(anArray);
            Console.ReadKey();
        }
        static int GetRandomInteger() {
            return random.Next(1, 100);
        }
        static float GetRandomNumber() {
            return 4.385f;
        }
        static int GetNumberFromUser() {
            int usersNumber = 0;
            while(usersNumber < 1 || usersNumber > 10) {
                Console.WriteLine("Enter a number between 1 and 10: ");
                string usersResponse = Console.ReadLine();
                try {
                    usersNumber = Convert.ToInt32(usersResponse);
                } catch (Exception) {
                    usersNumber =0;
                }
            }
            return usersNumber;
        }
        static int CalculatePlayerScore() {
            int livesLeft = 3;
            int underlingsDestroyed = 17;
            int minionsDestroyed = 4;
            int bossesDestroyed = 1;

            // If the player is out of lives, they lose all of their points.
            if (livesLeft == 0) {
                return 0;
            }

            // Otherwise, the player gets 10 points for every underling destroyed, 100 points
            // for every minion destroyed, and 1000 points for every boss destroyed.
            return  underlingsDestroyed*10+
                    minionsDestroyed*100+
                    bossesDestroyed*1000;
        }
        /// <summary>
        /// Returns the player score for the given parameteres.
        /// </summary>
        /// <param name="livesLeft"></param>
        /// <param name="underlingsDestroyed"></param>
        /// <param name="minionsDestroyed"></param>
        /// <param name="bossesDestroyed"></param>
        /// <returns></returns>
        static int CalculatePlayerScore(
                int livesLeft,
                int underlingsDestroyed,
                int minionsDestroyed,
                int bossesDestroyed) {

            // If the player is out of lives, they lose all of their points.
            if (livesLeft == 0) {
                return 0;
            }

            // Otherwise, the player gets 10 points for every underling destroyed, 100 points
            // for every minion destroyed, and 1000 points for every boss destroyed.
            return underlingsDestroyed * 10 +
                    minionsDestroyed * 100 +
                    bossesDestroyed * 1000;
        }
        static void Count(int numberToCountTo) {
            for (int current=1;current<=numberToCountTo;current++) {
                Console.WriteLine($"{current}");
            }
        }
        /// <summary>
        /// Returns an array of integer numbers of the given length. 
        /// The containing numbers are generated randomly.
        /// </summary>
        /// <param name="length">The length of the array.</param>
        /// <returns>The resulting array of the given length.</returns>
        static int[] GenerateArray(int length) {
            int[] array = new int[length];
            for(int i = 0; i < length; i++) {
                array[i] = GetRandomInteger();
            }
            return array;
        }

        /// <summary>
        /// Prints the numbers in an array.
        /// </summary>
        /// <param name="anArray">An array of integer numbers.</param>
        static void PrintArray(int[] anArray) {
            for (int current = 0; current < anArray.Length; current++) {
                Console.WriteLine($"{anArray[current]}");
            }
        }

        /// <summary>
        /// Reverses the given array.
        /// </summary>
        /// <param name="anArray">An array of integer numbers.</param>
        static void ReverseArray(int[] anArray) {
            for(int i = 0; i < anArray.Length/2; i++) {
                int replacedValue = anArray[anArray.Length - 1 - i];
                anArray[anArray.Length - 1 - i]= anArray[i];
                anArray[i] = replacedValue;
            }
        }
        /// <summary>
        /// Obtains the factorial of the given number.
        /// </summary>
        /// <param name="aNumber">Number to which obtain the factorial from.</param>
        /// <returns></returns>
        static int Factorial(int aNumber) {
            if (aNumber == 0 || aNumber == 1) {
                return 1;
            }
            return aNumber*Factorial(aNumber-1);
        }
        /// <summary>
        /// Obtains the n'th number in the Fibonacci sequence.
        /// </summary>
        /// <param name="nth">Which number to return.</param>
        /// <returns></returns>
        static int Fibonacci(int nth) {
            if(nth==1 || nth == 2) {
                return 1;
            }
            return Fibonacci(nth-2)+ Fibonacci(nth - 1);
        }
        /// <summary>
        /// Obtains a Fibonacci array
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        static int[] FibonacciArray(int length) {
            int[] resArray = new int[length];
            for(int i=0; i<length; i++) {
                // Console.WriteLine($"i:{i+1}");
                resArray[i] = Fibonacci(i+1);
            }
            return resArray;
        }
        static void TestFibonacci() {
            TestFibonacci(10);
        }
        /// <summary>
        /// Tests Fibonacci serie.
        /// </summary>
        /// <param name="last">Where the serie should stop</param>
        static void TestFibonacci(int last) {
            for(int i = 1; i <= last; i++) {
                Console.WriteLine($"Fibonacci[{i}]: {Fibonacci(i)}");
            }
        }
    }
}
