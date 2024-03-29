﻿using System.Data.Entity;

namespace ViewModels.Models
{
    public class MyDBContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<ViewModels.Models.MyDBContext>());

        public MyDBContext() : base("name=MyDBContext")
        {
        }

        public DbSet<Food> Foods { get; set; }

        public DbSet<Exercise> Exercises { get; set; }

        public DbSet<DayBook> DayBooks { get; set; }
    }
}
