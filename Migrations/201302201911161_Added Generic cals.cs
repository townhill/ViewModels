namespace ViewModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGenericcals : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foods", "Quantity", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Foods", "Quantity");
        }
    }
}
