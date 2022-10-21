using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCtest.Models
{
    public class Turno
    {
        int idTurno;
        string nombre;

        public int IdTurno { get => idTurno; set => idTurno = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
    }
}