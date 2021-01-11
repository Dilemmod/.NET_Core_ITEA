using HW4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HW4.Controllers
{
    public class HumanController : Controller
    {
        private InfestationDbContext _context { get; }

        public HumanController(InfestationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["Humans"] = _context.Humans.ToList();
            return View();
        }

    }
}