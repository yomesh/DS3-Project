namespace EACUniformsDS3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sizes",
                c => new
                    {
                        size_Id = c.Int(nullable: false, identity: true),
                        description = c.String(nullable: false, maxLength: 100),
                        item_Id = c.Int(nullable: false),
                        stock_qty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.size_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sizes");
        }
    }
}
