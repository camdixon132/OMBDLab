﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OMBDLab.Models;

namespace OMBDLab.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult MovieSearch()
    {
        return View();
    }

    /*
    [HttpGet]
    public IActionResult MovieSearchForm()
    {

        return View(MovieSearch);
    }
    */
    [HttpPost]
    public IActionResult MovieSearch(string movie)
    {

        return View(MovieDAL.MovieSearchResults(movie));
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

