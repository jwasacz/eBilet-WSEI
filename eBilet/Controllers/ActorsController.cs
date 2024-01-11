using eBilet.Data;
using eBilet.Models;
using Microsoft.AspNetCore.Mvc;

namespace eBilet.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Actors.ToList();
            return View(data);
        }
        public IActionResult Add()
        {
            return View(new Actor());
        }

        [HttpPost]
        public IActionResult Add(Actor actor)
        {
            if (ModelState.IsValid)
            {
                _context.Actors.Add(actor);
                _context.SaveChanges();
                return RedirectToAction("List");
            }

            return View(actor);
        }

    }
}
