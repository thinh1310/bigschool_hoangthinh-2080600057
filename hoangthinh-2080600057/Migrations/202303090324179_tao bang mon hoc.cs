namespace hoangthinh_2080600057.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class taobangmonhoc : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES(ID,NAME) VALUES(1,'Development')");
            Sql("INSERT INTO CATEGORIES(ID,NAME) VALUES (2,'BUSINESS')");
            Sql("INSERT INTO CATEGORIES(ID,NAME) VALUES (3,'MARKETTING')");
        }
        
        public override void Down()
        {
        }
    }
}
