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
    public class FoodController : Controller
    {
        private MyDBContext db = new MyDBContext();

        //
        // GET: /Food/

        public ActionResult Index()
        {
            return View(db.Foods.ToList());
        }

        public ActionResult View()
        {
            //  Build the ViewModel for our View
            DiaryViewModel viewmodel = new DiaryViewModel()
            {
                Exercises = new List<Exercise>(),
                Foods = new List<Food>()
               
            };

            viewmodel.Exercises = db.Exercises.ToList();
            viewmodel.Foods = db.Foods.ToList();

            var mealTimes = new List<MealTime>
                {
                    new MealTime {MealTimeId = 1, Description = "Author 1"},
                    new MealTime {MealTimeId = 2, Description = "Author 2"},
                    new MealTime {MealTimeId = 3, Description = "Author 3"},
                    new MealTime {MealTimeId = 4, Description = "Author 4"}
                };

            viewmodel.MealTimes = new SelectList(mealTimes, "MealTimeId", "Description");

            return View(viewmodel);
        }

        public List<MealTime> GetMeals()
        {
            return new List<MealTime>();
        }
        //
        // GET: /Food/Details/5

        public ActionResult Details(long id = 0)
        {
            Food food = db.Foods.Find(id);
            if (food == null)
            {
                return HttpNotFound();
            }
            return View(food);
        }

        //
        // GET: /Food/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Food/Create

        [HttpPost]
        public ActionResult Create(Food food)
        {
            if (ModelState.IsValid)
            {
                db.Foods.Add(food);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(food);
        }

        //
        // GET: /Food/Edit/5

        public ActionResult Edit(long id = 0)
        {
            Food food = db.Foods.Find(id);
            if (food == null)
            {
                return HttpNotFound();
            }
            return View(food);
        }

        //
        // POST: /Food/Edit/5

        [HttpPost]
        public ActionResult Edit(Food food)
        {
            if (ModelState.IsValid)
            {
                db.Entry(food).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(food);
        }

        //
        // GET: /Food/Delete/5

        public ActionResult Delete(long id = 0)
        {
            Food food = db.Foods.Find(id);
            if (food == null)
            {
                return HttpNotFound();
            }
            return View(food);
        }

        //
        // POST: /Food/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(long id)
        {
            Food food = db.Foods.Find(id);
            db.Foods.Remove(food);
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