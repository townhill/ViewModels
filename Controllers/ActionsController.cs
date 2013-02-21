using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModels.Models;

namespace ViewModels.Controllers
{

    public class ActionsController : Controller
    {
        private MyDBContext db = new MyDBContext();

        [HttpPost]
        public virtual ActionResult Add_Food(string food, double quantity, int mealTimeId)
        {
            var newFood = new Food {DateEaten = DateTime.Today, Description = food};
            db.Foods.Add(newFood);
            db.SaveChanges();

            return RedirectToAction("View" ,"Food");
            return RedirectToRoute("Food\\View");
                            return View("View", "Food");
        }


    }
}
