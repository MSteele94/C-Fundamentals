using RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_inheritance
{
    public class Movie:StreamingContent
    {
        //we get all properties from StreamingContent b/c a movie IS A StreamingContent and we inherited the class
        public double RunTime { get; set; }

        public Movie()
        {

        }
        public Movie(string title, string description, MaturityRating maturityRating, GenreType genreType,double starRating, double runTime)
            //base uses the inherited class constructor, and is from the parent class
                     :base(title,description,maturityRating,genreType,starRating)
        {
            RunTime = runTime; 
        }
        
    }
}
