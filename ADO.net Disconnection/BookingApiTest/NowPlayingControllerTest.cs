using Microsoft.AspNetCore.Mvc;
using Moq;
using MovieBooking.Controllers;
using MovieBooking.Models;
using MovieBooking.Repository;
using NUnit.Framework;
using System.Collections.Generic;

namespace BookingApiTest
{
    public class NowPlayingControllerTest
    {
        Mock<IMovieRepository> repoMock;
        [SetUp]
        public void Setup()
        {
            repoMock = new Mock<IMovieRepository>();
        }

        [Test]
        public void Get_NowPlayingMovies_ReturnsOk()
        {
            repoMock.Setup(d => d.GetMovies()).Returns(new List<Movie> {
                    new Movie { Id = 1, Title = "Minions", RunningTime = 1.5F },
                    new Movie { Id = 2, Title = "Top Gun : Maveric", RunningTime = 1.5F },
                    new Movie { Id = 3, Title = "Thor", RunningTime = 1.5F },
            });


            NowPlayingController controller = new NowPlayingController(repoMock.Object);

            //Act
            var response = controller.Get();
            var result = (OkObjectResult)response;

            var listOfMovies = (List<Movie>)result.Value;

            //Assert
            Assert.AreEqual(200, result.StatusCode);
            Assert.NotNull(listOfMovies);
            Assert.IsTrue(listOfMovies.Count > 0);


        }
        [Test]
        public void GetMovie_byId_ok()
        {
            int movieId = 1;
            repoMock.Setup(d => d.FindMovieById(movieId))
                    .Returns(new Movie { Id = movieId });

            NowPlayingController controller = new NowPlayingController(repoMock.Object);


            var response =controller.Get(movieId);
            var result= (OkObjectResult)response;
            var movie = (Movie)result.Value;
            Assert.AreEqual(200, result.StatusCode);
            Assert.NotNull(movie);
            Assert.AreEqual(movieId, movie.Id);

        }
        [Test]
        public void GetMovie_byId_NotFound()
        {
            int movieId = 0;
            repoMock.Setup(d => d.FindMovieById(movieId)).Returns(value: null);
            NowPlayingController controller = new NowPlayingController(repoMock.Object);

            var response = controller.Get(100);
            var result = (NotFoundResult)response;
            //var movie = (Movie)result.Value;
            Assert.AreEqual(404, result.StatusCode);
           

        }
        [TestCase(-1)]
        public void GetById_InValidId_ReturnsBadReuest(int movieId)
        {
            //Arrange
            NowPlayingController controller = new NowPlayingController(repoMock.Object);

            //Act
            var response = controller.Get(movieId);
            var result = (BadRequestResult)response;

            //Assert
            Assert.AreEqual(400, result.StatusCode);
        }
        [Test]
        public void AddMovie_Returns_Created()
        {
            Movie movie = new Movie();
            repoMock.Setup(d => d.Add(It.IsAny<Movie>())).Returns(new Movie { Id = 1, Title = "Thor", RunningTime = 1.4F });
            NowPlayingController controller = new NowPlayingController(repoMock.Object);
            

            var response = controller.Post(movie);
            var result = (CreatedResult)response;

            Assert.AreEqual(201, result.StatusCode);

        }
        [Test]
        public void AddMovie_returns_BadRequest()
        {
            Movie movie = new Movie();
            repoMock.Setup(d => d.Add(It.IsAny<Movie>())).Returns(value: null);
            NowPlayingController controller = new NowPlayingController(repoMock.Object);


            var response = controller.Post(movie);
            var result = (BadRequestResult)response;

            Assert.AreEqual(400, result.StatusCode);
        }

    }
}