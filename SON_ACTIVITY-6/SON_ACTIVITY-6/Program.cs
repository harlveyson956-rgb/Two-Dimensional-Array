using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SON_ACTIVITY_6 //linkedListFriends
{
     class Program
    {
        private static object friendsList;

        static void Main(string[] args)        
        {
            //Complete Name: Harlvey N. Son
            //My friend list

            // Declare a linked list to store friends' first names
            LinkedList<string> friends = new LinkedList<string>();

            // Prompt user for number of friends (between 5 and 10)
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter the number of friends (5-10): ");
            int numberOfFriends;
            if (!int.TryParse(Console.ReadLine(), out numberOfFriends) || numberOfFriends < 5 || numberOfFriends > 10)
             
            {              
                Console.WriteLine("Invalid input. Number must be between 5 and 10.");
                return;
            }

            // Loop to insert nodes into the linked list
            for (int i = 0; i < numberOfFriends; i++)
            {
                Console.Write($"Enter the first name of friend {i + 1}: ");
                string friendName = Console.ReadLine();
                // Add the name to the end of the linked list
                friends.AddLast(friendName);
            }

            // Display all content of the linked list
            Console.WriteLine("\nFriends list:");
            foreach (string friend in friends)
            {
                Console.Write("My friend list: ");
                Console.WriteLine(friend);
            }

            // Keep console open
            Console.ReadLine();
        }
    }
}