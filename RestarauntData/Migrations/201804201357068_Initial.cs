namespace RestarauntData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Restauraunts",
                c => new
                    {
                        RestaurauntId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.RestaurauntId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Restauraunts");
        }
    }
}