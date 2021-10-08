namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CID);
            
            CreateTable(
                "dbo.CategoriesInStocks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SID = c.Int(nullable: false),
                        CID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.CID, cascadeDelete: true)
                .ForeignKey("dbo.Stocks", t => t.SID, cascadeDelete: true)
                .Index(t => t.SID)
                .Index(t => t.CID);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        SID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SID);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Quantity = c.Int(nullable: false),
                        CID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.CID, cascadeDelete: true)
                .Index(t => t.CID);
            
            CreateTable(
                "dbo.ItemExports",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        QuantityOut = c.Int(nullable: false),
                        DateOut = c.DateTime(nullable: false),
                        ItemID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Items", t => t.ItemID, cascadeDelete: true)
                .Index(t => t.ItemID);
            
            CreateTable(
                "dbo.ItemImports",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        QuantityIn = c.Int(nullable: false),
                        DateIn = c.DateTime(nullable: false),
                        ItemID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Items", t => t.ItemID, cascadeDelete: true)
                .Index(t => t.ItemID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemImports", "ItemID", "dbo.Items");
            DropForeignKey("dbo.ItemExports", "ItemID", "dbo.Items");
            DropForeignKey("dbo.Items", "CID", "dbo.Categories");
            DropForeignKey("dbo.CategoriesInStocks", "SID", "dbo.Stocks");
            DropForeignKey("dbo.CategoriesInStocks", "CID", "dbo.Categories");
            DropIndex("dbo.ItemImports", new[] { "ItemID" });
            DropIndex("dbo.ItemExports", new[] { "ItemID" });
            DropIndex("dbo.Items", new[] { "CID" });
            DropIndex("dbo.CategoriesInStocks", new[] { "CID" });
            DropIndex("dbo.CategoriesInStocks", new[] { "SID" });
            DropTable("dbo.ItemImports");
            DropTable("dbo.ItemExports");
            DropTable("dbo.Items");
            DropTable("dbo.Stocks");
            DropTable("dbo.CategoriesInStocks");
            DropTable("dbo.Categories");
        }
    }
}
