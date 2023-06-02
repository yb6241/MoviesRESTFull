using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesRESTFull.DTO;
using MoviesRESTFull.Entities;
using System.Net;

namespace MoviesRESTFull.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly DbXsisContext DBContext;
        public MovieController(DbXsisContext DBContext)
        {
            this.DBContext = DBContext;
        }

        [HttpGet("GetMovies")]
        public async Task<ActionResult<List<MovieDTO>>> Get()
        {
            try
            {
                var List = await DBContext.Movies.Select(
                s => new MovieDTO
                {
                    Id = s.Id,
                    Title = s.Title,
                    Description = s.Description,
                    Rating = s.Rating,
                    Image = s.Image,
                    CreatedAt = s.CreatedAt,
                    UpdatedAt = s.UpdatedAt
                }
            ).ToListAsync();

                if (List.Count < 0)
                {
                    var message = string.Format("Movie List not found");
                    return NotFound(message);
                }
                else
                {
                    return List;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("GetMovieById")]
        public async Task<ActionResult<MovieDTO>> GetMovieById(int Id)
        {
            try
            {
                MovieDTO Movie = await DBContext.Movies.Select(s => new MovieDTO
                {
                    Id = s.Id,
                    Title = s.Title,
                    Description = s.Description,
                    Rating = s.Rating,
                    Image = s.Image,
                    CreatedAt = s.CreatedAt,
                    UpdatedAt = s.UpdatedAt
                }).FirstOrDefaultAsync(s => s.Id == Id);

                if (Movie == null)
                {
                    var message = string.Format("Movie with id = {0} not found", Id);
                    return NotFound(message);
                }
                else
                {
                    return Movie;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("InsertMovie")]
        public async Task<HttpStatusCode> InsertMovie(MovieDTO Movie)
        {
            try
            {
                var entity = new Movie()
                {
                    //Id = Movie.Id,
                    Title = Movie.Title,
                    Description = Movie.Description,
                    Rating = Movie.Rating,
                    Image = Movie.Image,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };
                DBContext.Movies.Add(entity);
                await DBContext.SaveChangesAsync();
                return HttpStatusCode.Created;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut("UpdateMovie")]
        public async Task<HttpStatusCode> UpdateMovie(MovieDTO Movie)
        {
            try
            {
                var entity = await DBContext.Movies.FirstOrDefaultAsync(s => s.Id == Movie.Id);
                entity.Title = Movie.Title;
                entity.Description = Movie.Description;
                entity.Rating = Movie.Rating;
                entity.Image = Movie.Image;
                entity.CreatedAt = entity.CreatedAt;
                entity.UpdatedAt = DateTime.Now;
                await DBContext.SaveChangesAsync();
                return HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("DeleteMovie/{Id}")]
        public async Task<HttpStatusCode> DeleteMovie(int Id)
        {
            try
            {
                var entity = new Movie()
                {
                    Id = Id
                };
                DBContext.Movies.Attach(entity);
                DBContext.Movies.Remove(entity);
                await DBContext.SaveChangesAsync();
                return HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
