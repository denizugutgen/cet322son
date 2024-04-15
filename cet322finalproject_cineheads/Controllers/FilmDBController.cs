using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cet322finalproject_cineheads;
using cet322finalproject_cineheads.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cet322finalproject_cineheads.Controllers;

public class FilmDBController : Controller
{
    public IActionResult Index()
    {
        var movie = new cine();
        movie.ID = 1;
        movie.Title = "Uncle Boonmee";
        return View(movie);
    }

    public IActionResult List()
    {
        var movies = new List<cine>()
        {
            new cine() {ID = 1, Title = "Uncle Boonmee", Description = "film", Image = "Boonmee-Poster.jpg"},
            new cine() {ID = 2, Title = "Memoria", Description = "film", Image = "memoria.jpg"},
            new cine() {ID = 3, Title = "Mysterious Object at Noon", Description = "film", Image = "mysterious.jpeg"}
        };
        return View("filmlist", movies);
    }
}
    


