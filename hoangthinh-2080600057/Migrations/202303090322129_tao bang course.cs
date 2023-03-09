namespace hoangthinh_2080600057.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class taobangcourse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        lecturnerId = c.String(),
                        place = c.String(nullable: false, maxLength: 255),
                        datetime = c.DateTime(nullable: false),
                        CategoryId = c.Byte(nullable: false),
                        Lecturet_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.Lecturet_Id)
                .Index(t => t.CategoryId)
                .Index(t => t.Lecturet_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.courses", "Lecturet_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.courses", "CategoryId", "dbo.Categories");
            DropIndex("dbo.courses", new[] { "Lecturet_Id" });
            DropIndex("dbo.courses", new[] { "CategoryId" });
            DropTable("dbo.courses");
            DropTable("dbo.Categories");
        }
    }
}
