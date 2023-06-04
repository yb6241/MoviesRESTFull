using MySql.EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore;
using MoviesRESTFull.Data;
using MoviesRESTFull.Services;

namespace MoviesRESTFull
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<IMovieService, MovieService>();
            builder.Services.AddDbContext<DbContextClass>();
            //builder.Services.AddEntityFrameworkMySQL().AddDbContext<DbContextClass>(options => {
            //        options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection"));
            //    });

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}