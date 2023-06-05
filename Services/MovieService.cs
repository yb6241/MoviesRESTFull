using MoviesRESTFull.Models;
using MoviesRESTFull.Data;

namespace MoviesRESTFull.Services
{
    public class MovieService : IMovieService
    {
        private readonly DbContextClass _dbContext;
        public MovieService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Movie> GetMovieList()
        {
            try
            {
                return _dbContext.Movies.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public Movie GetMovieById(int id)
        {
            try
            {
                return _dbContext.Movies.Where(x => x.id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Movie GetMovieByTitle(string title)
        {
            try
            {
                return _dbContext.Movies.Where(x => x.title.Contains(title)).FirstOrDefault();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Movie AddMovie(Movie movie)
        {
            try
            {
                var result = _dbContext.Movies.Add(movie);
                _dbContext.SaveChanges();
                return result.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Movie UpdateMovie(Movie movie)
        {
            try
            {
                var result = _dbContext.Movies.Update(movie);
                _dbContext.SaveChanges();
                return result.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeleteMovie(int Id)
        {
            try
            {
                var filteredData = _dbContext.Movies.Where(x => x.id == Id).FirstOrDefault();
                var result = _dbContext.Remove(filteredData);
                _dbContext.SaveChanges();
                return result != null ? true : false; 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}