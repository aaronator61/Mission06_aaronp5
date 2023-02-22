using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06_aaronp5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_aaronp5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext newContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieContext x)
        {
            _logger = logger;
            newContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Categories = newContext.Categories.ToList();
            return View(new Movie());
        }

        //Submitting the information from the form
        [HttpPost]
        public IActionResult MovieForm (Movie res)
        {
            if (ModelState.IsValid)
            {
                newContext.Add(res);//Adds info from the form
                newContext.SaveChanges();//Saves the info to the database.
            }

            ViewBag.Categories = newContext.Categories.ToList();
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult MovieTable()
        {
            var applications = newContext.movies.Include(x => x.category)
                .ToList();

            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit (int id)
        {
            ViewBag.Categories = newContext.Categories.ToList();

            var application = newContext.movies.Include(x => x.category).Single(x => x.movieId == id);

            return View("MovieForm", application);
        }

        [HttpPost]
        public IActionResult Edit (Movie res)
        {
            if (ModelState.IsValid)
            {
                newContext.Update(res);//Adds info from the form
                newContext.SaveChanges();//Saves the info to the database.
                return RedirectToAction("MovieTable");
            }
            else
            {
                ViewBag.Categories = newContext.Categories.ToList();
                return View(res); 
            }
           
        }

        public IActionResult Delete (int id)
        {
            var application = newContext.movies.Single(x => x.movieId == id);
            return View(application);
        }

        [HttpPost]
        public IActionResult Delete (Movie res)
        {
            newContext.movies.Remove(res);
            newContext.SaveChanges();

            return RedirectToAction("MovieTable");
        }
    }
}
