using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double r1, r2, r3, r4, resistance;

            Console.Write("Enter value for first resistance: ");
            r1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value for second resistance: ");
            r2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value for third resistance: ");
            r3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value for fourth resistance: ");  // add more resistors as needed 
            r4 = Convert.ToDouble(Console.ReadLine());

            // Calculate total resistance in parallel connection 

            resistance = (1 / (1 / r1 + 1 / r2 + 1 / r3 + 1 / r4));

            Console.WriteLine("The total resistance in parallel connection is: " + resistance + " ohms");
            Console.ReadKey();
        }
    }
}
