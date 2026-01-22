using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SON_Customize_a_User_Input_Method
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            
                // Chosen Dimensions: 3x3
                // Data type: Student objects

                // Initialize the 3x3 array
                Student[,] students = new Student[3, 3];

                // Use the UserInput class to populate the array with user input
                for (int i = 0; i < 3; i++)
                {   
                    for (int j = 0; j < 3; j++)
                    {
                        string name = UserInput.GetString($"Enter name for Row {i}, Col {j}: ");
                        int grade = UserInput.GetInt($"Enter grade for {name}: ");
                        students[i, j] = new Student(name, grade);
                    
                    }
                }

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
    

