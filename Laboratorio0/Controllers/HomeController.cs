﻿using Laboratorio0.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Laboratorio0.Controllers
{
    public class HomeController : Controller
    {
        //Declaración de variables
        private readonly ILogger<HomeController> _logger;

        //Constructor
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Método principal - Main
        public IActionResult Index()
        {
            return View();
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
}