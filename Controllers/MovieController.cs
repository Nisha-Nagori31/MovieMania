using MovieMania.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MovieMania.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "shrek" };

            //pass the movie model in view and add the model refrence in Random view
            return View(movie);
        }

        //GET:Movies/released
        //*Attribute Routing
        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}