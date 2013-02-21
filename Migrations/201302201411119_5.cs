namespace ViewModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MealTimes",
                c => new
                    {
                        MealTimeId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.MealTimeId);
            
            AddColumn("dbo.Foods", "MealTime_MealTimeId", c => c.Int());
            AddForeignKey("dbo.Foods", "MealTime_MealTimeId", "dbo.MealTimes", "MealTimeId");
            CreateIndex("dbo.Foods", "MealTime_MealTimeId");
            DropColumn("dbo.Foods", "MealTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Foods", "MealTime", c => c.Int(nullable: false));
            DropIndex("dbo.Foods", new[] { "MealTime_MealTimeId" });
            DropForeignKey("dbo.Foods", "MealTime_MealTimeId", "dbo.MealTimes");
            DropColumn("dbo.Foods", "MealTime_MealTimeId");
            DropTable("dbo.MealTimes");
        }
    }
}
