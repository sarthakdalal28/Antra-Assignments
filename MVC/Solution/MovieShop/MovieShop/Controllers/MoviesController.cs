using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Contracts.Repository;
using Infrastructure.Repository;
using Infrastructure.Services;

namespace MovieShop.Controllers
{
    public class MoviesController : BaseController
    {
        private readonly IMovieRepository _movieRepository;

        public MoviesController(IMovieRepository movieRepository, IGenreService genreService) : base(genreService)
        {
            _movieRepository = movieRepository;
        }
        public async Task<IActionResult> Details(int id)
        {
            var movie = await _movieRepository.GetMovieDetails(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }
        public async Task<IActionResult> HighestGrossing()
        {
            var movies = await _movieRepository.GetHighestGrossingMovies();
            return View(movies);
        }
       // [HttpGet("Movies/Genre/{id}")]
        public async Task<IActionResult> Genre(int id, int pageSize = 30, int pageNumber = 1)
        {
            var movies = await _movieRepository.GetMoviesByGenre(id, pageSize, pageNumber);
            ViewBag.GenreId = id;
            return View(movies);
        }

    }
}
