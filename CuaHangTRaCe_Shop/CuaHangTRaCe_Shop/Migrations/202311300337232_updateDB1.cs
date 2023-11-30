namespace CuaHangTRaCe_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDB1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CPU", "SoLoi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CPU", "SoLoi", c => c.Int(nullable: false));
        }
    }
}
