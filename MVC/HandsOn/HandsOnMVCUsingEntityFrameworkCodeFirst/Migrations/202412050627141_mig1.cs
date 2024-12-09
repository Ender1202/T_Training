namespace HandsOnMVCUsingEntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Stock", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Stock");
        }
    }
}
