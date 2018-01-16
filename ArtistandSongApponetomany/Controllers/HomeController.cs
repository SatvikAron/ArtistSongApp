﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ArtistandSongApponetomany.Models;
using ArtistandSongApponetomany.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace ArtistandSongApponetomany.Controllers
{
    public class HomeController : Controller
    {

        private ITimeProvider timeProvider;
        public HomeController(ITimeProvider _timeProvider)
        {
            timeProvider = _timeProvider;
        }

        [Authorize(Roles = "Admin")]

        public IActionResult Index()
        {
            ViewBag.Time = timeProvider.Now.ToString();
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
