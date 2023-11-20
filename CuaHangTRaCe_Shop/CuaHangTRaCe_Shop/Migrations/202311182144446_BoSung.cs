namespace CuaHangTRaCe_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BoSung : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.NguoiDung", "ID_TaiKhoan", "dbo.TaiKhoan");
            DropIndex("dbo.NguoiDung", new[] { "ID_TaiKhoan" });
            DropPrimaryKey("dbo.TaiKhoan");
            AlterColumn("dbo.NguoiDung", "ID_TaiKhoan", c => c.String(nullable: false, maxLength: 128, fixedLength: true, unicode: false));
            AlterColumn("dbo.TaiKhoan", "ID_TaiKhoan", c => c.String(nullable: false, maxLength: 128, fixedLength: true, unicode: false));
            AddPrimaryKey("dbo.TaiKhoan", "ID_TaiKhoan");
            CreateIndex("dbo.NguoiDung", "ID_TaiKhoan");
            AddForeignKey("dbo.NguoiDung", "ID_TaiKhoan", "dbo.TaiKhoan", "ID_TaiKhoan", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NguoiDung", "ID_TaiKhoan", "dbo.TaiKhoan");
            DropIndex("dbo.NguoiDung", new[] { "ID_TaiKhoan" });
            DropPrimaryKey("dbo.TaiKhoan");
            AlterColumn("dbo.TaiKhoan", "ID_TaiKhoan", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.NguoiDung", "ID_TaiKhoan", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.TaiKhoan", "ID_TaiKhoan");
            CreateIndex("dbo.NguoiDung", "ID_TaiKhoan");
            AddForeignKey("dbo.NguoiDung", "ID_TaiKhoan", "dbo.TaiKhoan", "ID_TaiKhoan", cascadeDelete: true);
        }
    }
}
