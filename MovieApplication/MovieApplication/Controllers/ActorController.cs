using MovieApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieApplication.Controllers
{
    public class ActorController : Controller
    {
        private MovieContext _movieContext;

        protected override void Dispose(bool disposing)
        {
            _movieContext.Dispose();
        }

        public ActorController()
        {
            _movieContext = new MovieContext();
        }
        public ActionResult IndexActor()
        {
            return View(_movieContext.Actors.ToList());
        }
        public ActionResult AddActor()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Actor actor)
        {
            if (ModelState.IsValid)
            {
                _movieContext.Actors.Add(actor);
                _movieContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(actor);
        }
    }
}