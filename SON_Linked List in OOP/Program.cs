using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SON_Linked_List_in_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieManager manager = new MovieManager();
            bool running = true;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the Movie Details Manager!");
            Console.ResetColor();

            while (running)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add a Movie");
                Console.WriteLine("2. Remove a Movie");
                Console.WriteLine("3. Display All Movies");
                Console.WriteLine("4. Exit");

                int choice = UserInput.GetMenuChoice();

                switch (choice)
                {
                    case 1:
                        Movie newMovie = UserInput.GetMovie();
                        manager.Insert(newMovie);
                        break;
                    case 2:
                        string titleToRemove = UserInput.GetTitleForRemoval();
                        manager.Remove(titleToRemove);
                        break;
                    case 3:
                        manager.Display();
                        break;
                    case 4:
                        running = false;
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;
                }
            }

            // Keep console open
            Console.ReadLine();
        }
    }
}