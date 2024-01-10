using eBilet.Data;
using Microsoft.AspNetCore.Mvc;

namespace eBilet.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var allMovies = _context.Movies.ToList();
            return View(allMovies);
        }
    }
}
