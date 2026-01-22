using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SON_Customize_a_User_Input_Method
{
    public class UserInput
    {
        public static string GetString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static int GetInt(string prompt)
        {
            int value;
            string input = GetString(prompt);
            while (!int.TryParse(input, out value))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                input = GetString(prompt);
            }
            return value;
        }
    }
}

