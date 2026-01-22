using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SON_2D_Array_of_Objects
{
    internal class Program
    {
        // Complete Name: Harlvey N.Son
        // Problem: To create and display a two-dimensional array of objects (Student objects) using loop structures in a Console App (.Net Framework), reusing the structure from Activity 2.

        class Student
        {
            public string Name { get; set; }
            public int Grade { get; set; }

            public Student(string name, int grade)
            {
                Name = name;
                Grade = grade;          
            }
        }

       class program
        {
            static void Main(string[] args)
            {
                // Chosen Dimensions: 3x3
                // Data type: Student objects

                // Initialize the 3x3 array with sample Student objects
                Student[,] students = new Student[3, 3]
                {
                { new Student("Yap", 90),     new Student("Alice", 85), new Student("Beatrix", 88) },
                { new Student("Gabison", 92), new Student("Alucard", 87), new Student("Balmond", 89) },
                { new Student("Son", 91),     new Student("Gusion", 86), new Student("Nana", 90) }
                };             
                // Print the table Name
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Table Representation of 3x3 Student Array");
                Console.WriteLine("| Col 0 | Col 1 | Col 2 |");
                Console.WriteLine("---|-------|-------|-------|");

                // Use loop structure to access the 2D array of objects and print each row with row header
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Row {i} |");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($" {students[i, j].Name} ({students[i, j].Grade}) |");
                    }
                    Console.WriteLine();
                }

                // Wait for user input to close the console
                Console.ReadLine();
            }
        }
    }
}




