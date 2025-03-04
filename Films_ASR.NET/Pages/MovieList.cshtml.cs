using Films_ASR.NET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Films_ASR.NET.Pages
{
    public class MovieListModel : PageModel
    {
        public List<Movie> Movies { get; set; }
        public void OnGet()
        {
            Movies = GetMovies();
        }
        private List<Movie> GetMovies()
        {
            // �������� ������ �������� �������
            return new List<Movie>
        {
            new Movie { Title = "����� 1", Director = "�������� 1", Year = 2022, Description = "������� �������� ������ 1" },
            new Movie { Title = "����� 2", Director = "�������� 2", Year = 2021, Description = "������� �������� ������ 2" },
            new Movie { Title = "����� 3", Director = "�������� 3", Year = 2020, Description = "������� �������� ������ 3" }
        };
        }
    }
}

