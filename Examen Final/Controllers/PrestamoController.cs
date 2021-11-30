using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Examen_Final.Models;

namespace Examen_Final.Controllers
{
    public class PrestamoController : Controller
    {
        // GET: Prestamo
        public ActionResult Index()
        {
            return View();
        }

        private List<Prestamo> llenarPrestamo()
        {
            List<Prestamo> prestamos = new List<Prestamo>();
            prestamos.Add(new Prestamo
            {
                PrestamoID = 001,
                LibroID = 200,
                UsuarioID = 100,
                FecPrestamo = Convert.ToDateTime("2021-11-07"),
                FecDevolucion = Convert.ToDateTime("2021-11-17")
            });

            prestamos.Add(new Prestamo
            {
                PrestamoID = 002,
                LibroID = 201,
                UsuarioID = 101,
                FecPrestamo = Convert.ToDateTime("2021-10-02"),
                FecDevolucion = Convert.ToDateTime("2021-11-20")
            });

            prestamos.Add(new Prestamo
            {
                PrestamoID = 003,
                LibroID = 202,
                UsuarioID = 102,
                FecPrestamo = Convert.ToDateTime("2021-11-15"),
                FecDevolucion = Convert.ToDateTime("2021-11-30")
            });

            return prestamos;
        }
    }
}