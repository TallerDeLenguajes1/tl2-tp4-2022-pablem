using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using cadAp2.Models;

namespace cadAp2.Controllers
{
    public class CadeteController : Controller
    {
        static int numeroCadetes = 0;
        static List<Cadete> listaCadetes = new List<Cadete>();

        private readonly ILogger<CadeteController> _logger;

        public CadeteController(ILogger<CadeteController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(listaCadetes);
        }

        public IActionResult AltaCadete()
        {
            ViewData["idCad"] = numeroCadetes+1;
            return View();
        }

        // [HttpGet]
        // public IActionResult ActualizarCadete(int id)
        // {
        //     return View(listaCadetes.Select(c => c.Id == id).Single());
        // }

        [HttpPost]
        public IActionResult GuardarCadete(Cadete cadete) {
            cadete.Id = ++numeroCadetes;
            listaCadetes.Add(cadete);
            return RedirectToAction("Index",listaCadetes);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}