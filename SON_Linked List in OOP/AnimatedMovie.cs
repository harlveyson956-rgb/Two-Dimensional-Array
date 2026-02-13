using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SON_Linked_List_in_OOP
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
}