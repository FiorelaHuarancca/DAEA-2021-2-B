using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab14.Models;
using System.Net;

namespace Lab14.Models
{
    public class CategoriesController : Controller
    {
        private NORTHWNDEntities _contexto;

        public NORTHWNDEntities Contexto
        {
            set { _contexto = value; }
            get
            {
                if (_contexto == null)
                    _contexto = new NORTHWNDEntities();
                return _contexto;
            }
        }
        // GET: Categories
        public ActionResult Index()
        {
            return View(Contexto.Categories.ToList());
        }

        public ActionResult Details(int id)
        {
            var productosPorcategoria = from p in Contexto.Products
                                        orderby p.ProductName ascending

                                        where p.CategoryID == id
                                        select p;
            return View(productosPorcategoria.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Categories nuevaCategoria)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Contexto.Categories.Add(nuevaCategoria);
                    Contexto.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(nuevaCategoria);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Categories CategoriaEditar = Contexto.Categories.Find(id);

            if (CategoriaEditar == null)
                return HttpNotFound();

            return View(CategoriaEditar);
        }

        [HttpPost]
        public ActionResult Edit(Categories CategoriaEditar)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    Contexto.Entry(CategoriaEditar).State = System.Data.EntityState.Modified;
                    Contexto.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(CategoriaEditar);
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Delete(int id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Categories CategoriaEliminar = Contexto.Categories.Find(id);

            if (CategoriaEliminar == null)
                return HttpNotFound();

            return View(CategoriaEliminar);
        }

        [HttpPost]
        public ActionResult Delete(int? id, Categories Categoria1)
        {
            try
            {
                Categories CategoriaEliminar = new Categories();
                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    Contexto.Entry(CategoriaEditar).State = System.Data.EntityState.Modified;
                    Contexto.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(CategoriaEditar);
            }
            catch
            {
                return View();
            }
        }
    }
}