using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SON_Customize_a_User_Input_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ARRAY_SIZE = 7; // Fixed array size between 5 and 10
            Movie[] movies = new Movie[ARRAY_SIZE];
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the Movie Details Manager!");
            Console.WriteLine("You will create 7 movie objects (mix of base, ActionMovie, or AnimatedMovie).");

            // Input loop using the reusable UserInput class
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                movies[i] = UserInput.GetMovie(i + 1);
            }

            // Display entered movies
            Console.WriteLine("\nYou entered the following movies:");
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                Console.WriteLine($"Movie {i + 1}:");
                movies[i].DisplayDetails();
                Console.WriteLine();
            }

            // Get sorting choice using the reusable UserInput class
            string choice = UserInput.GetSortingChoice();
            if (choice == "A")
            {
                movies = movies.OrderBy(m => m.Title).ToArray();
            }
            else
            {
                movies = movies.OrderByDescending(m => m.Title).ToArray();
            }

            // Display sorted movies
            Console.WriteLine("\nSorted movies by Title:");
            foreach (Movie p in movies)
            {
                p.DisplayDetails();
                Console.WriteLine(); // Add a blank line for readability
            }

            // Keep console open
            Console.ReadLine();
        }
    }
}