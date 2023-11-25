namespace CuaHangTRaCe_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createDb1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PhuKien", "HinhAnh", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PhuKien", "HinhAnh", c => c.Binary(nullable: false));
        }
    }
}
