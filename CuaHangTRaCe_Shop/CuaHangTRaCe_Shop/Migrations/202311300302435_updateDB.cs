namespace CuaHangTRaCe_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BASE_ID", "TinhTrang", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BASE_ID", "TinhTrang", c => c.Int(nullable: false));
        }
    }
}
