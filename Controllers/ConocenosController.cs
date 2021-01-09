using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LibreriaProgra.Models;

namespace LibreriaProgra.Controllers
{
    public class ConocenosController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ConocenosController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
