using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SON_Customize_a_User_Input_Method
{
    // Base class Movie
    public class Movie
    {
        // Properties for base class (at least two or three)
        public string Title { get; set; }
        public string ReleaseDate { get; set; }
        public string Director { get; set; }

        // Constructor
        public Movie(string title, string releaseDate, string director)
        {
            Title = title;
            ReleaseDate = releaseDate;
            Director = director;
        }

        // Method Display Details
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Title: {Title}, ReleaseDate: {ReleaseDate}, Director: {Director}");
        }
    }
}
