using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    public class StreamingContentRepository
    {
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();
        //create
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(content);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        //read
        public List<StreamingContent> GetContent()
        {
            return _contentDirectory;
        }
        //read helper method b/c used throughout this repo
        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }

            //this is not good practice , do not get used to returning null.
            return null;
        }
        //Update
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.GenreType = newContent.GenreType;
                oldContent.StarRating = newContent.StarRating;

                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete
        public bool DeleteExistingContent(StreamingContent existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }
        
        



        public StreamingContent GetContentByGenre(GenreType genreType)
        {
            List<StreamingContent> _genreTypeDirectory = new List<StreamingContent>();

            foreach (StreamingContent content in _genreTypeDirectory)
            {
                if (content.GenreType == genreType)
                {
                    _genreTypeDirectory.Add(content);
                    return content;
                }
            }
            return null;
        }
        public StreamingContent GetContentByMaturityRating(string description)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Description.ToLower() == description.ToLower())
                {
                    return content;
                }
            }
            return null;
        }

        public StreamingContent GetContentByStarRating(double starRating)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.StarRating == starRating)
                {
                    return content;
                }
            }
            return null;
        }
        public StreamingContent GetContentByMaturityRating(MaturityRating maturityRating)
        {
            List<StreamingContent> listOfContent = new List<StreamingContent>();
            foreach (StreamingContent content in listOfContent)
            {
                if (content.MaturityRating == maturityRating)
                {
                    listOfContent.Add(content);
                    return content;
                }
            }
            return null;
            
        }

    }
}
