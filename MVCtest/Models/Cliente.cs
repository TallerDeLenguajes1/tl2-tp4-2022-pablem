using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCtest.Models
{
    public class Cliente
    {
        string nombre;
        int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}