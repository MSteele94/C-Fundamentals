using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryPattern;
using System;
using System.Collections.Generic;

namespace StreamingContentRepositoryTest
{
    [TestClass]
    public class UnitTest1
    {
        //so we want to test the Add method in the repo
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //AAA -> Arrange, Act, Assert


            // Arrange -> Overall Setup

            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();


            //Act -> Get/ run the code to test

            bool addResult = repository.AddContentToDirectory(content);

            // Assert -> Used to get the expected outcome of a test

            Assert.IsTrue(addResult);

        }

        //testing the Read Method
        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //AAA RULES APPLY....

            //Arrange

            //creating the content
            StreamingContent content = new StreamingContent();

            //creating the repo
            StreamingContentRepository repo = new StreamingContentRepository();

            //Adding the repo (content)
            repo.AddContentToDirectory(content);

            //----------------------------------------------

            //Act 
            //our plan is to store the list of streaming content within a variable
            List<StreamingContent> listOfMovies = repo.GetContent();

            bool directoryHasContent = listOfMovies.Contains(content);


            //Assert 
            Assert.IsTrue(directoryHasContent);
        }
        //we will start with private 'fields'
        private StreamingContentRepository _repo;
        private StreamingContent _content;


        //This is the Arrange Part.. 
        [TestInitialize]
        public void Arrange()
        {

            //make the repo
            _repo = new StreamingContentRepository();

            //we make a new movie here.... finally.....
            _content = new StreamingContent("Rubber", "A car tyre comes to life with the power to make people explode",
                                            MaturityRating.R, GenreType.Drama, 5.8d);

            //now the movie is in our 'database' (list)
            _repo.AddContentToDirectory(_content);
        }

        //retrieve content by title
        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrange .....Already done above

            //Act 
            StreamingContent searchResult = _repo.GetContentByTitle("Rubber");

            //Assert 
            Assert.AreEqual(_content, searchResult);
        }

        //test the update method
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //Arrange  -> Updated Version Of our movie

            StreamingContent newContent = new StreamingContent("Rubber part 2", "A car tyre comes to life with the power to make people explode",
                                           MaturityRating.R, GenreType.Drama, 9.8d);

            //Act

            bool updateResult = _repo.UpdateExistingContent("Rubber",newContent);

            //Assert 
            Assert.IsTrue(updateResult);
          //  Console.WriteLine(GiveMeInfo(_content));
        }

        //public string GiveMeInfo(StreamingContent content)
        // {
        //      var result = $"{content.Title}\n" +
        //         $"{ content.StarRating}";
        //        return result;
        //}
        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()

        {
            //Arrange
            StreamingContent content = _repo.GetContentByTitle("Rubber");

            //Act
            bool removeResult = _repo.DeleteExistingContent(content);

            //Assert
            Assert.IsTrue(removeResult);


        }
    }
}
