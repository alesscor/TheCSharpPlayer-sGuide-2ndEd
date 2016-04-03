using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystem {
    class Program {
        static void Main(string[] args) {
            char aChar = 'c'; // c from chocolate!!!
            byte aByte = byte.MaxValue;
            short aShort = short.MaxValue;
            int anInt = int.MaxValue;
            long aLong = long.MaxValue;
            sbyte aSByte = sbyte.MaxValue;
            ushort aUShort = ushort.MaxValue;
            uint aUInt = uint.MaxValue;
            ulong aULong = ulong.MaxValue;
            float aFloat = float.MaxValue;
            double aDouble = double.MaxValue;
            decimal aDecimal = decimal.MaxValue;
            bool aBool = true;
            string aString = "chocolate!!!";

            string anotherString = "";
            anotherString += $"aChar={aChar}\n";
            anotherString += $"aByte={aByte}\n";
            anotherString += $"aShort={aShort}\n";
            anotherString += $"anInt={anInt}\n";
            anotherString += $"aLong={aLong}\n";
            anotherString += $"aSByte={aSByte}\n";
            anotherString += $"aUShort={aUShort}\n";
            anotherString += $"aUInt={aUInt}\n";
            anotherString += $"aULong={aULong}\n";
            anotherString += $"aFloat={aFloat}\n";
            anotherString += $"aDouble={aDouble}\n";
            anotherString += $"aDecimal={aDecimal}\n";
            anotherString += $"aBool={aBool}\n";
            anotherString += $"aString={aString}\n";

            Console.WriteLine(anotherString);
        }
    }
}
