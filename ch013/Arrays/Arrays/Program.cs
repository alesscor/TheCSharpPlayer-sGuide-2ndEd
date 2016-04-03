using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays {
    class Program {
        static void Main(string[] args) {
            // interesting declaration of multiple dimensions
            int[,] grid= new int[5,4];
            for(int i = 0; i < 5; i++) {
                for(int j = 0; j < 4; j++) {
                    grid[i, j] = i * j;
                }
            }
            for(int i = 0; i < grid.Length; i++) {
                Console.WriteLine($"the grid[{i}].");
            }
            Console.WriteLine($"the grid: {grid.ToString()}");
            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < 4; j++) {
                    Console.WriteLine($"the grid[{i},{j}]: {grid[i, j]}.");
                }
            }
            // basic example using strings
            string[] someNames = new string[] { "Real Madrid","Lepante","Albacete","Saprissa"};
            Console.WriteLine($"someNames[2]: {someNames[2]}.");
            // minimum value in an array
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

            int currentMinimum = int.MaxValue; // We start really high, so that any element
                                               // in the array will be lower than this.
            for(int index = 0; index < array.Length; index++) {
                if (array[index] < currentMinimum) {
                    currentMinimum = array[index];
                }
            }
            // at this point, currentMinimum contains the minimum value in the array
            Console.WriteLine($"currentMinimum: {currentMinimum}");

            // copying two arrays
            int[] originalArray = new int[] {1, 3, 5, 7, 9 };
            int[] destinationArray = new int[originalArray.Length];
            for(int i = 0; i < originalArray.Length; i++) {
                destinationArray[i] = originalArray[i];
            }
            for(int i = 0; i < destinationArray.Length; i++) {
                Console.WriteLine($"destinationArray[{i}]: {destinationArray[i]}");
            }
            for(int i = 0; i < originalArray.Length; i++) {
                Console.WriteLine($"originalArray[{i}]: {originalArray[i]}");
            }

            // access to the multi-dimensional array
            for(int row = 0; row < grid.GetLength(0); row++) {
                for(int column = 0; column < grid.GetLength(1); column++) {
                    Console.WriteLine($"grid[{row},{column}]: {grid[row,column]}");
                }
            }

            // access to the multi-dimensional array via foreach
            foreach(int item in grid) {
                Console.WriteLine($"grid[?,?]: {item}");
            }

            Console.ReadKey();
        }
    }
}
