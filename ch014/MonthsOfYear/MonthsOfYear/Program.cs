using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthsOfYear {
    public enum Months {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December,
        Invalid
    };
    class Program {
        static void Main(string[] args) {
            string theMonthsName = "(not valid)";
            Months theMonthsValue=Months.Invalid;
            // Asks for a number between 1 and 12
            Console.Write("Enter a number between 1 and 12, to represent a month: ");
            string numberAsAString = Console.ReadLine();
            int monthNumber= Convert.ToInt16(numberAsAString);

            // Checks the value and assign it
            if(monthNumber>=1 && monthNumber <= 12) {
                theMonthsValue = (Months)(monthNumber -1);
                theMonthsName = $"{theMonthsValue}";
            } else {

            }

            // Returns the name of the month
            Console.WriteLine($"The month for value {monthNumber} is {theMonthsName} ({(int)theMonthsValue})");

            Console.ReadKey();
        }
    }
}
