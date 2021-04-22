using System;
using System.Collections.Generic;

namespace Nivelacion.Modelo
{
    public partial class Empleados
    {
        public uint Cedula { get; set; }
        public string Nombre { get; set; }
        public int? Sueldo { get; set; }
        public int? Diasvaca { get; set; }
        public int? Diaspagos { get; set; }
    }
}
