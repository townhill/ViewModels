namespace ViewModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class date : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foods", "DateEaten", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Foods", "Description", c => c.String(maxLength: 100));
            DropColumn("dbo.Foods", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Foods", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Foods", "Description", c => c.String());
            DropColumn("dbo.Foods", "DateEaten");
        }
    }
}
