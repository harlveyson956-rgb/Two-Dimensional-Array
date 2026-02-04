using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SON_INSERTING_NODES_WITH_EXCEPTION
{
    internal class Program
    {
        private static object friendlist;
       private static void Main(string[] args)
        {
            //Compelete Name: Harlvey N. Son
            //(Inserting Nodes with exception handling

            LinkedList<string> friends = new LinkedList<string>();

            //Prompt user for number of friends (between 5 to 10)
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter the number of friends (5 to 10): ");
            int numberofFriends = 0;

            bool validInput = false;

            try
            {
                numberofFriends = int.Parse(Console.ReadLine());
                if (numberofFriends < 5 || numberofFriends > 10)
                {
                    throw new ArgumentOutOfRangeException("Number must be between 5 and 10.");
                }
                validInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Invalid input. {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            if (!validInput)
            {
                
                numberofFriends = 5;
                Console.WriteLine("Proceeding with default number of friends: 5");
            }

            // Loop to insert nodes into the linked list
            for (int i = 0; i < numberofFriends; i++)
            {
                Console.Write($"Enter the first name of your friend {i + 1}: ");
                string friendName = Console.ReadLine();
                // Add the name to the end of the linked list
                friends.AddLast(friendName);
            }

            // Display all elements from the linked list
            Console.WriteLine("\nFriends list (unsorted): ");
            foreach (string friend in friends)
            {
                Console.WriteLine(friend);
            }

            // Sort the elements from the linked list via an array
            string[] friendsArray = friends.ToArray();
            Array.Sort(friendsArray);

            // Display the sorted elements
            Console.WriteLine("\nFriends list (sorted): ");
            foreach (string friend in friendsArray)
            {
                Console.WriteLine(friend);
            }

            // Keep console open
            Console.ReadLine();
        }
    }
}
