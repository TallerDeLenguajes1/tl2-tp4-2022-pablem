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
    // [Route("[cliente]")]
    public class ClienteController : Controller
    {
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
        }

        public string Index(int id)
        {
            return "Hola cliente nro "+id;
        }

        public IActionResult consultaCliente() {
            var miCliente = new Cliente();
            miCliente.Nombre="Pepito";
            miCliente.Edad=88;
            return View(miCliente);
        }

        [HttpGet]
        public IActionResult AltaCliente(){
            return View();
        }

        [HttpPost]
        public IActionResult AltaCliente(Cliente cliente) {
            return RedirectToAction("Index");
        }


        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}