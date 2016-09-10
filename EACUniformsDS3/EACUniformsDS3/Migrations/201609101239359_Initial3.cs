namespace EACUniformsDS3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        Supplier = c.String(nullable: false),
                        ExpectedDeliveryDate = c.DateTime(nullable: false),
                        OrderedByUser = c.String(nullable: false),
                        Status = c.String(nullable: false),
                        total = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId);
            
            CreateTable(
                "dbo.OrdItems",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        Supplier = c.String(nullable: false),
                        item_Id = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        RecQuantity = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        description = c.String(nullable: false, maxLength: 100),
                        total = c.Double(nullable: false),
                        vat = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OrdItems");
            DropTable("dbo.Orders");
        }
    }
}
