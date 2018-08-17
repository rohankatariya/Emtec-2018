using DemoMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        MVCApplicationEntities mvcEntity = new MVCApplicationEntities();
        WrapperModel wrapperModel = DataHandler.WrapperMethod();
        Movie movie = new Movie();
        
        [NonAction]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowMovies()
        {
            ViewBag.Update = null;
            wrapperModel.movie = movie;
            return View("Index", wrapperModel);
        }

        public ActionResult DisplayUpdateBox(int id)
        {
            ViewBag.Update = 2;
            wrapperModel.movie = mvcEntity.Movies.Find(id);
            return View("Index", wrapperModel);
        }
        
        [HttpPost]
        public ActionResult UpdateDetails(Movie movie)
        {
            if(ModelState.IsValid)
            {
                mvcEntity.Entry(movie).State = EntityState.Modified;
                mvcEntity.SaveChanges();
            }
            return View("Index", DataHandler.WrapperMethod());
        }
        
        public ActionResult AddMovie()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult AddMovie(Movie movie)
        {
            if(ModelState.IsValid)
            {
                mvcEntity.Movies.Add(movie);
               mvcEntity.SaveChanges();
                return RedirectToAction("ShowMovies");
            }
            return View(movie);
        }
        
        public ActionResult Delete(int id)
        {
            ViewBag.Update = 3;
            wrapperModel.movie = mvcEntity.Movies.Find(id);
            return View("Index", wrapperModel);
        }
        
        public ActionResult DeleteMovie(int id)
        {
            using (var mvc = new MVCApplicationEntities())
            {
                mvc.Movies.Remove(mvc.Movies.Find(id));
                mvc.SaveChanges();
            }
            return RedirectToAction("ShowMovies");
        }
    }
}