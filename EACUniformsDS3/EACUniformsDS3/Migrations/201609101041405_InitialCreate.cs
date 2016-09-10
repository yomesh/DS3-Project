namespace EACUniformsDS3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        item_Id = c.Int(nullable: false, identity: true),
                        description = c.String(nullable: false, maxLength: 100),
                        Cprice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Sprice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        supplier = c.String(nullable: false),
                        imageUrl = c.String(),
                    })
                .PrimaryKey(t => t.item_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Items");
        }
    }
}
