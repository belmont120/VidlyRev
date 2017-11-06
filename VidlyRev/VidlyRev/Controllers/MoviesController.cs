using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyRev.Models;
using VidlyRev.ViewModels;
using System.Data.Entity;

namespace VidlyRev.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies
        public ActionResult Index()
        {
            var viewModel = new MoviesViewModel { Movies = _context.Movies.Include(m => m.Genre).ToList() };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(c => c.Id == id);

            return View(movie);
        }

        public ActionResult Random()
        {


            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;

            var viewModel = new MoviesViewModel { Movies = _context.Movies.ToList() };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("Id = " + id);
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}