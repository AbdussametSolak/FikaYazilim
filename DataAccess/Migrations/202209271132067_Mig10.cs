namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        categoryId = c.Int(nullable: false, identity: true),
                        categoryName = c.String(),
                    })
                .PrimaryKey(t => t.categoryId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        productId = c.Int(nullable: false, identity: true),
                        productName = c.String(),
                        categoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.productId)
                .ForeignKey("dbo.Categories", t => t.categoryId, cascadeDelete: true)
                .Index(t => t.categoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "categoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "categoryId" });
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
