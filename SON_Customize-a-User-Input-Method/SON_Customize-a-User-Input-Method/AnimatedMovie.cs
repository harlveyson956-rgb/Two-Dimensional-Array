using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SON_Customize_a_User_Input_Method
{
    // Derived class 2: AnimatedMovie
    public class AnimatedMovie : Movie
    {
        // At least one property for derived class
        public string AnimationStudio { get; set; }

        // Constructor
        public AnimatedMovie(string title, string releaseDate, string director, string animationStudio)
        : base(title, releaseDate, director)
        {
            AnimationStudio = animationStudio;
        }

        // Override display method
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Animation Studio: {AnimationStudio}");
        }
    }
    // UserInput class for reusable input methods
    public static class UserInput
    {
        // Method to get a movie object from user input
        public static Movie GetMovie(int movieNumber)
        {
            while (true)
            {
                Console.Write($"Enter type for movie {movieNumber} (B for Base Movie, A for ActionMovie, N for AnimatedMovie): ");
                string type = Console.ReadLine().ToUpper();
                if (type == "B" || type == "A" || type == "N")
                {
                    Console.Write("Enter title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter release date: ");
                    string releaseDate = Console.ReadLine();
                    Console.Write("Enter director: ");
                    string director = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(releaseDate) && !string.IsNullOrWhiteSpace(director))
                    {
                        if (type == "B")
                        {
                            return new Movie(title.Trim(), releaseDate.Trim(), director.Trim());
                        }
                        else if (type == "A")
                        {
                            Console.Write("Enter action type: ");
                            string actionType = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(actionType))
                            {
                                return new ActionMovie(title.Trim(), releaseDate.Trim(), director.Trim(), actionType.Trim());
                            }
                            else
                            {
                                Console.WriteLine("Action type cannot be empty. Try again.");
                                continue;
                            }
                        }
                        else if (type == "N")
                        {
                            Console.Write("Enter animation studio: ");
                            string animationStudio = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(animationStudio))
                            {
                                return new AnimatedMovie(title.Trim(), releaseDate.Trim(), director.Trim(), animationStudio.Trim());
                            }
                            else
                            {
                                Console.WriteLine("Animation studio cannot be empty. Try again.");
                                continue;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Title, release date, and director cannot be empty. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid type. Enter B, A, or N.");
                }
            }
        }

        // Method to get sorting choice from user
        public static string GetSortingChoice()
        {
            while (true)
            {
                Console.Write("Do you want to display in Ascending (A) or Descending (D) order by Title? ");
                string choice = Console.ReadLine().ToUpper();
                if (choice == "A" || choice == "D")
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 'A' for Ascending or 'D' for Descending.");
                }
            }
        }
    }
}
