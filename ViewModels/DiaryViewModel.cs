using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ViewModels.Models
{
    //  This is the ViewModel tht contains all the data needed for the view
    public class DiaryViewModel
    {
        public List<Food> Foods { get; set; }
        public List<Exercise> Exercises { get; set; }
        public List<GenericCalorie> GenericCalories { get; set; }  

        // Stores the selected value from the drop down box.
        public int MealTimeId { get; set; }
        // Contains the list of meal times - fixed.
        public SelectList MealTimes { get; set; }
    }
}