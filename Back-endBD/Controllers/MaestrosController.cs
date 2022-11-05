using Back_endBD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Back_endBD.Controllers
{
    public class MaestrosController : Controller
    {
        // GET: Maestros
        public ActionResult Index()
        {
            using (AlumnoDBContext dbAlumnos = new AlumnoDBContext())
            {
                //select * from alumnos
                return View(dbAlumnos.Maestros.ToList());
            }
        }
        public ActionResult Details(int id)
        {
            using (AlumnoDBContext dbAlumnos = new AlumnoDBContext())
            {
                Maestros maestros = dbAlumnos.Maestros.Find(id);
                if (maestros == null)
                {
                    return HttpNotFound();
                }
                return View(maestros);
            }
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Maestros mae)
        {
            using (AlumnoDBContext dbAlumnos = new AlumnoDBContext())
            {
                dbAlumnos.Maestros.Add(mae);
                dbAlumnos.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int? id)
        {
            using (AlumnoDBContext dbAlumnos = new AlumnoDBContext())
            {
                return View(dbAlumnos.Maestros.Where(x => x.id == id).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult Edit(Maestros mae)
        {
            using (AlumnoDBContext dbAlumnos = new AlumnoDBContext())
            {
                dbAlumnos.Entry(mae).State = System.Data.Entity.EntityState.Modified;
                dbAlumnos.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int? id)
        {
            using (AlumnoDBContext dbAlumnos = new AlumnoDBContext())
            {
                return View(dbAlumnos.Maestros.Where(x => x.id == id).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult Delete(Maestros mae, int id)
        {
            using (AlumnoDBContext dbAlumnos = new AlumnoDBContext())
            {
                Maestros ma = dbAlumnos.Maestros.Where(x => x.id == id).FirstOrDefault();
                dbAlumnos.Maestros.Remove(ma);
                dbAlumnos.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}