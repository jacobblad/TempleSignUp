﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TempleSignUp.Models;

namespace TempleSignUp.Controllers
{
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
        [HttpGet]
        public IActionResult EnterInfo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EnterInfo(Group g)
        {
            return View("Index");
        }

        [HttpGet]
        public IActionResult SignUp()
        {

            return View();
        }
        [HttpPost]
        public IActionResult SignUp(AvailableTime at)
        {
            DateTime apptTime = at.TimeSlot;

            return View("EnterInfo", apptTime);
        }

        public IActionResult ViewAppointments()
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
