using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingRandom {
    class Program {
        static void Main(string[] args) {
            // Random random = new Random();
            // Console.WriteLine($"random.Next(10)+1:{random.Next(10)+1}");
            // Console.WriteLine($"random.Next(10)+1:{random.Next(10)+1}");
            //
            PlayRollingDice();
            Console.ReadKey();
        }
        static int GetNumberFromUserOrExit(int maxNumber) {
            int usersNumber = 0;
            while (usersNumber < 1 || usersNumber > maxNumber) {
                Console.WriteLine($"Enter a number between 1 and {maxNumber} (or type 'exit' or 'quit'): ");
                string usersResponse = Console.ReadLine();
                try {
                    usersNumber = Convert.ToInt32(usersResponse);
                } catch (Exception) {
                    usersNumber = 0;
                    if(usersResponse =="quit" || usersResponse == "exit") {
                        return -1;
                    }
                }
            }
            return usersNumber;
        }
        static int RollingDice(int amountOfDice) {
            Random random = new Random();
            int resI = 0;
            int res = 0;
            for(int i = 0; i < amountOfDice; i++) {
                resI = random.Next(6) + 1;
                Console.WriteLine($"resI[{i}]:{resI}");
                res = res + resI;
            }
            return res;
        }
        static void PlayRollingDice() {
            // Dice Rolling
            // -----------
            // Get number of dice from user or exit if the user wants to leave from rolling dice
            int numDice = 0;
            do {
                numDice = GetNumberFromUserOrExit(100);
                if (numDice > 0) {
                    // Roll the dice
                    int res = RollingDice(numDice);
                    // Print the sum of dice results
                    Console.WriteLine($"the result of rolling {numDice} di(c)e is {res}.");
                }
            } while (numDice>0);
            Console.WriteLine("Exit requested by user.");
        }
    }
}
