using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations {
    public enum DaysOfWeek {
        Sunday=1,
        Monday=2,
        Tuesday=3,
        Wednesday=4,
        Thurdsday=5,
        Friday=6,
        Saturday=7
    };
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
        November,
        December
    };
    class Program {
        static void Main(string[] args) {
            DaysOfWeek aDay = DaysOfWeek.Friday;
            Months aMonth = Months.March;
            Console.WriteLine($"aDay:{aDay}: {(int)aDay}, aMonth:{aMonth}:{(int)aMonth}");
            Console.ReadKey();
        }
    }
}
