namespace EACUniformsDS3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        school_Id = c.Int(nullable: false, identity: true),
                        school_Name = c.String(nullable: false, maxLength: 100),
                        address_Line1 = c.String(nullable: false, maxLength: 100),
                        address_Line2 = c.String(nullable: false, maxLength: 100),
                        suburb = c.String(nullable: false, maxLength: 100),
                        city = c.String(nullable: false, maxLength: 100),
                        postal_Code = c.String(nullable: false),
                        contact_Person = c.String(nullable: false, maxLength: 100),
                        Contact_eMail_Address = c.String(nullable: false),
                        contact_Number = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.school_Id);
            
            AddColumn("dbo.Items", "school_Name", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "school_Name");
            DropTable("dbo.Schools");
        }
    }
}
