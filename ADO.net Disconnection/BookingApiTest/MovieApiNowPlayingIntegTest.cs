using Microsoft.AspNetCore.Mvc.Testing;
using MovieBooking.Models;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookingApiTest
{

    public class MovieApiNowPlayingIntegTest
    {
        HttpClient http;
        public MovieApiNowPlayingIntegTest()
        {
            WebApplicationFactory<MovieBooking.Startup> web
                = new WebApplicationFactory<MovieBooking.Startup>();

            http = web.CreateClient();
        }

        [Test]
        public async Task PostNewMovie_ValidData_ReturnsCreated()
        {
            //Arrage
            Movie movie = new Movie { Title = "Thor", RunningTime = 1.5F };
            var jsonData = new StringContent(JsonConvert.SerializeObject(movie)
                                            , Encoding.UTF8
                                            , "application/json");

            //Act
            var response = await http.PostAsync("/api/nowplaying", jsonData);
            var jsonResponseMovie = response.Content.ReadAsStringAsync().Result;
            var newMovie = JsonConvert.DeserializeObject<Movie>(jsonResponseMovie);


            //Assert
            Assert.AreEqual(response.StatusCode, HttpStatusCode.Created);
            Assert.NotNull(newMovie);
            Assert.IsTrue(newMovie.Id > 0);

        }

        [Test]
        public async Task GetMovies_ValidData_ReturnsOk()
        {
            var response = await http.GetAsync("/api/nowplaying");
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }

}
