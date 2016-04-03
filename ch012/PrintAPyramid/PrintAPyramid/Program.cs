using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAPyramid {
    class Program {
        static void Main(string[] args) {
            // 1,3,5,7,9
            //int limit = 0;
            for (int row=0; row < 5; row++) {
                for (int column=0; column <= 3-row; column++) {
                    Console.Write(" ");
                }
                // row:=2*row+1

                //switch (row) {
                //    case 0:
                //        limit = 1;
                //        break;
                //    case 1:
                //        limit = 3;
                //        break;
                //    case 2:
                //        limit = 5;
                //        break;
                //    case 3:
                //        limit = 7;
                //        break;
                //    case 4:
                //        limit = 9;
                //        break;
                //}
                for (int column=0; column<2*row+1; column++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
