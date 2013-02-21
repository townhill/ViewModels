namespace ViewModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        DateEaten = c.DateTime(nullable: false),
                        Description = c.String(maxLength: 100),
                        Calories = c.Int(nullable: false),
                        Quantity = c.String(),
                        MealTime_MealTimeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MealTimes", t => t.MealTime_MealTimeId)
                .Index(t => t.MealTime_MealTimeId);
            
            CreateTable(
                "dbo.MealTimes",
                c => new
                    {
                        MealTimeId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.MealTimeId);
            
            CreateTable(
                "dbo.Exercises",
                c => new
                    {
                        ExerciseId = c.Long(nullable: false, identity: true),
                        DateExercised = c.DateTime(nullable: false),
                        Description = c.String(),
                        Calories = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExerciseId);
            
            CreateTable(
                "dbo.DayBooks",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        UserName = c.String(),
                        FoodId = c.Long(nullable: false),
                        ExerciseId = c.Long(nullable: false),
                        GenericCalorieId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Foods", new[] { "MealTime_MealTimeId" });
            DropForeignKey("dbo.Foods", "MealTime_MealTimeId", "dbo.MealTimes");
            DropTable("dbo.DayBooks");
            DropTable("dbo.Exercises");
            DropTable("dbo.MealTimes");
            DropTable("dbo.Foods");
        }
    }
}
