namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Author = c.String(nullable: false),
                        YearOfPublishing = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        LibraryID = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClientBooks",
                c => new
                    {
                        Client_Id = c.Int(nullable: false),
                        Book_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Client_Id, t.Book_Id })
                .ForeignKey("dbo.Clients", t => t.Client_Id, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_Id, cascadeDelete: true)
                .Index(t => t.Client_Id)
                .Index(t => t.Book_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClientBooks", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.ClientBooks", "Client_Id", "dbo.Clients");
            DropIndex("dbo.ClientBooks", new[] { "Book_Id" });
            DropIndex("dbo.ClientBooks", new[] { "Client_Id" });
            DropTable("dbo.ClientBooks");
            DropTable("dbo.Clients");
            DropTable("dbo.Books");
        }
    }
}
