using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SON_Stack_in_Procedural_Approach //Harlvey N. Son
{
    internal class Program

    {
        static void Main()
        {
            Stack<string> myStack = new Stack<string>(); // first kay nag buhat ko daan ug stack
            
            try //para kong mo error naay mo display
            {
                // Loop para sa mga input
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write("Enter clothes " + i + ": "); //Maoh ni para makabutang kag sanina
                    string input = Console.ReadLine(); 

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        throw new ArgumentException("Clothing name cannot be empty."); //dapat dili ma empty and pag butang
                    }

                    myStack.Push(input); // kani kay maka add ug item sa stack
                }

                Console.WriteLine("\n--- Display Clothes (Last In, First Out) ---");

                int num = 1;

                // ga use ko ug while loop para safety ang pag remove
                while (myStack.Count > 0)
                {
                    Console.WriteLine("Item " + num + ": " + myStack.Pop());
                    num++;
                }
            }
            catch (Exception ex) //maoh ni mo gawas kung mo error
            {
                Console.WriteLine("Input Error: " + ex.Message);
            }
           
            
        }
    }
}