namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit_table : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Items", "CID", "dbo.Categories");
            DropIndex("dbo.Items", new[] { "CID" });
            AddColumn("dbo.Items", "CSID", c => c.Int());
            CreateIndex("dbo.Items", "CSID");
            AddForeignKey("dbo.Items", "CSID", "dbo.CategoriesInStocks", "ID");
            DropColumn("dbo.Items", "CID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "CID", c => c.Int());
            DropForeignKey("dbo.Items", "CSID", "dbo.CategoriesInStocks");
            DropIndex("dbo.Items", new[] { "CSID" });
            DropColumn("dbo.Items", "CSID");
            CreateIndex("dbo.Items", "CID");
            AddForeignKey("dbo.Items", "CID", "dbo.Categories", "CID");
        }
    }
}
