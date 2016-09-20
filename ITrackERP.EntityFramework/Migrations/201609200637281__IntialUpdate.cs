namespace ITrackERP.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class _IntialUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CuttingRatioItems",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TenantId = c.Int(nullable: false),
                        RatioItemId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_CuttingRatioItem_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                    { "DynamicFilter_CuttingRatioItem_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CuttingRatios",
                c => new
                    {
                        RatioId = c.Int(nullable: false, identity: true),
                        TenantId = c.Int(nullable: false),
                        Color = c.String(),
                        Length = c.Int(nullable: false),
                        MarkerLength = c.Int(nullable: false),
                        MarkerWidth = c.Int(nullable: false),
                        LayerLength = c.Int(nullable: false),
                        FabricType = c.String(),
                        Remark = c.String(),
                        StyleId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        Id = c.Guid(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_CuttingRatio_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                    { "DynamicFilter_CuttingRatio_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.RatioId)
                .ForeignKey("dbo.Styles", t => t.StyleId, cascadeDelete: true)
                .Index(t => t.StyleId);
            
            CreateTable(
                "dbo.Styles",
                c => new
                    {
                        StyleId = c.Int(nullable: false, identity: true),
                        TenantId = c.Int(nullable: false),
                        StyleNo = c.String(nullable: false, maxLength: 128),
                        ArticleNo = c.String(),
                        Season = c.String(),
                        Remark = c.String(),
                        OrderType = c.String(),
                        Department = c.String(),
                        BocNo = c.String(nullable: false),
                        ItemType = c.String(),
                        BuyerId = c.String(nullable: false),
                        ImagePath = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        Id = c.Guid(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Style_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                    { "DynamicFilter_Style_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.StyleId);
            
            CreateTable(
                "dbo.WorkOrders",
                c => new
                    {
                        WorkOrderId = c.Int(nullable: false, identity: true),
                        TenantId = c.Int(nullable: false),
                        PoNo = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Status = c.String(),
                        Priority = c.String(),
                        Remark = c.String(),
                        StyleId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        Id = c.Guid(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_WorkOrder_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                    { "DynamicFilter_WorkOrder_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.WorkOrderId)
                .ForeignKey("dbo.Styles", t => t.StyleId, cascadeDelete: true)
                .Index(t => t.StyleId);
            
            CreateTable(
                "dbo.WorkOrderRatios",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TenantId = c.Int(nullable: false),
                        WorkOrderId = c.Int(nullable: false),
                        Color = c.String(),
                        Size = c.String(),
                        Length = c.String(),
                        Quantity = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_WorkOrderRatio_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                    { "DynamicFilter_WorkOrderRatio_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.WorkOrders", t => t.WorkOrderId, cascadeDelete: true)
                .Index(t => t.WorkOrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CuttingRatios", "StyleId", "dbo.Styles");
            DropForeignKey("dbo.WorkOrderRatios", "WorkOrderId", "dbo.WorkOrders");
            DropForeignKey("dbo.WorkOrders", "StyleId", "dbo.Styles");
            DropIndex("dbo.WorkOrderRatios", new[] { "WorkOrderId" });
            DropIndex("dbo.WorkOrders", new[] { "StyleId" });
            DropIndex("dbo.CuttingRatios", new[] { "StyleId" });
            DropTable("dbo.WorkOrderRatios",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_WorkOrderRatio_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                    { "DynamicFilter_WorkOrderRatio_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.WorkOrders",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_WorkOrder_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                    { "DynamicFilter_WorkOrder_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.Styles",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Style_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                    { "DynamicFilter_Style_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.CuttingRatios",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_CuttingRatio_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                    { "DynamicFilter_CuttingRatio_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.CuttingRatioItems",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_CuttingRatioItem_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                    { "DynamicFilter_CuttingRatioItem_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
