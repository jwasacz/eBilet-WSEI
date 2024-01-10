using eBilet.Data;
using Microsoft.AspNetCore.Mvc;

namespace eBilet.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;


        public CinemasController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Cinemas.ToList();
            return View();
        }
    }
}
