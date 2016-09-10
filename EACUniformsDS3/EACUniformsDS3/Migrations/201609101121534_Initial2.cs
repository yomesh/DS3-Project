namespace EACUniformsDS3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        supplier_Id = c.Int(nullable: false, identity: true),
                        supplier_Name = c.String(nullable: false, maxLength: 100),
                        email_Address = c.String(nullable: false),
                        contact_Number = c.String(nullable: false),
                        ContactName = c.String(nullable: false, maxLength: 100),
                        ContactSurname = c.String(nullable: false, maxLength: 100),
                        address_Line1 = c.String(nullable: false, maxLength: 100),
                        address_Line2 = c.String(nullable: false, maxLength: 100),
                        suburb = c.String(nullable: false, maxLength: 100),
                        city = c.String(nullable: false, maxLength: 100),
                        postal_Code = c.String(nullable: false),
                        Lead_Time = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.supplier_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Suppliers");
        }
    }
}
