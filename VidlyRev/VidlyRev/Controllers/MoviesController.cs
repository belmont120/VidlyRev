using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyRev.Models;
using VidlyRev.ViewModels;

namespace VidlyRev.Controllers
{
    public class MoviesController : Controller
    {
        MoviesViewModel viewModel = new MoviesViewModel
        {
            Movies = new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek!" },
                new Movie { Id = 2, Name = "Wall-e" }
            }
        };

        // GET: Movies
        public ActionResult Index()
        {

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var movie = viewModel.Movies.SingleOrDefault(c => c.Id == id);

            return View(movie);
        }

        public ActionResult Random()
        {


            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;

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