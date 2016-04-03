using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingVariables {
    class Program {
        static void Main(string[] args) {
            int score=714;
            int a = 5, b = 2;
            int gigante = int.MaxValue;
            b = a;
            a = -3;
            Console.WriteLine($"score={score}");
            Console.WriteLine($"a={a}, b={b}");
            Console.WriteLine($"gigante={gigante}");
        }
    }
}
