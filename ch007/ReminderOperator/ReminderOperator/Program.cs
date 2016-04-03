using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderOperator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine($"17/4 reminder={reminder(17,4)}");
            Console.WriteLine($"200/4 reminder={reminder(200, 4)}");
            // using simplerReminder
            Console.WriteLine($"17/4 reminder={simplerReminder(17, 4)}");
            Console.WriteLine($"200/4 reminder={simplerReminder(200, 4)}");
        }
        static int reminder(int a, int b) {
            int res = 0;
            res = a-((a / b)*b);
            return res;
        }
        static int simplerReminder(int a, int b) {
            return a % b;
        }
    }
}
