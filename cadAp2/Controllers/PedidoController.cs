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
    // [Route("[controller]")]
    public class PedidoController : Controller
    {
        static int nPedidos;

        static List<Pedido> listaPedidos = new List<Pedido>();

        private readonly ILogger<PedidoController> _logger;

        public PedidoController(ILogger<PedidoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListaPedidos()
        {
            return View(listaPedidos);
        }

        public IActionResult AltaPedido()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AltaPedidoPost(Pedido pedido) {
            pedido.Nro = ++nPedidos;
            listaPedidos.Add(pedido);
            return View("ListaPedidos", listaPedidos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}