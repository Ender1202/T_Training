namespace HandsOnMVCUsingEntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.String(nullable: false, maxLength: 5, fixedLength: true, unicode: false),
                        OrderDate = c.DateTime(nullable: false),
                        Qty = c.Int(nullable: false),
                        ProductId = c.String(maxLength: 5, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 5, fixedLength: true, unicode: false),
                        Name = c.String(nullable: false, maxLength: 20),
                        Description = c.String(maxLength: 20),
                        Price = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "ProductId", "dbo.Products");
            DropIndex("dbo.Orders", new[] { "ProductId" });
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
        }
    }
}
