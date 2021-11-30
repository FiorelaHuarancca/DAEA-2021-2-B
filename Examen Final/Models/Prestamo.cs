using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen_Final.Models
{
    public class Prestamo
    {
        public int PrestamoID { get; set; }
        public int LibroID { get; set; }
        public int UsuarioID { get; set; }
        public DateTime FecPrestamo { get; set; }
        public DateTime FecDevolucion { get; set; }
    }
}