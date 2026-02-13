using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SON_Linked_List_in_OOP
{
    // UserInput class for reusable input 
    public static class UserInput
    {
        // Method to get a movie object from user input 
        public static Movie GetMovie()
        {
            try
            {
                Console.Write("Enter type for movie (B for Base Movie, A for ActionMovie, N for AnimatedMovie): ");
                string type = Console.ReadLine()?.ToUpper();
                if (string.IsNullOrEmpty(type) || (type != "B" && type != "A" && type != "N"))
                {
                    throw new ArgumentException("Invalid type. Enter B, A, or N.");
                }

                Console.Write("Enter title: ");
                string title = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(title))
                {
                    throw new ArgumentException("Title cannot be empty.");
                }

                Console.Write("Enter release date: ");
                string releaseDate = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(releaseDate))
                {
                    throw new ArgumentException("Release date cannot be empty.");
                }

                Console.Write("Enter director: ");
                string director = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(director))
                {
                    throw new ArgumentException("Director cannot be empty.");
                }

                if (type == "B")
                {
                    return new Movie(title.Trim(), releaseDate.Trim(), director.Trim());
                }
                else if (type == "A")
                {
                    Console.Write("Enter action type: ");
                    string actionType = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(actionType))
                    {
                        throw new ArgumentException("Action type cannot be empty.");
                    }
                    return new ActionMovie(title.Trim(), releaseDate.Trim(), director.Trim(), actionType.Trim());
                }
                else // type == "N"
                {
                    Console.Write("Enter animation studio: ");
                    string animationStudio = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(animationStudio))
                    {
                        throw new ArgumentException("Animation studio cannot be empty.");
                    }
                    return new AnimatedMovie(title.Trim(), releaseDate.Trim(), director.Trim(), animationStudio.Trim());
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message} Please try again.");
                return GetMovie(); // Recursive call to retry
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message} Please try again.");
                return GetMovie(); // Recursive call to retry
            }
        }

        // Method to get title for removal with exception handling
        public static string GetTitleForRemoval()
        {
            try
            {
                Console.Write("Enter the title of the movie to remove: ");
                string title = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(title))
                {
                    throw new ArgumentException("Title cannot be empty.");
                }
                return title.Trim();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message} Please try again.");
                return GetTitleForRemoval(); // Recursive call to retry
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message} Please try again.");
                return GetTitleForRemoval(); // Recursive call to retry
            }
        }

        // Method to get menu choice with exception handling
        public static int GetMenuChoice()
        {
            try
            {
                Console.Write("Enter your choice (1-4): ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int choice) || choice < 1 || choice > 4)
                {
                    throw new ArgumentException("Invalid choice. Please enter a number between 1 and 4.");
                }
                return choice;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return GetMenuChoice(); // Recursive call to retry
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return GetMenuChoice(); // Recursive call to retry
            }
        }
    }
}
