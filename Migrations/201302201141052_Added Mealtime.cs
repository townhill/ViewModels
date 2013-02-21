namespace ViewModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMealtime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foods", "MealTime", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Foods", "MealTime");
        }
    }
}
