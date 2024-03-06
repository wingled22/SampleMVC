using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SampleMVC.Controllers
{
    public class PelayoController : Controller
    {
        private readonly ILogger<PelayoController> _logger;

        public PelayoController(ILogger<PelayoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Action1(bool isLoggedIn)
        {

            if (isLoggedIn)
                return View("Action1");
            else
                return View("CustomPage");
        }
    }
}