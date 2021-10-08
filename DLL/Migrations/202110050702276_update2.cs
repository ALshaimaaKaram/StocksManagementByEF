namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Items", "CID", "dbo.Categories");
            DropIndex("dbo.Items", new[] { "CID" });
            AlterColumn("dbo.Items", "Quantity", c => c.Int());
            AlterColumn("dbo.Items", "CID", c => c.Int());
            CreateIndex("dbo.Items", "CID");
            AddForeignKey("dbo.Items", "CID", "dbo.Categories", "CID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "CID", "dbo.Categories");
            DropIndex("dbo.Items", new[] { "CID" });
            AlterColumn("dbo.Items", "CID", c => c.Int(nullable: false));
            AlterColumn("dbo.Items", "Quantity", c => c.Int(nullable: false));
            CreateIndex("dbo.Items", "CID");
            AddForeignKey("dbo.Items", "CID", "dbo.Categories", "CID", cascadeDelete: true);
        }
    }
}
