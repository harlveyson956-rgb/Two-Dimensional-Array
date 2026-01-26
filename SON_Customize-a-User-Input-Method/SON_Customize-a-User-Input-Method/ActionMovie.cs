using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SON_Customize_a_User_Input_Method
{
    // Derived class 1: ActionMovie
    public class ActionMovie : Movie
    {
        // At least one property for derived class
        public string ActionType { get; set; }

        // Constructor
        public ActionMovie(string title, string releaseDate, string director, string actionType)
        : base(title, releaseDate, director)
        {
            ActionType = actionType;
        }

        // Override display method
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Action Type: {ActionType}");
        }
    }
}