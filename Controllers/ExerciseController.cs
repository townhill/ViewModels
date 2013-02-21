using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModels.Models;

namespace ViewModels.Controllers
{
    public class ExerciseController : Controller
    {
        private MyDBContext db = new MyDBContext();

        //
        // GET: /Exercise/

        public ActionResult Index()
        {
            return View(db.Exercises.ToList());
        }

        //
        // GET: /Exercise/Details/5

        public ActionResult Details(long id = 0)
        {
            Exercise exercise = db.Exercises.Find(id);
            if (exercise == null)
            {
                return HttpNotFound();
            }
            return View(exercise);
        }

        //
        // GET: /Exercise/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Exercise/Create

        [HttpPost]
        public ActionResult Create(Exercise exercise)
        {
            if (ModelState.IsValid)
            {
                db.Exercises.Add(exercise);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(exercise);
        }

        //
        // GET: /Exercise/Edit/5

        public ActionResult Edit(long id = 0)
        {
            Exercise exercise = db.Exercises.Find(id);
            if (exercise == null)
            {
                return HttpNotFound();
            }
            return View(exercise);
        }

        //
        // POST: /Exercise/Edit/5

        [HttpPost]
        public ActionResult Edit(Exercise exercise)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exercise).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(exercise);
        }

        //
        // GET: /Exercise/Delete/5

        public ActionResult Delete(long id = 0)
        {
            Exercise exercise = db.Exercises.Find(id);
            if (exercise == null)
            {
                return HttpNotFound();
            }
            return View(exercise);
        }

        //
        // POST: /Exercise/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(long id)
        {
            Exercise exercise = db.Exercises.Find(id);
            db.Exercises.Remove(exercise);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}