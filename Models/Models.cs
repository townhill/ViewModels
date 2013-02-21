using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViewModels.Models
{

    //
    //  Main class that contains all the info needed for each day the user keeps a record
    //
    public class DayBook
    {
        public long Id { get; set; }
        public DateTime DateTime { get; set; }
        public string UserName { get; set; }
        //  Use the virtual keywork for foriegn keys
        public virtual long FoodId { get; set; }
        public virtual long ExerciseId { get; set; }
        public virtual long GenericCalorieId { get; set; }
    }

    public class Food
    {
        [Key]
        public long Id { get; set; }

        public DateTime DateEaten { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        public MealTime MealTime { get; set; }
        public int Calories { get; set; }
        public string Quantity { get; set; }
    }

    public class Exercise
    {
        [Key]
        public long ExerciseId { get; set; }

        public DateTime DateExercised { get; set; }
        public string Description { get; set; }
        public int Calories { get; set; }
    }

    public class GenericCalorie
    {
        [Key]
        public long GenericCalorieId { get; set; }

        public DateTime DateEaten { get; set; }
        public string Description { get; set; }
        public int Calories { get; set; }
    }
}