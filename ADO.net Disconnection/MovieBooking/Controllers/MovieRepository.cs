using MovieBooking.Models;
using MovieBooking.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBooking.Controllers
{
    public class MovieRepository : IMovieRepository
    {
        static List<Movie> movies = new List<Movie>();

        public Movie Add(Movie movie)
        {
            movie.Id = new Random().Next(999, 9999);
            movies.Add(movie);

            return movie;
        }


        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Movie FindMovieById(int id)
        {
            return movies.FirstOrDefault(d => d.Id == id);
        }

        public List<Movie> GetMovies()
        {
            return movies;
        }

        public Movie Update(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
