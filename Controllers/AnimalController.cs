using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleMVC.Entities;

namespace SampleMVC.Controllers
{
    [Route("[controller]")]
    public class AnimalController : Controller
    {
        private readonly ZooContext _context;

        public AnimalController(ZooContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var animals = _context.Animals.ToList();
            return View(animals);
        }

    }
}