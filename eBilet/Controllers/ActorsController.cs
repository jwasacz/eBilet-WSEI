using eBilet.Data;
using Microsoft.AspNetCore.Mvc;

namespace eBilet.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;
        public IActionResult Index()
        {
            return View();
        }
    }
}
