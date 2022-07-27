using MovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBooking.Repository
{
    public interface IMovieRepository
    {
        List<Movie> GetMovies();
        Movie FindMovieById(int id);

        Movie Add(Movie movie);
        Movie Update(Movie movie);

        void Delete(int id);
    }

}
