﻿using FakeTeeTurtle.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FakeTeeTurtle.Controllers;

[Route("/")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return RedirectToAction("Page", "Product", new
        {
            p = 1
        });
    }
}