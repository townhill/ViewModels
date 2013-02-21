namespace ViewModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AmendedExercisetable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Exercises", "DateExercised", c => c.DateTime(nullable: false));
            DropColumn("dbo.Exercises", "ExerciseId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Exercises", "ExerciseId", c => c.DateTime(nullable: false));
            DropColumn("dbo.Exercises", "DateExercised");
        }
    }
}
