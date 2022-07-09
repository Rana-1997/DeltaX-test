namespace MovieApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialconfig2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        DateOfBirth = c.DateTime(nullable: false),
                        MovieName = c.String(nullable: false),
                        Awards = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Actors");
        }
    }
}
