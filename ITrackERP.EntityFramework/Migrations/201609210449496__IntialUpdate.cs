namespace ITrackERP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _IntialUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CuttingRatios", "StyleId", "dbo.Styles");
            DropForeignKey("dbo.WorkOrders", "StyleId", "dbo.Styles");
            DropIndex("dbo.CuttingRatios", new[] { "StyleId" });
            DropIndex("dbo.WorkOrders", new[] { "StyleId" });
            RenameColumn(table: "dbo.WorkOrders", name: "StyleId", newName: "Style_StyleNo");
            DropPrimaryKey("dbo.Styles");
            AlterColumn("dbo.WorkOrders", "Style_StyleNo", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Styles", "StyleNo");
            CreateIndex("dbo.WorkOrders", "Style_StyleNo");
            AddForeignKey("dbo.WorkOrders", "Style_StyleNo", "dbo.Styles", "StyleNo");
            DropColumn("dbo.CuttingRatios", "StyleId");
            DropColumn("dbo.Styles", "StyleId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Styles", "StyleId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.CuttingRatios", "StyleId", c => c.Int(nullable: false));
            DropForeignKey("dbo.WorkOrders", "Style_StyleNo", "dbo.Styles");
            DropIndex("dbo.WorkOrders", new[] { "Style_StyleNo" });
            DropPrimaryKey("dbo.Styles");
            AlterColumn("dbo.WorkOrders", "Style_StyleNo", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Styles", "StyleId");
            RenameColumn(table: "dbo.WorkOrders", name: "Style_StyleNo", newName: "StyleId");
            CreateIndex("dbo.WorkOrders", "StyleId");
            CreateIndex("dbo.CuttingRatios", "StyleId");
            AddForeignKey("dbo.WorkOrders", "StyleId", "dbo.Styles", "StyleId", cascadeDelete: true);
            AddForeignKey("dbo.CuttingRatios", "StyleId", "dbo.Styles", "StyleId", cascadeDelete: true);
        }
    }
}
