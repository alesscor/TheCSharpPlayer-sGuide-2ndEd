using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting {
    class Program {
        static void Main(string[] args) {
            float a = 1.0f + 1 + 1.010f; // f needed in both terms to make it float because default type was double
            Console.WriteLine($"a=1.0 + 1 + 1.010f:{a:0.0000}");
            Console.WriteLine($"(float)(1.0f + 1 + 1.010f):{(float)(1.0f + 1 + 1.010f):0.0000}");
            a = 1.0000f + 1.010f; // f needed in both terms to make it float because default was type double
            Console.WriteLine($"a=1.0000f + 1.010f:{a:0.0000}");
            Console.WriteLine($"(float)(1.0000 + 1.010f):{(float)(1.0000f + 1.010f):0.0000}");
            Console.WriteLine($"(float)(1.0000 + float.PositiveInfinity):{(float)(1.0000f + float.PositiveInfinity):0.0000}");
            a = float.PositiveInfinity + 100.002f;
            Console.WriteLine($"float.PositiveInfinity):{float.PositiveInfinity}");
            if (float.IsPositiveInfinity(a)) {
                Console.WriteLine($"a is Positive Infinity: {a}");
            }
            a--;
            if (float.IsPositiveInfinity(a)) {
                Console.WriteLine($"a is Positive Infinity: {a}");
            }
            Console.WriteLine($"(int)(3.0 / 4.0): {(int)(3.0 / 4.0):0.0000}");
            Console.ReadKey();
        }
    }
}
