namespace RestarauntData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRatings : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Restauraunts", "Rating", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Restauraunts", "Rating");
        }
    }
}
