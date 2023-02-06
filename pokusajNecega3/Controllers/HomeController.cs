﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pokusajNecega3.Models;
using pokusajNecega3.Models.EFRepository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace pokusajNecega3.Controllers
{
    public class HomeController : Controller
    {
        KorisniciRepository korisnik = new KorisniciRepository();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string nKor,string nSif)
        {
            return View (korisnik.nadjiKorisnika(nKor, nSif));
        }

        public IActionResult VecUlogovanAdmin()
        {
            ViewBag.Uloga = "admin";
            return View("VecUlogovan");
        }

        public IActionResult VecUlogovanKorisnik()
        {
            ViewBag.Uloga = "korisnik";
            return View("VecUlogovan");
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
