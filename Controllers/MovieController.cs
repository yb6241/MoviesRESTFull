using Microsoft.AspNetCore.Mvc;
using MoviesRESTFull.Models;
using MoviesRESTFull.Services;

namespace MoviesRESTFull.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService movieService;
        public MovieController(IMovieService _movieService)
        {
            movieService = _movieService;
        }

        [HttpGet("movielist")]
        public IEnumerable<Movie> MovieList()
        {
            var movieList = movieService.GetMovieList();
            return movieList;

        }

        [HttpGet("getmoviebyid")]
        public Movie GetMovieById(int Id)
        {
            return movieService.GetMovieById(Id);
        }

        [HttpGet("getmoviebytitle")]
        public Movie GetMovieByTitle(string title)
        {
            return movieService.GetMovieByTitle(title);
        }

        [HttpPost("addmovie")]
        public Movie AddMovie(Movie movie)
        {
            return movieService.AddMovie(movie);
        }

        [HttpPut("updatemovie")]
        public Movie UpdateMovie(Movie movie)
        {
            return movieService.UpdateMovie(movie);
        }

        [HttpDelete("deletemovie")]
        public bool DeleteMovie(int Id)
        {
            return movieService.DeleteMovie(Id);
        }
    }
}