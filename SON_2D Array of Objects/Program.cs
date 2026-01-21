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

=============Activity 5==========
internal class Program
{
    // Complete Name: Harlvey N.Son
    // Problem: To create and display a two-dimensional array of objects (Student objects) using loop structures in a Console App (.Net Framework), reusing the structure from Activity 2. (Updated for Activity 4: Incorporate user input for populating the array.)

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
        // Reusable method to get student details from user input
        private static Student GetStudentFromUser()
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            int grade;
            while (true)
            {
                Console.Write("Enter student grade (integer): ");
                if (int.TryParse(Console.ReadLine(), out grade))
                {
                    break; // Valid input, exit loop
                }
                else
                {
                    Console.WriteLine("Invalid grade. Please enter a valid integer.");
                }
            }

            return new Student(name, grade);
        }

        static void Main(string[] args)
        {
            // Chosen Dimensions: 3x3
            // Data type: Student objects

            // Initialize the 3x3 array (will be populated via user input)
            Student[,] students = new Student[3, 3];

            // Use nested loops to populate the array with user input
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Enter details for student at position [{i}, {j}]:");
                    students[i, j] = GetStudentFromUser();
                }
            }

            // Print the table header
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nTable Representation of 3x3 Student Array");
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
    


