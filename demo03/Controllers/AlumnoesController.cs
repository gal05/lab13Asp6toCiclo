using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using demo03.Models;

namespace demo03.Controllers
{
    public class AlumnoesController : Controller
    {
        private demo03Context db = new demo03Context();

        // GET: Alumnoes
        public ActionResult Index()
        {
            return View(db.Alumnoes.ToList());
        }

        // GET: Alumnoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = db.Alumnoes.Find(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            return View(alumno);
        }

        // GET: Alumnoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alumnoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Apellido,Nombre,Edad,Dni")] Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                db.Alumnoes.Add(alumno);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(alumno);
        }

        // GET: Alumnoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = db.Alumnoes.Find(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            return View(alumno);
        }

        // POST: Alumnoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Apellido,Nombre,Edad,Dni")] Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(alumno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(alumno);
        }

        // GET: Alumnoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = db.Alumnoes.Find(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            return View(alumno);
        }

        // POST: Alumnoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Alumno alumno = db.Alumnoes.Find(id);
            db.Alumnoes.Remove(alumno);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
