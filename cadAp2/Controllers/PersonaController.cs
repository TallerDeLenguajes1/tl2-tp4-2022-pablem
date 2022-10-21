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
    // [Route("[Persona]")]
    public class PersonaController : Controller
    {
        // static int nroTurno = 0;
        static List<Persona> listaCadetes = new List<Persona>();
        static List<Persona> listaUsuarios = new List<Persona>();

        private readonly ILogger<PersonaController> _logger;

        public PersonaController(ILogger<PersonaController> logger)
        {
            _logger = logger;
        }

        // public string Index(int id)
        // {
        //     return "Hola Operador nro "+id;
        // } 

        public IActionResult ConsultaCadete() {
            var unCadete = new Cadete("Pepito","dire 01", "tel 388");
            return View(unCadete);
        }

        [HttpGet]
        public IActionResult AltaCliente(){
            return View();
        }

        [HttpPost]
        public IActionResult AltaCliente(Cadete cadete) {
            return RedirectToAction("Index");
        }


        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}