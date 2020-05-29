using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using T2.DB;
using T2.Models;

namespace T2.Controllers
{
    public class PeliculaController : Controller
    {
        private APPContexDB conexion = new APPContexDB();
        public IActionResult Index()
        {
            return View(conexion.Peliculas.ToList());
        }
        public IActionResult BuscarPorNombre(string query)
        {
            return View(conexion.Peliculas.Where(a=>a.Nombre.Contains(query)).ToList());
        }
        public IActionResult BuscarFavoritas(string query)
        {
            return View(conexion.Peliculas.Where(a => a.Favorita==true).ToList());
        }
        [HttpGet]
        public ActionResult Crear()
        {
            return View(new Pelicula());
        }
        [HttpPost]
        public ActionResult Crear(Pelicula pelicula)
        {
            validar(pelicula);
            if (ModelState.IsValid == true)
            {
                conexion.Peliculas.Add(pelicula);
                pelicula.Imagen = "";
                pelicula.Favorita = false;
                conexion.SaveChanges();
                return RedirectToAction("MarcarComoFavorita");
            }

            return View(pelicula);
     
        }
        [HttpGet]
        public ActionResult MarcarComoFavorita()
        {
            var peliculas = conexion.Peliculas.ToList();


            var pelicula = conexion.Peliculas.Where(a => a.Id_Pelicula == peliculas[peliculas.Count-1].Id_Pelicula).First();
            return View(pelicula);
        }
        [HttpGet]
        public ActionResult MarcarFavorita(int id)
        {
            var pelicula = conexion.Peliculas.Where(a => a.Id_Pelicula == id).First();
            pelicula.Favorita = true;
            conexion.SaveChanges();
            return RedirectToAction("Index");
        }
        public void validar(Pelicula pelicula)
        {

            if (pelicula.Codigo == null || pelicula.Codigo == "")
                ModelState.AddModelError("Codigo", "El codigo es obligatorio");
            if (pelicula.Codigo != null || pelicula.Codigo != "")
            {
                var codigo = conexion.Peliculas.Any(a => a.Codigo == pelicula.Codigo);
                if (codigo)
                {
                    ModelState.AddModelError("Codigo", "Este codigo ya existe");
                }
            }

            
            if (pelicula.Nombre == null || pelicula.Nombre == "")
                ModelState.AddModelError("Nombre", "El nombre es obligatorio");
            if (pelicula.Director == "--Seleccione--")
                ModelState.AddModelError("Director", "El director es obligatorio");
            if (pelicula.Director == "--Seleccione--")
                ModelState.AddModelError("Anio", "El año es obligatorio");
        }

        }
}