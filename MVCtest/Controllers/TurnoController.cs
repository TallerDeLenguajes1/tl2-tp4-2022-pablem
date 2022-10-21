using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCtest.Models;

namespace MVCtest.Controllers
{
    // [Route("[controller]")]
    public class TurnoController : Controller
    {
        static int nroTurno = 0;

        static List<Turno> misTurnos = new List<Turno>();

        private readonly ILogger<TurnoController> _logger;

        public TurnoController(ILogger<TurnoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CrearTurno(Turno turno) 
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrearTurnoPost(Turno turno) 
        {
            // Turno nuevo = new Turno();
            turno.IdTurno = ++nroTurno;
            // nuevo.Nombre = "Turno = " + nroTurno;
            misTurnos.Add(turno);
            return View(misTurnos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}