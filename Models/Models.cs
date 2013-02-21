using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViewModels.Models
{
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
        public long Id { get; set; }

        public DateTime DateExercised { get; set; }
        public string Description { get; set; }
        public int Calories { get; set; }
    }

    public class GenericCalorie
    {
        [Key]
        public long Id { get; set; }

        public DateTime DateEaten { get; set; }
        public string Description { get; set; }
        public int Calories { get; set; }
    }
}