using RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_inheritance
{
    public class StreamingRepository : StreamingContentRepository
    {

        //We will use the same _contentDirectory from StreamingContentRepository.cs
        //Read -> show
        public Show GetShowByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Show))
                {
                    return (Show)content;
                }
            }
            return null;
        }
        //Read -> Movie

        public Movie GetMovieByTitle (string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content is Movie)
                {
                    return (Movie)content;
                }
            }
            return null;
        }

        //Read get all
        public List<Show> GetAllShows()
        {

            //use this to add our shows -> starts empty (we will return this list)   empty != null. null is the absence of any value
            List<Show> allShows = new List<Show>();
            foreach (StreamingContent content in _contentDirectory)
            {
                //if the content added is of type show
                if (content is Show)
                {
                    //add the show to allShows list
                    allShows.Add((Show)content);
                }
            }
            return allShows;
        }
        //Read get all movies
        public List<Movie> GetAllMovies()
        {
            List<Movie> allMovies = new List<Movie>();
            {
                foreach (StreamingContent content in _contentDirectory)
                {
                    if(content is Movie)
                    {
                        allMovies.Add(content as Movie);
                    }
                }
                return allMovies;
            }
        //get by runtim/Average runtime
        //get shows with over x episodes
        //Get shows / movie by rating


    }


        }
}
