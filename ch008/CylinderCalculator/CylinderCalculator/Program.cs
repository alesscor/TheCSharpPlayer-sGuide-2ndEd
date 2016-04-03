using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CylinderCalculator {
    class Program {
        static void Main(string[] args) {
            // Print a greeting message. After all, why not?
            Console.WriteLine("Welcome to Cylinder Calculator 1.0!");

            // Read in the cylinder's radius from the user
            Console.Write("Enter the cylinder's radius: ");
            string radiusAsAString = Console.ReadLine();
            double radius = Convert.ToDouble(radiusAsAString);

            // Read in the cylinder's height from the user
            Console.Write("Enter the cylinder's height: ");
            string heightAsAString = Console.ReadLine();
            double height = Convert.ToDouble(heightAsAString);

            double pi = 3.141592654d; // We'll learn a better way to do PI in the next chapter.

            // These are two standard formulas for volume and surface area
            // of a cylinder.
            // You can find them on Wikipedia:
            //   http://en.wikipedia.org/wiki/Cylinder_(geometry)
            double volume = pi * radius * radius * height;
            double surfaceArea = 2 * pi * radius * (radius + height);

            // Now we ouput the results
            Console.WriteLine($"The cylinder's volume is: {volume:0.00} cubic units.");
            Console.WriteLine($"The cylinder's surface area is: {surfaceArea:0.00} square units.");

            // Wait for the user to respond before closing...
            Console.ReadKey();
        }
    }
}

