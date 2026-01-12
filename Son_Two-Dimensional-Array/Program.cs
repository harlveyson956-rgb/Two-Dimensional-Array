using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Son_Two_Dimensional_Array
{
    public static class Program 
    {
        private static int j;

        static void Main(string[] args)
        {
            //Complete Name: Harlvey N.Son

            //Choosen Dimensions: C. 3x3
            //Data type: int (integer)

            // Initialize the 3x3 array with sample values
            int[,] array = new int[3,3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
                
            };
            // Print the table Name
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Table Representation of 3x3 Array");
            Console.WriteLine("| Col 0 | Col 1 | Col 2 |");
            Console.WriteLine("---|-------|-------|-------|");

            // Print each row with row header
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Row {i} |");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" {array[i, j],5} |");
                }
                Console.WriteLine();
            }

            // Wait for user input to close the console
            Console.ReadLine();
        }
    }
}











