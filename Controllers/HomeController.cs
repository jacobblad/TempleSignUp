using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TempleSignUp.Models;
using TempleSignUp.Models.ViewModels;

namespace TempleSignUp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ITempleRepository _repository;

        private AvailableTime _availableTime;

        public HomeController(ILogger<HomeController> logger, ITempleRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EnterInfo()
        {

            return View(_availableTime);
            //return View(new TimeListViewModel
            //{
            //    AvailableTimes = _repository.AvailableTimes
            //});
        }
        [HttpPost]
        public IActionResult EnterInfo(Group g)
        {
            return View("Index");
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View(new TimeListViewModel
            {
                AvailableTimes = _repository.AvailableTimes
            });
        }
        [HttpPost]
        public IActionResult SignUp(AvailableTime at)
        {
            //DateTime apptTime = at.TimeSlot;
            _availableTime = at;
            return View(at);
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
