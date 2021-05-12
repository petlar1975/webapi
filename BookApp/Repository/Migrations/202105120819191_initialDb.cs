namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                        Author = c.String(),
                        Content = c.String(),
                        CreatedDatetime = c.DateTime(nullable: false),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "UserId", "dbo.Users");
            DropIndex("dbo.Books", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Books");
        }
    }
}
