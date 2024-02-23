using Microsoft.AspNetCore.Mvc;
using Mission06_Ward.Models;
using System.Diagnostics;

namespace Mission06_Ward.Controllers
{
    public class HomeController : Controller
    {

        private AddMovieContext _context;
        public HomeController(AddMovieContext temp) //Constructor
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.Categories = _context.Categories.ToList();

            return View("AddMovie", new Application());
        }

        [HttpPost]
        public IActionResult AddMovie(Application response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response);// Add record to the database
                _context.SaveChanges();

                return View("Confirmation", response);
            }
            else
            {
                ViewBag.Categories = _context.Categories.ToList();

                return View(response);
            }

            
        }

        public IActionResult MovieList()
        {
            var movies = _context.Movies.ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories.ToList();

            return View("AddMovie", recordToEdit);
        }
        [HttpPost]
        public IActionResult Edit(Application updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordtoDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordtoDelete);
        }

        [HttpPost]
        public IActionResult Delete(Application application) 
        {
            _context.Movies.Remove(application);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
