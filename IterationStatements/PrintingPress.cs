using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements
{
    public class PrintingPress
    {
        public static void PosToNegative1000Printer()
        {
            for (int startNum = 1000; startNum > -1000; startNum--)
            {
                Console.WriteLine(startNum);
            }
        }

        public static void ThreeToNineNineNinePrinter() 
        {
            for (int startNum = 3; startNum < 1000; startNum+=3)
            {
                Console.WriteLine(startNum);
            }
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void TheMultiplicationTable(int tableNumber)
        {    
            Console.WriteLine($"The Multiplication Table for the number {tableNumber}");
            for (int topNums = 1; topNums < tableNumber + 1; topNums++)
            {
                Console.WriteLine("\n");

                for (int sideNums = 1; sideNums < tableNumber + 1; sideNums++)
                {
                    Console.Write("{0, 4}", topNums * sideNums);
                }
            }     
        }
    }
}
