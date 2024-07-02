using Films_ASR.NET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Films_ASR.NET.Pages
{
    public class MovieDetailsModel : PageModel
    {
        public Movie Movie { get; set; }
        public void OnGet(int id)
        {
            var movies = GetMovies();
            Movie = movies[id];
        }
        private List<Movie> GetMovies()
        {
            // Создание списка тестовых фильмов
            return new List<Movie>
        {
            new Movie { Title = "Фильм 1", Director = "Режиссер 1", Year = 2022, Description = "Краткое описание фильма 1" },
            new Movie { Title = "Фильм 2", Director = "Режиссер 2", Year = 2021, Description = "Краткое описание фильма 2" },
            new Movie { Title = "Фильм 3", Director = "Режиссер 3", Year = 2020, Description = "Краткое описание фильма 3" }
        };
        }
    }
}
