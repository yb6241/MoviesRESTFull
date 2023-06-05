using MoviesRESTFull.Models;

namespace MoviesRESTFull.Services
{
    public interface IMovieService
    {
        public IEnumerable<Movie> GetMovieList();
        public Movie GetMovieById(int id);
        public Movie AddMovie(Movie movie);
        public Movie UpdateMovie(Movie movie);
        public bool DeleteMovie(int Id);
        public Movie GetMovieByTitle(string title);
    }
}
