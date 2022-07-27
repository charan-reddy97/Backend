using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieBooking.Models;
using MovieBooking.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NowPlayingController : ControllerBase
    {
        IMovieRepository movieRepository;
        public NowPlayingController(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }
        public IActionResult Get()
        {
            var movies = movieRepository.GetMovies();
            return Ok(movies);

        }
        [HttpGet("{id}")]
        public IActionResult Get(int Id)
        {
            if (Id > 0)
            {
                var movie = movieRepository.FindMovieById(Id);

                if (movie == null)
                    return NotFound();
                else
                    return Ok(movie);
            }
            else
                return BadRequest();
        }
        [HttpPost]
        public IActionResult Post(Movie movie)
        {
            var newMovie = movieRepository.Add(movie);
            if (newMovie != null && newMovie.Id > 0)
            {
                return Created("/api/movie/1", newMovie);
            }
            else
                return BadRequest();
        }
    }
}
