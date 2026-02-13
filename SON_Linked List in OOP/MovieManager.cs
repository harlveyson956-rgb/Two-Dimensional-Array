using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SON_Linked_List_in_OOP
{
    // MovieManager class to handle linked list operations
    public class MovieManager
    {
        private LinkedList<Movie> movieList;

        public MovieManager()
        {
            movieList = new LinkedList<Movie>();
        }

        // Insert a movie into the linked list
        public void Insert(Movie movie)
        {
            movieList.AddLast(movie);
            Console.WriteLine("Movie added successfully.");
        }

        // Remove a movie by title
        public void Remove(string title)
        {
            LinkedListNode<Movie> node = movieList.First;
            while (node != null)
            {
                if (node.Value.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    movieList.Remove(node);
                    Console.WriteLine("Movie removed successfully.");
                    return;
                }
                node = node.Next;
            }
            Console.WriteLine("Movie not found.");
        }

        // Display all movies in the linked list
        public void Display()
        {
            if (movieList.Count == 0)
            {
                Console.WriteLine("No movies in the list.");
                return;
            }

            int count = 1;
            foreach (Movie movie in movieList)
            {
                Console.WriteLine($"Movie {count}:");
                movie.DisplayDetails();
                Console.WriteLine();
                count++;
            }
        }
    }
}
