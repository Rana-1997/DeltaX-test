using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieApplication.Models;

namespace MovieApplication.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        private MovieContext _movieContext;

        protected override void Dispose(bool disposing)
        {
            _movieContext.Dispose();
        }

        public MovieController()
        {
            _movieContext = new MovieContext();
        }
        public ActionResult Index()
        {
            return View(_movieContext.Movies.ToList());
        }
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Movie movie)
        {
            if(ModelState.IsValid)
            {
                   _movieContext.Movies.Add(movie);
                    _movieContext.SaveChanges();
                    return RedirectToAction("Index");
            }
            return View(movie);
        }
    }
}