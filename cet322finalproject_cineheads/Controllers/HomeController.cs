﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using cet322finalproject_cineheads.Models;

namespace cet322finalproject_cineheads.Controllers;

public class HomeController : Controller
{
    

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    
}

